using myselfFast.Component.File;
using myselfFast.Component.File.OSS;
using myselfFast.Component.Logging;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Domain.ExportImport;
using myselfFast.Fund.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using myselfFast.Fund.Core;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core.Common;
using System.Linq;
using System.Text;
using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core.Domain.Hukou;
using myselfFast.Fund.Services.DTO.Request.Hukou;
using myselfFast.Fund.Services.DTO.Response.Hukou;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.Collections;
namespace myselfFast.Fund.Services.HukouS
{
    public class PictrueFileService : BaseService<T_Sys_ImportFiles>, IPictrueFileService
    {
       private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;
 
        private readonly OSSFileStorage _ossFileStorage = new OSSFileStorage();
        private OSSFileConfiguration _fileConfiguration = GlobalConfiguration.Configuration.OSSFileConfigurations.FileConfigurations.First(t => t.Name == "HK");
         
        private IRepository<T_HK_Order> _tTEntityResponsity;

        public PictrueFileService(IRepository<T_Sys_ImportFiles> tEntityResponsity,
            IRepository<T_HK_Order> tTEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext, ILoggerProviderFactory iLoggerProviderFactory)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
            this._tTEntityResponsity = tTEntityResponsity;
        }
        /// <summary>
        /// base64转图片保存
        /// </summary>
        public string SaveBase64Pictrue(string base64str, int type,int  orderid, T_Admin_Account account)
        {
            string resStr = string.Empty;
            try
            {
                string new64Str = base64str.Replace("data:image/jpeg;base64,", "");
                //过滤特殊字符即可   
                string dummyData = new64Str.Trim().Replace("%", "").Replace(",", "").Replace(" ", "+");
                if (dummyData.Length % 4 > 0)
                {
                    dummyData = dummyData.PadRight(dummyData.Length + 4 - dummyData.Length % 4, '=');
                }
                byte[] arr = Convert.FromBase64String(dummyData);
                //byte[] arr = Convert.FromBase64String(new64Str);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(arr);
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(ms);

                string tempPath = System.Web.HttpContext.Current.Server.MapPath("~/Images/HK");
                if (!Directory.Exists(tempPath))
                {
                    Directory.CreateDirectory(tempPath);
                }
                string imgNewName = Guid.NewGuid() + ".jpg";
                string imgPath = tempPath + "\\" + imgNewName;
                bmp.Save(imgPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                ms.Close();

                string etag = string.Empty;
                bool upRes = _ossFileStorage.UploadFile(_fileConfiguration.AccessKeyId, _fileConfiguration.AccessKeySecret, _fileConfiguration.Endpoint, _fileConfiguration.DefaultBucketName, _fileConfiguration.KeyPrefix + imgNewName, imgPath, ref etag);
                if (upRes)
                {
                    //删除服务器图片
                    if (File.Exists(imgPath))
                        File.Delete(imgPath);

                    T_Sys_ImportFiles model = new T_Sys_ImportFiles()
                    {
                        Type = type,
                        TypeName = GetUploadFileTypeName(type),
                        UserId = account.Id,
                        UserName = account.UserName,
                        FileNameNew = imgNewName,
                        State = 1,
                        Path = _fileConfiguration.KeyPrefix,
                        CreateTime = DateTime.Now
                    };
                    model.SetNullToDefalut();
                    this.AddEntity(model);
                    //更新order表BackMoneyPic数据
                    T_HK_Order orderU = _tTEntityResponsity.GetById(orderid);
                    orderU.BackMoneyPic = model.Id;
                    orderU.UpdateTime = DateTime.Now;
                    orderU.Updater = account.UserName;
                    this._tTEntityResponsity.Update(orderU);
                }
                else
                {
                    resStr= "aveBase64Pictrue_上传图片失败，ID：" + account.Id + "，原因:上传阿里云失败";
                }
            }
            catch (Exception ex)
            {
                resStr = "上传图片失败"+ex.Message;

            }
            return resStr;
        }
        /// <summary>
        /// 获取导入类型中文名
        /// </summary>
        public string GetUploadFileTypeName(int type)
        {
            string resStr = string.Empty;
            string[] nameArray = new string[] { "", "", "", "", "借阅身份证正面", "借阅身份证反面", "迁出身份证正面照", "迁出身份证反面照", "准迁证", "财务退款证明", "集体户口快递导入", "迁出后新户口首页", "迁出后新户口本人页" };
            resStr = nameArray[type];
            return resStr;
        }

        /// <summary>
        /// 获取阿里云图片
        /// </summary>
        /// <returns>base64字符串</returns>
        public string GetBase64PictrueFromStream(string keyPrefix, string fileName)
        {
            string strPic = string.Empty;
            using (Stream stream = _ossFileStorage.DownFile(_fileConfiguration.AccessKeyId, _fileConfiguration.AccessKeySecret, _fileConfiguration.Endpoint, _fileConfiguration.DefaultBucketName, keyPrefix + fileName))
            {
                if (stream != null)
                {
                    byte[] arr = StreamToBytes(stream);
                    if (arr.Length > 0)
                        strPic = "data:image/jpeg;base64," + Convert.ToBase64String(arr);
                }
            }
            return strPic;
        }

        public byte[] StreamToBytes(Stream stream)
        {
            List<byte> bytes = new List<byte>();
            int temp = stream.ReadByte();
            while (temp != -1)
            {
                bytes.Add((byte)temp);
                temp = stream.ReadByte();
            }
            return bytes.ToArray();
        }
    }
}

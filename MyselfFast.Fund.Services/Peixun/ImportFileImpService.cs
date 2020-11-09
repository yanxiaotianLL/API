using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core.Domain.Hukou;
using myselfFast.Fund.Services.DTO.Request.Hukou;
using myselfFast.Fund.Services.DTO.Response.Hukou;
using myselfFast.Fund.Core.Domain.ExportImport;
using System.IO;
using myselfFast.Component.Logging;
using myselfFast.Fund.Core.Component.Logging;

using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.Collections;

using myselfFast.Component.File;
using myselfFast.Component.File.OSS;
using myselfFast.Fund.Core.Domain.Peixun;

//导入
namespace myselfFast.Fund.Services.Peixun
{
    public class ImportFileImpService : BaseService<T_Sys_ImportFiles>, IImportFileImpService
    {
        private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;

        private readonly OSSFileStorage _ossFileStorage = new OSSFileStorage();
        private OSSFileConfiguration _fileConfiguration = GlobalConfiguration.Configuration.OSSFileConfigurations.FileConfigurations.First(t => t.Name == "Peixun");

        private IRepository<T_Trn_Stu> _tTEntityResponsity;

        public ImportFileImpService(IRepository<T_Sys_ImportFiles> tEntityResponsity,
            IRepository<T_Trn_Stu> tTEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext, ILoggerProviderFactory iLoggerProviderFactory)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
            this._tTEntityResponsity = tTEntityResponsity;
        }
        /// <summary>
        /// 将文件上传到阿里云
        /// </summary>
        /// <returns></returns>
        public string InsertAndUploadSystemImportFile(string FileNameOld, string filepath, T_Admin_Account account,string LableId)
        {
            string path = filepath + "\\" + FileNameOld;
            string result = string.Empty;
            try
            {


                #region  要验证的文件
                byte[] data = File.ReadAllBytes(path);
                MemoryStream ms = new MemoryStream(data);

                //IWorkbook wb = new XSSFWorkbook(ms);
                IWorkbook wb = null;
                if (FileNameOld.IndexOf(".xlsx") > 0) // 2007版本
                    wb = new XSSFWorkbook(ms);
                else if (FileNameOld.IndexOf(".xls") > 0) // 2003版本
                    wb = new HSSFWorkbook(ms);

                ISheet sheet = wb.GetSheetAt(0);
                IEnumerator it = sheet.GetRowEnumerator();

                ICellStyle style = wb.CreateCellStyle();
                style.BorderBottom = BorderStyle.Thin;
                style.BorderLeft = BorderStyle.Thin;
                style.BorderRight = BorderStyle.Thin;
                style.BorderTop = BorderStyle.Thin;
                style.VerticalAlignment = VerticalAlignment.Center;
                #endregion

                #region  读取excel 验证 员工是否存在
                int count = 0;
                int countFinished = 0;


                if (it.MoveNext())
                {
                    while (it.MoveNext())
                    {
                        count++;
                        IRow row = it.Current as IRow;
                        T_Trn_Stu Dt = new T_Trn_Stu();
                        Dt.PersonName = GetCell(row, 0, 100).Replace(" ", "");
                        string CardTypeName = GetCell(row, 1, 100).Replace(" ", "");

                        switch (CardTypeName)
                        {
                            case "身份证":
                                Dt.CardType = 0; //"身份证";
                                break;
                            case "军官证":
                                Dt.CardType = 1; //"军官证";
                                break;
                            case "护照":
                                Dt.CardType = 2; //"护照";
                                break;
                            case "台胞证":
                                Dt.CardType = 3; //"台胞证";
                                break;
                            case "港澳身份证":
                                Dt.CardType = 4; //"港澳身份证";
                                break;
                        }
                        Dt.PersonId = GetCell(row, 2, 100).Replace(" ", "");

                        if (Dt.PersonName == "")
                        {
                            ICell h;
                            h = row.CreateCell(3, CellType.String);
                            h.CellStyle = style;
                            h.SetCellValue("没有员工姓名");

                        }
                        else if (CardTypeName == "")
                        {
                            ICell h;
                            h = row.CreateCell(3, CellType.String);
                            h.CellStyle = style;
                            h.SetCellValue("没有证件类型");
                        }
                        else if (Dt.PersonId == "")
                        {
                            ICell h;
                            h = row.CreateCell(3, CellType.String);
                            h.CellStyle = style;
                            h.SetCellValue("没有证件号");
                        }
                        else
                        {
                            //规则-没有删除的，1证件号不存在，则创建一条新的记录。2证件号一致，标签不一致，仅导入标签。3证件号一致，标签一致，失败（学员已存在）；
                            List<T_Trn_Stu> temDtFalse = this._tTEntityResponsity.Table.Where(p => p.IsDelete == 0 && p.PersonId == Dt.PersonId).ToList();
                            #region "原来单选 追加的逻辑"
                            //if (temDtFalse != null && temDtFalse.Count > 0)
                            //{   //证件号存在
                            //    int idd = temDtFalse[0].Id;
                            //    T_Trn_Stu temDt = this._tTEntityResponsity.GetById(idd);
                            //    string msg = "失败";

                            //    List<T_Trn_Stu> temDtL = temDtFalse.Where(p => p.IsDelete == 0 && p.PersonId == Dt.PersonId && p.LabelIds.Contains(LableId)).ToList();

                            //    if (temDtL != null && temDtL.Count > 0)
                            //    {
                            //        //3标签存在，失败（学员已存在）
                            //        if (temDt != null && temDt.Id > 0)
                            //        {
                            //            msg = "失败（学员已存在）";
                            //        }
                            //    }
                            //    else
                            //    {
                            //        //2标签不存在，仅导入标签
                            //        if (temDt != null && temDt.Id > 0)
                            //        {
                            //            string lastStr = temDt.LabelIds.Right(1);
                            //            if (lastStr == ",")
                            //            {
                            //                temDt.LabelIds += LableId;
                            //            }
                            //            else
                            //            {
                            //                temDt.LabelIds += "," + LableId;
                            //            }
                            //            countFinished++;
                            //            this._tTEntityResponsity.Update(temDt);
                            //            msg = "成功（仅导入标签）";
                            //        }
                            //    }
                            //    ICell h;
                            //    h = row.CreateCell(3, CellType.String);
                            //    h.CellStyle = style;
                            //    h.SetCellValue(msg);
                            //}
                            //else
                            //{
                            //    //1证件号不存在，则创建一条新的记录
                            //    T_Trn_Stu temDt = new T_Trn_Stu();
                            //    temDt.SetNullToDefalut();

                            //    temDt.PersonName = Dt.PersonName;
                            //    temDt.CardType = Dt.CardType;
                            //    temDt.PersonId = Dt.PersonId;
                            //    temDt.LabelIds = LableId;
                            //    temDt.CreateTime = DateTime.Now;

                            //    countFinished++;
                            //    this._tTEntityResponsity.Insert(temDt);
                            //    string msg = "成功";

                            //    ICell h;
                            //    h = row.CreateCell(3, CellType.String);
                            //    h.CellStyle = style;
                            //    h.SetCellValue(msg);
                            //}
                            #endregion 

                            if (temDtFalse != null && temDtFalse.Count > 0)
                            {   //证件号存在
                                int idd = temDtFalse[0].Id;
                                T_Trn_Stu temDt = this._tTEntityResponsity.GetById(idd);
                                string msg = "";
                                if (temDt != null && temDt.Id > 0)
                                {
                                    temDt.LabelIds = LableId;
                                    temDt.EditUserId = account.Id;
                                    temDt.EditTime = DateTime.Now;
                                    countFinished++;
                                    this._tTEntityResponsity.Update(temDt);
                                    msg = "已覆盖";
                                }

                                ICell h;
                                h = row.CreateCell(3, CellType.String);
                                h.CellStyle = style;
                                h.SetCellValue(msg);
                            }
                            else
                            {
                                //1证件号不存在，则创建一条新的记录
                                T_Trn_Stu temDt = new T_Trn_Stu();
                                temDt.SetNullToDefalut();

                                temDt.PersonName = Dt.PersonName;
                                temDt.CardType = Dt.CardType;
                                temDt.PersonId = Dt.PersonId;
                                temDt.LabelIds = LableId;
                                temDt.CreateTime = DateTime.Now;

                                countFinished++;
                                this._tTEntityResponsity.Insert(temDt);
                                string msg = "成功";

                                ICell h;
                                h = row.CreateCell(3, CellType.String);
                                h.CellStyle = style;
                                h.SetCellValue(msg);
                            }
                        }

                    }
                }

                using (FileStream out1 = new FileStream(path, FileMode.Create))
                {
                    wb.Write(out1);
                    out1.Close();
                }
                string Message = "导入记录数：" + count + ".成功：" + countFinished + ".失败：" + (count - countFinished) + ".";
                #endregion

                #region  创建


                string fileName = Guid.NewGuid().ToString().ToLower().Replace("_", "").Replace("-", "") + ".xls";
                if (FileNameOld.IndexOf(".xlsx") > 0) // 2007版本
                    fileName = Guid.NewGuid().ToString().ToLower().Replace("_", "").Replace("-", "") + ".xlsx";


                if (System.IO.Directory.Exists(filepath) == false)//如果不存在就创建文件夹
                {
                    System.IO.Directory.CreateDirectory(filepath);
                }

                string endPoint = _fileConfiguration.Endpoint;

                string secondFolderName = _fileConfiguration.KeyPrefix;

                T_Sys_ImportFiles sysImportFiles = new T_Sys_ImportFiles()
                {
                    Type = 201,
                    TypeName = "培训员工名单",
                    UserId = account.Id,
                    UserName = account.RealName,
                    FileNameOld = FileNameOld,
                    FileNameNew = fileName,
                    Path = secondFolderName,
                    State = -1, //初始值
                    Message = Message,
                    CreateTime = DateTime.Now,
                    ParaJson = "{\"LableId\":\"" + LableId + "\"}"
                };
                sysImportFiles.SetNullToDefalut();
                this.AddEntity(sysImportFiles);

                bool isUpload = false;
                string etag = string.Empty;
                #endregion

                #region 上传
                isUpload = UploadExcelFiles(path, secondFolderName, sysImportFiles.FileNameNew, ref etag);

                if (isUpload)
                {
                    T_Sys_ImportFiles n = this.GetById(Utils.ToInt(sysImportFiles.Id));
                    n.State = 1;                                //文件上传成功
                    _tEntityResponsity.Update(n);
                }
                else
                {
                    result = "导入失败，文件未能上传成功";
                }
                #endregion
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            //删除文件
            try
            {
                File.Delete(filepath);
            }
            catch (Exception ex)
            {
                _logger.Error(this.GetType(), "Service Log 培训员工导入EXCEL生成服务,删除Excel文件失败", ex);

            }
            return result;
        }

        private string GetCell(IRow row, int index, int maxLength, bool isDate = false)
        {
            ICell cell = row.GetCell(index);
            if (cell == null) return "";
            switch (cell.CellType)
            {
                case NPOI.SS.UserModel.CellType.Numeric:
                    if (isDate)
                    {
                        string s = cell.NumericCellValue.ToString();
                        if (s.IndexOf(".") < 0) s += ".0";
                        return s;
                    }
                    return cell.NumericCellValue.ToString();
                case NPOI.SS.UserModel.CellType.String:
                    return Utils.Left(cell.StringCellValue, maxLength);
                case NPOI.SS.UserModel.CellType.Boolean:
                    return cell.BooleanCellValue.ToString();
                case NPOI.SS.UserModel.CellType.Formula:
                    return cell.NumericCellValue.ToString();
                default:
                    return "";
            }
        }


        /// <summary>
        /// 将生成EXCEL文件上传至OSS
        /// </summary>
        /// <param name="fileLocalPath">本地文件路径</param>
        /// <param name="OSSPath">OSS服务器路径</param>
        /// <param name="fileName">保存到OSS的文件名称</param>
        /// <param name="etag"></param>
        /// <returns></returns>
        public bool UploadExcelFiles(string fileLocalPath, string OSSPath, string fileName, ref string etag)
        {
            bool res = false;
            string accessKeyId = _fileConfiguration.AccessKeyId;
            string accessKeySecret = _fileConfiguration.AccessKeySecret;
            string endPoint = _fileConfiguration.Endpoint;
            string bucketName = _fileConfiguration.DefaultBucketName;

            res = _ossFileStorage.UploadFile(accessKeyId, accessKeySecret, endPoint, bucketName, OSSPath + fileName, fileLocalPath, ref etag);
            return res;
        }
    }
}

using myselfFast.Fund.Core.Common;
using myselfFast.Component.Logging;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Domain.HuKouSettled;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Services.DTO.Request.Hukousettled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Services.DTO.Response.Hukousettled;
using NPOI.Util;
using System.Data;
using NewSystem.SDK.Interfaces;
using NewSystem.SDK.Entities.Request.FileService;
using System.IO;
using System.Net.Http;
using System.Web;
using System.Drawing;
using PdfiumViewer;
using NewSystem.SDK.Entities.Response.FileService;
using System.Data.SqlClient;
using WebApiDebugTool.Helper;
using myselfFast.Fund.Core.Configuration;
using System.Diagnostics;
using myselfFast.Fund.Services.Admin;
using myselfFast.Fund.Core.Domain.ExportImport;

namespace myselfFast.Fund.Services.HukousettledS
{
    public class HukousettledDataService : BaseService<T_HK_Settled_Info>, IHukousettledDataService
    {
        private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;
        private readonly IFileDownService _fileDownService;
        private readonly IFileUploadService _fileUploadService;
        private IRepository<T_Fes_User> _fesUserEntity;
        private IRepository<T_HK_Settled_FileItem> _fileItemEntity;
        private IRepository<T_HK_Dictionary> _fileDicEntity;
        private IRepository<T_Sys_File> _fileSysEntity;
        private IRepository<T_Sys_IdCardInfo> _IdCardEntity;
        private IRepository<T_Tb_dictionarylist> _dicEntity;
        private IRepository<T_Sys_ExportFiles> _t_Sys_ExportFiles;

        public HukousettledDataService(IRepository<T_HK_Settled_Info> tEntityResponsity,
            IRepository<T_Fes_User> tfesUserEntity,
            IRepository<T_HK_Settled_FileItem> tfileItemEntity,
            IRepository<T_HK_Dictionary> tfileDicEntity,
            IRepository<T_Sys_File> tfileSysEntity,
            IRepository<T_Sys_IdCardInfo> tIdCardEntity,
            IRepository<T_Tb_dictionarylist> tdicEntity,
            IFileDownService fileDownService,
            IFileUploadService fileUploadService,
            IRepository<T_Sys_ExportFiles> t_Sys_ExportFiles,
            IDataProvider _dataProvider, IDbContext _dbContext, ILoggerProviderFactory iLoggerProviderFactory)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this._t_Sys_ExportFiles = t_Sys_ExportFiles;
            this._fesUserEntity = tfesUserEntity;
            this._fileItemEntity = tfileItemEntity;
            this._fileDicEntity = tfileDicEntity;
            this._fileSysEntity = tfileSysEntity;
            this._IdCardEntity = tIdCardEntity;
            this._dicEntity = tdicEntity;
            this._fileDownService = fileDownService;
            this._fileUploadService = fileUploadService;
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
        }
        #region Make SqlParameters
        /// <summary>
        /// Make input param.
        /// </summary>
        /// <param name="ParamName">Name of param.</param>
        /// <param name="DbType">Param type.</param>
        /// <param name="Size">Param size.</param>
        /// <param name="Value">Param value.</param>
        /// <returns>New parameter.</returns>
        public static SqlParameter MakeInParam(string ParamName, SqlDbType DbType, int Size, object Value)
        {
            return MakeParam(ParamName, DbType, Size, ParameterDirection.Input, Value);
        }

        /// <summary>
        /// Make input param.
        /// </summary>
        /// <param name="ParamName">Name of param.</param>
        /// <param name="DbType">Param type.</param>
        /// <param name="Size">Param size.</param>
        /// <returns>New parameter.</returns>
        public static SqlParameter MakeOutParam(string ParamName, SqlDbType DbType, int Size)
        {
            return MakeParam(ParamName, DbType, Size, ParameterDirection.Output, null);
        }

        /// <summary>
        /// Make stored procedure param.
        /// </summary>
        /// <param name="ParamName">Name of param.</param>
        /// <param name="DbType">Param type.</param>
        /// <param name="Size">Param size.</param>
        /// <param name="Direction">Parm direction.</param>
        /// <param name="Value">Param value.</param>
        /// <returns>New parameter.</returns>
        public static SqlParameter MakeParam(string ParamName, SqlDbType DbType, Int32 Size, ParameterDirection Direction, object Value)
        {
            SqlParameter param;

            if (Size > 0)
                param = new SqlParameter(ParamName, DbType, Size);
            else
                param = new SqlParameter(ParamName, DbType);

            param.Direction = Direction;
            if (!(Direction == ParameterDirection.Output && Value == null))
                param.Value = Value;

            return param;
        }
        #endregion


        //获取集体户口列表
        public JqGridResult<SelectHukousettledResponseModel> GetHukousettledList(SelectHukousettledRequestModel model, T_Admin_Account account, int rows, int page)
        {
            //申请时间
            DateTime begintime = Utils.ToDateTime(model.ApplyTimeStart);
            DateTime endtime = Utils.ToDateTime(model.ApplyTimeEnd);
            if (!string.IsNullOrEmpty(model.ApplyTimeEnd))
            {
                endtime = endtime.AddDays(1);
            }
            //时间类型
            DateTime startTime = Utils.ToDateTime(model.startTime);
            DateTime selectEndTime = Utils.ToDateTime(model.endTime);
            if (!string.IsNullOrEmpty(model.endTime))
            {
                selectEndTime = selectEndTime.AddDays(1);
            }


            //加密
            if (!string.IsNullOrEmpty(model.uCname))
            {
                model.uCname = Encryption.Encrypt(model.uCname);
            }
            if (!string.IsNullOrEmpty(model.uCardId))
            {
                model.uCardId = Encryption.Encrypt(model.uCardId);
            }
            if (!string.IsNullOrEmpty(model.uMobile))
            {
                model.uMobile = Encryption.Encrypt(model.uMobile);
            }
            int[] State10000 = new int[] { 7, 8, 10, 12 };
            if (model.State > 10000)
            {
                model.State -= 10000;
            }
            #region linQ 查询
            //IEnumerable<SelectHukousettledResponseModel> vList = ((from order in _tEntityResponsity.Table
            //                                                       join user in _fesUserEntity.Table on order.FesId equals user.Id
            //                                                       where user.Isdeleted == false
            //                                                       join card in _IdCardEntity.Table on new { a = order.FesId, b = user.Hno } equals new { a = card.FesId, b = card.Hno }
            //                                                       where card.Status == 0 && card.ElecMatSource == "THK"
            //                                                       select new SelectHukousettledResponseModel
            //                                                        {
            //                                                            Id = order.Id,
            //                                                            FesId = order.FesId,
            //                                                            OrderId = order.OrderId,
            //                                                            RecordState = order.RecordState,
            //                                                            MaritalStatus = order.MaritalStatus,
            //                                                            CensusRegister = order.CensusRegister,
            //                                                            MigrationType = order.MigrationType,
            //                                                            UsedName = order.UsedName,
            //                                                            Height = order.Height,
            //                                                            Blood = order.Blood,
            //                                                            ContactPhone = order.ContactPhone,
            //                                                            EmerContactName = order.EmerContactName,
            //                                                            EmerContactPhone = order.EmerContactPhone,
            //                                                            District = order.District,
            //                                                            Address = order.Address,
            //                                                            DadName = order.DadName,
            //                                                            MumName = order.MumName,
            //                                                            CpName = order.CpName,
            //                                                            MigrationStart = order.MigrationStart,
            //                                                            MigrationEnd = order.MigrationEnd,
            //                                                            ChekcDate = order.ChekcDate,
            //                                                            ApplyDate = order.ApplyDate,
            //                                                            SubmitDate = order.SubmitDate,
            //                                                            CreateDate = order.CreateDate,
            //                                                            State = order.State,
            //                                                            IsCurrent = order.IsCurrent,
            //                                                            AdminTime = order.AdminTime,
            //                                                            AdminId = order.AdminId,
            //                                                            AdminName = order.AdminName,
            //                                                            IsAgain = order.IsAgain,
            //                                                            UserName = order.UserName,
            //                                                            UserId = order.UserId,
            //                                                            Opinion = order.Opinion,
            //                                                            Reason = order.Reason,
            //                                                            FileItem = order.FileItem,
            //                                                            OperateTime = order.OperateTime,
            //                                                            //员工信息
            //                                                            Uniqueno = user.Hno,
            //                                                            uCname = user.Cname,
            //                                                            uCardId = user.CardId,
            //                                                            uMobile = user.Mobile,
            //                                                            uEmail = user.Email,
            //                                                            busiCustName = user.busiCustName,
            //                                                            //身份证信息
            //                                                            cardInfoId = card.Id,
            //                                                            cardInfoFesId = card.FesId,
            //                                                            cardInfoHno = card.Hno,
            //                                                            CradName = card.CradName,
            //                                                            CardId = card.CardId,
            //                                                            CardGender = card.CardGender,
            //                                                            CardNation = card.CardNation,
            //                                                            CardBirth = card.CardBirth,
            //                                                            CardAddress = card.CardAddress,
            //                                                            Cardvalidate = card.Cardvalidate,
            //                                                            CardAuthority = card.CardAuthority,
            //                                                            cardInfoCreateDate = card.CreateDate,
            //                                                            cardInfoUpdateDate = card.UpdateDate,
            //                                                            cardInfoStatus = card.Status,
            //                                                            CardNationValue = card.CardNationValue
            //                                                        })
            //        .WhereIf(t => t.Id == model.Id, model.Id > 0)
            //        .WhereIf(t => t.State == model.State, model.State != 0 && model.State != 10000)
            //        .WhereIf(t => State10000.Contains(t.State), model.State == 10000)
            //        .WhereIf(t => t.CensusRegister == model.CensusRegister, !string.IsNullOrEmpty(model.CensusRegister) && model.CensusRegister != "isnull")
            //        .WhereIf(t => t.MaritalStatus == model.MaritalStatus, !string.IsNullOrEmpty(model.MaritalStatus) && model.MaritalStatus != "isnull")
            //        .WhereIf(t => t.RecordState == model.RecordState, !string.IsNullOrEmpty(model.RecordState) && model.RecordState != "isnull")
            //        .WhereIf(t => t.MigrationType == model.MigrationType, !string.IsNullOrEmpty(model.MigrationType) && model.MigrationType != "isnull")
            //        .WhereIf(t => t.OrderId == model.OrderId, !string.IsNullOrEmpty(model.OrderId))
            //        .WhereIf(t => t.Uniqueno == Utils.ToInt(model.Uniqueno), !string.IsNullOrEmpty(model.Uniqueno))
            //        .WhereIf(t => t.uCname == model.uCname, !string.IsNullOrEmpty(model.uCname))
            //        .WhereIf(t => t.uCardId == model.uCardId, !string.IsNullOrEmpty(model.uCardId))
            //        .WhereIf(t => t.uMobile == model.uMobile, !string.IsNullOrEmpty(model.uMobile))
            //        .WhereIf(t => t.ApplyDate >= begintime, !string.IsNullOrEmpty(model.ApplyTimeStart))
            //        .WhereIf(t => t.ApplyDate <= endtime, !string.IsNullOrEmpty(model.ApplyTimeEnd))
            //        .OrderByDescending(t => t.Id));
            #endregion
            string sqlText = string.Format("EXEC P_Settled_Info @id={0}", 0);
            List<SelectHukousettledResponseModel> vListALL = _dbContext.SqlQuery<SelectHukousettledResponseModel>(sqlText, true).ToList();
            List<SelectHukousettledResponseModel> vList = vListALL.WhereIf(t => t.Id == model.Id, model.Id > 0)
                    .WhereIf(t => t.State == model.State, model.State != 0 && model.State != 10000)
                    .WhereIf(t => State10000.Contains(t.State), model.State == 10000)
                    .WhereIf(t => t.CensusRegister == model.CensusRegister, !string.IsNullOrEmpty(model.CensusRegister) && model.CensusRegister != "isnull")
                    .WhereIf(t => t.MaritalStatus == model.MaritalStatus, !string.IsNullOrEmpty(model.MaritalStatus) && model.MaritalStatus != "isnull")
                    .WhereIf(t => t.RecordState == model.RecordState, !string.IsNullOrEmpty(model.RecordState) && model.RecordState != "isnull")
                    .WhereIf(t => t.MigrationType == model.MigrationType, !string.IsNullOrEmpty(model.MigrationType) && model.MigrationType != "isnull")
                    .WhereIf(t => t.OrderId == model.OrderId, !string.IsNullOrEmpty(model.OrderId))
                    .WhereIf(t => t.Uniqueno == Utils.ToInt(model.Uniqueno), !string.IsNullOrEmpty(model.Uniqueno))
                    .WhereIf(t => t.uCname == model.uCname, !string.IsNullOrEmpty(model.uCname))
                    .WhereIf(t => t.uCardId == model.uCardId, !string.IsNullOrEmpty(model.uCardId))
                    .WhereIf(t => t.uMobile == model.uMobile, !string.IsNullOrEmpty(model.uMobile))
                    .WhereIf(t => t.ApplyDate >= begintime, !string.IsNullOrEmpty(model.ApplyTimeStart))
                    .WhereIf(t => t.ApplyDate <= endtime, !string.IsNullOrEmpty(model.ApplyTimeEnd))
                    .WhereIf(t => t.ApplyDate >= startTime, !string.IsNullOrEmpty(model.startTime) && model.rangTime == "ApplyDate")
                    .WhereIf(t => t.ApplyDate <= selectEndTime, !string.IsNullOrEmpty(model.endTime) && model.rangTime == "ApplyDate")
                    .WhereIf(t => t.ChekcDate >= startTime, !string.IsNullOrEmpty(model.startTime) && model.rangTime == "ChekcDate")
                    .WhereIf(t => t.ChekcDate <= selectEndTime, !string.IsNullOrEmpty(model.endTime) && model.rangTime == "ChekcDate")
                    .ToList();
            //解密
            foreach (SelectHukousettledResponseModel v in vList)
            {

                v.uCname = Encryption.IsEncrypted(v.uCname) ? Encryption.Decrypt(v.uCname) : "";
                v.uCardId = Encryption.IsEncrypted(v.uCardId) ? Encryption.Decrypt(v.uCardId) : "";
                v.uMobile = Encryption.IsEncrypted(v.uMobile) ? Encryption.Decrypt(v.uMobile) : "";
                v.uEmail = Encryption.IsEncrypted(v.uEmail) ? Encryption.Decrypt(v.uEmail) : "";
                if (account.IsAuthorizationMenuDataKey("14141414-0001", "HKSettledGuangLi"))
                {
                    v.IsHKSettledGuangLi = "T";
                }
            }



            IPagedList<SelectHukousettledResponseModel> pagedList = new PagedList<SelectHukousettledResponseModel>(vList, page, rows);
            return JqGridResult<SelectHukousettledResponseModel>.Build(pagedList);
        }

        // 获取集体户口详情
        public SelectHukousettledResponseModel GetHukousettledDetail(int id, string savePath)
        {
            string sqlText = string.Format("EXEC P_Settled_Info @id={0}", id);
            List<SelectHukousettledResponseModel> vResList = _dbContext.SqlQuery<SelectHukousettledResponseModel>(sqlText, true).ToList();
            SelectHukousettledResponseModel vRes = vResList.First();
            //解密
            vRes.uCname =Encryption.IsEncrypted(vRes.uCname) ? Encryption.Decrypt(vRes.uCname):"";
            vRes.uCardId =Encryption.IsEncrypted(vRes.uCardId) ? Encryption.Decrypt(vRes.uCardId):"";
            vRes.uMobile = Encryption.IsEncrypted(vRes.uMobile) ?Encryption.Decrypt(vRes.uMobile):"";
            vRes.uEmail = Encryption.IsEncrypted(vRes.uEmail) ? Encryption.Decrypt(vRes.uEmail) : "";
            //装载材料
            SelectHukousettledResponseModel selectfile = fileSys(vRes.Id, vRes.Pid, vRes.MaritalStatus, vRes.CensusRegister, vRes.MigrationType, savePath, vRes.State, vRes.FesId);

            var imageList = "[";
            if (selectfile != null && selectfile.fileDt.Count > 0)
            {
                foreach (fileData flDt in selectfile.fileDt)
                {
                    vRes.fileDt.Add(flDt);
                    imageList += "{\"fileId\": \"" + flDt.fileId + "\",  \"img\": \"" + flDt.img + "\", \"type\": \"" + flDt.type + "\", \"typename\": \"" + flDt.typename + "\" },";
                }
                imageList = imageList.Substring(0, imageList.Length - 1);
            }
            imageList += "]";
            vRes.ImageList = imageList;
            //装载快递信息
            SelectHukousettledResponseModel selectKuaidi = KuaidifileSys(vRes.Id);
            var kuaidiImageList = "["; //快递信息
            if (selectKuaidi != null && selectKuaidi.KuaidifileDt.Count > 0)
            {
                foreach (fileData flDt in selectKuaidi.KuaidifileDt)
                {
                    vRes.KuaidifileDt.Add(flDt);
                    kuaidiImageList += "{\"fileId\": \"" + flDt.fileId + "\",  \"img\": \"" + flDt.img + "\", \"type\": \"" + flDt.type + "\", \"typename\": \"" + flDt.typename + "\" },";
                }
                kuaidiImageList = kuaidiImageList.Substring(0, kuaidiImageList.Length - 1);
            }
            kuaidiImageList += "]";
            vRes.KuaidiImageList = kuaidiImageList;
            return vRes;
        }
        //获取材料集合
        public SelectHukousettledResponseModel fileSys(int Id, int pid, string MaritalStatus, string CensusRegister, string MigrationType, string savePath, int State, int FesId)
        {
            SelectHukousettledResponseModel vRes = new SelectHukousettledResponseModel();
            List<string> idList = new List<string>();

            if (State == 2)
            {
                //第一次审核（显示全部的材料）
                List<T_HK_Settled_FileItem> fileItemList = _fileItemEntity.Table.Where(t => t.MaritalStatus == MaritalStatus && t.CensusRegister == CensusRegister && t.MigrationType == MigrationType).ToList();
                T_HK_Settled_FileItem fileItem = fileItemList.First();
                string items = "263" + "," + fileItem.Aitem + "," + fileItem.Bitem + "," + fileItem.Citem;   //审核材料集合
                idList = items.Split(",").ToList();
            }
            else if (State == 5)
            {
                //第二次审核（只显示第一次审核，审核失败的材料）
                T_HK_Settled_Info orderInfo = _tEntityResponsity.Table.First(t => t.FesId == FesId && t.State == 4 && t.Id == pid);  //寻找第一次审核的订单
                idList = orderInfo.FileItem.Split(",").ToList();
            }
            else if (State == 11)
            {
                string items = "261";          //材料只有迁移证
                idList = items.Split(",").ToList();
            }
            else
            {
                //不考虑材料
            }
            var FileItem = GetFileItem();
            //读材料
            foreach (string i in idList)
            {
                int typei = Utils.ToInt(i);
                if (typei <= 0) continue;
                //IsSendFile为1，已经上传到新系统
                List<T_Sys_File> files = _fileSysEntity.Table.Where(t => t.FormalityId == Id && t.IsValue == 1 && t.ElecMatSource == 19 && t.Type == typei && t.IsSendFile == 1 && t.TableName == "T_HK_Settled_Info").OrderBy(t => t.FileNo).ToList();
                #region 接口读取图片
                if (files.Count <= 0)
                {
                    //材料表里面没有 当前材料
                    fileData flDt = new fileData
                    {
                        fileId = "0",
                        img = "没有上传当前材料",
                        type = i,
                        typename = ""
                    };
                    foreach (T_HK_Dictionary dic in FileItem)
                    {
                        if (dic.KeyValue == flDt.type)
                        {
                            flDt.typename = dic.keyDesc;
                            break;
                        }

                    }
                    vRes.fileDt.Add(flDt);
                }
                foreach (T_Sys_File f in files)
                {
                    GetErRecordDataByIdRequestModel model = new GetErRecordDataByIdRequestModel {fileId = f.FileId};
                    //有材料
                    Stream stream = _fileDownService.GetErRecordDataById(model);
                    if (stream != null && stream.Length > 0)
                    {
                        fileData flDt = new fileData
                        {
                            fileId = Utils.ToString(f.Id),
                            type = Utils.ToString(f.Type)
                        };

                        if (f.FileFormat == ".pdf")
                        {
                            #region 将登记表转化为图片
                            string path = savePath + "/" + "登记表转图片" + Id + ".pdf";
                            if (File.Exists(path))//如果存在则删除
                            {
                                try
                                {
                                    File.Delete(path);
                                }
                                catch
                                {
                                    // ignored
                                }
                            }
                            Stream fileDes = new FileStream(path, FileMode.Create);
                            try
                            {
                                StreamHelper.StreamCopy(stream, fileDes);
                            }
                            catch (Exception ex)
                            {
                                fileDes.Dispose();  //失败的话要释放
                            }
                            fileDes.Dispose();
                            var pdf = OpenDocument(path);
                            if (pdf != null)
                            {
                                var pdfpage = 1; // pdf.PageCount; 登记表只有一页
                                var pagesizes = pdf.PageSizes;
                                PdfToPicture p2P = new PdfToPicture();
                                string pathImage = savePath + "/" + "登记表转图片" + Id + ".jpg";
                                for (int i1 = 1; i1 <= pdfpage; i1++)
                                {
                                    Size size = new Size
                                    {
                                        Height = (int)pagesizes[(i1 - 1)].Height,
                                        Width = (int)pagesizes[(i1 - 1)].Width
                                    };
                                    p2P.RenderPage(path, i1, size, @pathImage);
                                }
                                pdf.Dispose();
                            }
                            flDt.img = "/Images/hukousettledpdf/登记表转图片" + Id + ".jpg";
                            #endregion
                        }
                        else
                        {
                            byte[] arr = StreamToBytes(stream);
                            if (arr.Length > 0)
                            {
                                flDt.img = "data:image/jpeg;base64," + Convert.ToBase64String(arr);
                            }
                            else
                            {
                                flDt.img = "新系统读取文件异常";
                                flDt.fileId = "0";
                            }
                        }
                        flDt.type = f.FileType;
                        flDt.typename = "";
                        foreach (T_HK_Dictionary dic in FileItem)
                        {
                            if (dic.KeyValue == flDt.type)
                            {
                                flDt.typename = dic.keyDesc;
                                break;
                            }
                        }
                        vRes.fileDt.Add(flDt);
                    }
                    else
                    {
                        throw new Exception("新系统文件服务器异常，读取图片失败，请稍后重试!");
                    }
                }
                #endregion
            }
            return vRes;
        }
        //获取快递图片
        public SelectHukousettledResponseModel KuaidifileSys(int Id)
        {
            SelectHukousettledResponseModel vRes = new SelectHukousettledResponseModel();



            List<T_HK_Dictionary> FileItem = new List<T_HK_Dictionary>();
            FileItem = GetFileItem();
            //读材料
            //IsSendFile为1，已经上传到新系统//找到快递图片
            List<T_Sys_File> files = _fileSysEntity.Table.Where(t => t.FormalityId == Id && t.IsValue == 1 && t.ElecMatSource == 19 && t.Type == 267 && t.IsSendFile == 1 && t.TableName == "T_HK_Settled_Info").OrderBy(t => t.FileNo).ToList();
            #region 接口读取图片

            if (files == null || files.Count <= 0)
            {

                //材料表里面没有 当前材料
                fileData KuaidifileDt = new fileData();
                KuaidifileDt.fileId = "0";
                KuaidifileDt.img = "没有上传当前材料";
                KuaidifileDt.type = "267";
                KuaidifileDt.typename = "";
                foreach (T_HK_Dictionary dic in FileItem)
                {
                    if (dic.KeyValue == KuaidifileDt.type)
                    {
                        KuaidifileDt.typename = dic.keyDesc;
                        break;
                    }

                }
                vRes.KuaidifileDt.Add(KuaidifileDt);


            }



            foreach (T_Sys_File f in files)
            {
                GetErRecordDataByIdRequestModel model = new GetErRecordDataByIdRequestModel();
                //有材料
                model.fileId = f.FileId;

                Stream stream = _fileDownService.GetErRecordDataById(model);


                if (stream != null && stream.Length > 0)
                {
                    fileData KuaidifileDt = new fileData();
                    KuaidifileDt.fileId = Utils.ToString(f.Id);
                    KuaidifileDt.type = Utils.ToString(f.Type);

                    byte[] arr = StreamToBytes(stream);
                    if (arr.Length > 0)
                    {
                        KuaidifileDt.img = "data:image/jpeg;base64," + Convert.ToBase64String(arr);
                    }
                    else
                    {
                        KuaidifileDt.img = "新系统读取文件异常";
                        KuaidifileDt.fileId = "0";
                    }

                    KuaidifileDt.type = f.FileType;
                    KuaidifileDt.typename = "";
                    foreach (T_HK_Dictionary dic in FileItem)
                    {
                        if (dic.KeyValue == KuaidifileDt.type)
                        {
                            KuaidifileDt.typename = dic.keyDesc;
                            break;
                        }
                    }
                    vRes.KuaidifileDt.Add(KuaidifileDt);
                }
                else
                {
                    //throw new Exception("新系统文件服务器异常，读取图片失败，请稍后重试!");
                }

            }
            #endregion
            return vRes;
        }

        private PdfDocument OpenDocument(string fileName)
        {
            try
            {
                return PdfDocument.Load(fileName);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //修改登记表信息
        public string editRegisterPara(T_HK_Settled_Info model, T_Admin_Account account)
        {
            string result = string.Empty;
            int idd = Utils.ToInt(model.Id);
            DataTable dt = Utils.ConvertTo(_tEntityResponsity.Table.Where(t => t.Id == idd).ToList());
            var res = Utils.TableToJson(dt);           //日志记录修改前内容
            //修改
            //T_HK_Settled_Info orderU = Utils.ConvertTo<T_HK_Settled_Info>(dt).ToList().First();
            T_HK_Settled_Info orderU = _tEntityResponsity.GetById(idd);
            orderU.UsedName = model.UsedName;
            orderU.Height = model.Height;
            orderU.Blood = model.Blood;
            orderU.ContactPhone = model.ContactPhone;
            orderU.EmerContactName = model.EmerContactName;
            orderU.EmerContactPhone = model.EmerContactPhone;
            orderU.District = model.District;
            orderU.Address = model.Address;
            orderU.DadName = model.DadName;
            orderU.MumName = model.MumName;
            if (model.CpName == null) model.CpName = "";
            orderU.CpName = model.CpName;
            //测试时，后台操作人保存后台操作动作
            string AdminStr = account.UserName + "修改登记表信息";
            orderU.AdminName = orderU.AdminName + AdminStr;
            if (orderU.AdminName.Length >= 50)
            {   //处理溢出
                orderU.AdminName = orderU.AdminName.Substring(orderU.AdminName.Length - 50);
            }

            orderU.AdminId = account.Id;
            orderU.AdminTime = DateTime.Now;
            this._tEntityResponsity.Update(orderU);
            string adss = (orderU.District + orderU.Address);
            string ApplyDate = (orderU.ApplyDate).ToString("yyyy-MM-dd hh:mm:ss");
            #region 生成新的PDF
            List<RegistrationSheetModel> resList = (from order in _tEntityResponsity.Table
                                                    where order.Id == orderU.Id
                                                    join user in _fesUserEntity.Table on order.FesId equals user.Id
                                                    where user.Isdeleted == false
                                                    join card in _IdCardEntity.Table on new { a = order.FesId, b = user.Hno } equals new { a = card.FesId, b = card.Hno }
                                                    where card.Status == 0 && card.ElecMatSource == "THK"
                                                    select new RegistrationSheetModel
                                                    {
                                                        Hno = card.Hno,
                                                        Name = card.CradName,
                                                        Sex = card.CardGender,
                                                        Nation = card.CardNationValue,
                                                        UsedName = order.UsedName,
                                                        BirthDay = card.CardBirth,
                                                        Height = order.Height,
                                                        Blood = order.Blood,
                                                        MaritalStatus = order.MaritalStatus,
                                                        IdCardNo = card.CardId,
                                                        CardStart = card.Cardvalidate,
                                                        ContactPhone = order.ContactPhone,
                                                        EmerContactName = order.EmerContactName,
                                                        EmerContactPhone = order.EmerContactPhone,
                                                        DadName = order.DadName,
                                                        MumName = order.MumName,
                                                        CpName = order.CpName,
                                                        Address = adss,
                                                        ApplyDate = ApplyDate,
                                                        Email = order.Email
                                                    }).ToList();
            DataTable dtRes = Utils.ToDataTable<RegistrationSheetModel>(resList);
            PdfHelper pdfHelper = new PdfHelper();
            string templateName = "加入外企集体户申请登记表.doc";
            string templatePath = System.Web.HttpContext.Current.Server.MapPath("~/Temp/");//模板绝对路径
            string sFile = string.Empty;//文件保存地址
            bool pdfRes = pdfHelper.WordToPDF(dtRes, templatePath, templateName, templatePath, out sFile);
            string pfdName = sFile.Substring(sFile.LastIndexOf('\\') + 1);
            int upSysFileId = 0;
            //维护数据库记录
            if (pdfRes)
            {
                List<T_Sys_File> files = _fileSysEntity.Table.Where(t => t.FesId == orderU.FesId && t.IsValue == 1 && t.ElecMatSource == 19 && t.Type == 263 && t.IsSendFile == 1).OrderByDescending(t => t.Id).ToList();
                T_Sys_File sysFile = files.First();

                if (sysFile != null)//更新（不覆盖原来的记录）
                {
                    sysFile.IsValue = 0; //置为失效
                    _fileSysEntity.Update(sysFile);
                }
                //创建 新记录
                T_Sys_File newFile = new T_Sys_File()
                {
                    FesId = orderU.FesId,
                    TableName = "T_HK_Settled_Info",
                    FilePath = "/Temp/" + pfdName,
                    FileType = "263",
                    IsValue = 1,
                    FileName = pfdName,
                    FileFormat = ".pdf",
                    FormalityId = orderU.Id,
                    ElecMatSource = 19,
                    Type = 263,
                    FileNo = 1,
                    PhoneSysterm = "PC",
                    UpLoadDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    CreateDate = DateTime.Now,
                };
                newFile.SetNullToDefalut();
                _fileSysEntity.Insert(newFile);

                upSysFileId = newFile.Id;
            }
            else
            {
                throw new Exception("生成PDF失败");
            }

            #endregion

            #region 将新生成的PDF上传到新系统文件服务器
            #region LinQ查询
            //SelectHukousettledResponseModel vRes = (from order in _tEntityResponsity.Table
            //                                        where order.Id == orderU.Id
            //                                        join user in _fesUserEntity.Table on order.FesId equals user.Id
            //                                        where user.Isdeleted == false
            //                                        join card in _IdCardEntity.Table on new { a = order.FesId, b = user.Hno } equals new { a = card.FesId, b = card.Hno }
            //                                        where card.Status == 0 && card.ElecMatSource == "THK"
            //                                        select new SelectHukousettledResponseModel
            //                                        {
            //                                            Id = order.Id,
            //                                            FesId = order.FesId,
            //                                            //员工信息
            //                                            Uniqueno = user.Hno
            //                                        }).ToList().First();
            #endregion
            string sqlText = string.Format("EXEC P_Settled_Info @id={0}", orderU.Id);
            List<SelectHukousettledResponseModel> vResList = _dbContext.SqlQuery<SelectHukousettledResponseModel>(sqlText, true).ToList();

            SelectHukousettledResponseModel vRes = vResList.First();
            UploadByUniqNoResponseModel reModel = _fileUploadService.UploadByUniqNo(
                    new UploadByUniqNoRequestModel()
                    {
                        uniqNo = vRes.Uniqueno,
                        verify = 2,
                        type = "263",
                        elecMatSource = "19",
                        fileNo = "1",
                        filetype = ".pdf",
                    }, pfdName, sFile);
            if (reModel.code == "0" && reModel.successResult != null)//上传成功
            {
                T_Sys_File f = _fileSysEntity.GetById(upSysFileId);
                f.FileId = reModel.successResult.fileId;
                f.IsSendFile = 1;
                _fileSysEntity.Update(f);//更新T_Sys_file表

            }
            else//调新系统接口失败了，除189和190外都跳过，不提示上传失败由计划任务处理
            {
                _logger.Info(this.GetType(), "集体户口落户后台修改登记表信息" + Environment.NewLine + " 上传修改后的登记表失败");
                result = "上传修改后的登记表失败";
            }
            #endregion
            _logger.Info(this.GetType(), "集体户口落户后台修改登记表信息" + Environment.NewLine + " 修改前内容:" + res + " result:" + result);
            return result;
        }

        //保存 审核结果
        public string SetSaveReason(T_HK_Settled_Info model, T_Admin_Account account, string savePath)
        {
            string result = string.Empty;
            int idd = Utils.ToInt(model.Id);
            T_HK_Settled_Info orderU = _tEntityResponsity.GetById(idd);
            orderU.UserName = account.UserName;
            orderU.UserId = account.Id;
            orderU.OperateTime = DateTime.Now;
            orderU.MigrationStart = model.MigrationStart;
            orderU.MigrationEnd = model.MigrationEnd;

            orderU.Opinion = model.Opinion;
            if (model.Reason == null)
            {
                model.Reason = "";
            }
            orderU.Reason = model.Reason;
            if (model.FileItem == null)
            {
                model.FileItem = "";
            }
            orderU.FileItem = model.FileItem;
            if (orderU.Opinion == "通过")
            {
                orderU.State = 7;
            }
            else
            {
                if (orderU.IsAgain == 1)
                {
                    orderU.State = 6; //二次审核
                }
                else
                {
                    orderU.State = 4;   //一次审核
                }
            }

            this._tEntityResponsity.Update(orderU);

            #region 微信推送审核结果
            try
            {

                Stopwatch sw = new Stopwatch();

                string paramter = string.Empty;
                string inFesid = Utils.ToString(orderU.FesId);
                string inUrl = FSGlobalConfiguration.Configuration.ExaminConfiguration.WeChatExamineFrontUrl + "/#/HRCollectiveSettled/HKSettledList";//System.Web.HttpUtility.UrlEncode(, Encoding.UTF8);
                string inkeynote2 = "审核" + orderU.Opinion;
                string inremark = "";
                if (orderU.Opinion == "通过")//&& orderU.MigrationType == "市内迁入"
                {
                    inremark = "您的集体户口材料已审核通过，由于落户材料具有时效性，为避免耽误您的材料上报，请于7天内申请快递方式邮寄材料或及时预约现场提交户口审批材料的时间";
                    //inremark = "您好，您的落户材料网上审核已经通过，由于落户材料具有时效性，为避免耽误您的材料上报，请于7天内申请快递方式邮寄材料,或根据系统提示预约时间，按预约时间至雅宝路服务大厅办理户口材料现场审核及提交。";
                }
                //else if (orderU.Opinion == "通过" && orderU.MigrationType != "市内迁入")
                //{
                //    inremark = "您好，您的落户材料网上审核已经通过，请根据系统提示预约时间，并按预约时间至雅宝路服务大厅办理户口材料现场审核及提交。";
                //}
                else
                {
                    inremark = "您好，您的落户材料网上审核不通过。";
                }
                string TempId = FSGlobalConfiguration.Configuration.ExaminConfiguration.WeChatTempId;//44sSg39FhQ-GjaYyUEuEY18uVwN2-QVP9qTCVMEk63o
                string txtRequestBody = "{\"TempId\":\"" + TempId + "\"," +
                                "\"Fesid\":\"" + inFesid + "\"," +
                                "\"Url\":\"" + inUrl + "\"," +
                                "\"Data\":{\"first\":{\"value\":\"人事服务办理结果通知\",\"color\":\"#181818\"},\"keyword1\":{\"value\":\"集体户口落户在线审核及预约\",\"color\":\"#181818\"}," +
                                "\"keyword2\":{\"value\":\"" + inkeynote2 + "\",\"color\":\"#181818\"},\"remark\":{\"value\":\"" + inremark + "\",\"color\":\"#b1062a\"}}}";


                paramter = HttpParmpterHelper.CreatePostParm(txtRequestBody);

                string txtUrl = FSGlobalConfiguration.Configuration.ExaminConfiguration.WeChatDefaultUrls;//System.Web.HttpUtility.UrlEncode(, Encoding.UTF8);
                string txtController = "Message";
                string txtAction = "SendTempMessage";
                string Url = string.Format("{0}{1}/{2}", txtUrl, txtController, txtAction);

                sw.Start();
                string txtRequestHeader = "User-Agent: AppWebApiTools bHost: localhost:1599 Content-Type: application/json";
                var re = HttpHelper.httpPost(Url, paramter, GetHeaders(txtRequestHeader));
                sw.Stop();
                txtResponseBody Response = JsonHelper.DeserializeJsonToObject<txtResponseBody>(re);
                if (Response.Success.ToLower() != "true" && Response.Code != "0")
                {
                    result = "审核成功，但是微信推送失败！";
                }
            }
            catch (Exception ex)
            {
                result = "审核成功，但是微信推送异常！";
            }
            finally
            {

            }
            #endregion

            #region 删除
            string path = savePath + "/" + "登记表转图片" + orderU.Id + ".pdf";
            if (File.Exists(path))//如果存在则删除
            {
                File.Delete(path);
            }
            string path1 = savePath + "/" + "登记表转图片" + orderU.Id + ".jpg";
            if (File.Exists(path1))//如果存在则删除
            {
                File.Delete(path1);
            }
            #endregion
            _logger.Info(this.GetType(), "集体户口落户后台审核" + Environment.NewLine + " ID:" + orderU.Id + " result:" + result);
            return result;
        }
        //确认办理结束
        public string setStateOK(int id, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                T_HK_Settled_Info f = this._tEntityResponsity.GetById(id);
                //if (f.State != 8 && f.MigrationType != "市内迁入")
                //{
                //    result = "没有预约！";
                //    return result;
                //}
                //else if(f.State != 12 && f.MigrationType == "市内迁入")
                //{
                //    result = "没有快递！";
                //    return result;
                //}
                if (f.State == 8 || f.State == 12)
                {
                f.State = 10;
                f.AdminTime = DateTime.Now;
                //测试时，后台操作人保存后台操作动作
                string AdminStr = account.UserName + "操作办理结束";
                if (AdminStr.Length + f.AdminName.Length >= 50)
                {   //处理溢出
                    f.AdminName = f.AdminName.Substring(f.AdminName.Length - AdminStr.Length - 1, 49);
                }
                f.AdminName = f.AdminName + AdminStr;
                f.AdminId = account.Id;
                this._tEntityResponsity.Update(f);
                }
                else
                {
                    result = "没有预约或者没有快递！";
                    return result;
                }

            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        //查询数据导出
        public string searchDataOut(string id, T_Admin_Account account)
        {
            string result = string.Empty;
            StringBuilder sql = new StringBuilder();
            try
            {
                #region 根据条件拼接sql
                string sqlText = string.Format("EXEC dbo.P_HK_seachDataOut @orderid ={0}", id);
                sql.Append(@sqlText);
                #endregion
                T_Sys_ExportFiles newmodel = new T_Sys_ExportFiles();
                newmodel.SetNullToDefalut();
                newmodel.ParmsJson = sql.ToString();
                newmodel.TypeName = "集体户口落户导出图片";
                newmodel.Type = 211;//还没定
                newmodel.UserId = account.Id;
                newmodel.UserName = account.UserName + "";
                newmodel.CreateTime = DateTime.Now;
                newmodel.State = -1;
                _t_Sys_ExportFiles.Insert(newmodel);

            }
            catch (Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        //获取审核失败原因描述列表--字典
        public List<string> GetFatalReason()
        {
            List<string> result = new List<string>();
            List<T_HK_Dictionary> temDt = this._fileDicEntity.Table.Where(p => p.DictValue == "FatalReason" && p.Flag == 1).OrderBy(t => t.OrderNum).ToList();
            foreach (T_HK_Dictionary tDt in temDt)
            {
                result.Add(tDt.keyDesc);
            }
            return result;
        }
        //获取材料名称--字典
        public List<T_HK_Dictionary> GetFileItem()
        {
            List<T_HK_Dictionary> result = this._fileDicEntity.Table.Where(p => p.DictValue == "Settled" && p.Flag == 1).OrderBy(t => t.OrderNum).ToList();
            return result;
        }
        //获取根据省城市列表--字典
        public List<string> getXianList()
        {
            //select * from T_Tb_Dictionarylist where dtype=36
            List<string> result = new List<string>();
            List<T_Tb_dictionarylist> temDt = this._dicEntity.Table.Where(p => p.dtype == 36).OrderBy(t => t.Id).ToList();
            foreach (T_Tb_dictionarylist tDt in temDt)
            {
                result.Add(tDt.dname);
            }
            return result;
        }

        public string getReason(int id)
        {
            string result = string.Empty;
            T_HK_Settled_Info temDt = this._tEntityResponsity.GetById(id);
            result = temDt.Reason;
            return result;
        }

        //获取登记表
        public string getSelfTable(int id, string savePath)
        {
            string result = string.Empty;
            //应该先删除本地的登记表
            string fl= savePath + "/" + "登记表" + ".pdf";
            if (File.Exists(fl))
            {
                File.Delete(fl);
            }
            //重新加载登记表
            List<T_Sys_File> files = _fileSysEntity.Table.Where(t => t.FormalityId == id && t.IsValue == 1 && t.Type == 263 && t.IsSendFile == 1).ToList();
            if (files != null && files.Count > 0)
            {
                T_Sys_File file = files.First();
                GetErRecordDataByIdRequestModel model = new GetErRecordDataByIdRequestModel();

                model.fileId = file.FileId;

                Stream stream = _fileDownService.GetErRecordDataById(model);

                if (stream != null)
                {
                    string path = savePath + "/" + "登记表" + ".pdf";
                    Stream fileDes = new FileStream(path, FileMode.Create);
                    StreamHelper.StreamCopy(stream, fileDes);
                }
                else
                {
                    throw new Exception("新系统文件服务器异常，读取图片失败，请稍后重试!");
                }
            }
            else
            {
                result = "没有上传登记表";
            }
            return result;
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
        private Dictionary<string, string> GetHeaders(string strHeader)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(strHeader.Trim()))
            {
                string[] array = strHeader.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                foreach (var item in array)
                {
                    string[] head = item.Split(':');
                    headers.Add(head[0], head[1]);
                }
            }

            return headers;
        }
    }



}

public class RegistrationSheetModel
{
    public int Hno { get; set; }
    public string Name { get; set; }
    public string Sex { get; set; }
    public string Nation { get; set; }
    /// <summary>
    /// 曾用名
    /// </summary>
    public string UsedName { get; set; }
    /// <summary>
    /// 出生日期
    /// </summary>
    private string birthDay;
    public string BirthDay
    {
        get
        {
            return Utils.ToDateTime(birthDay).ToString("yyyy年MM月dd日");
        }
        set
        {
            birthDay = value;
        }
    }
    /// <summary>
    /// 身高（CM）
    /// </summary>
    public int Height { get; set; }
    /// <summary>
    /// 血型（A型/B型/ AB型/ O型/其他）
    /// </summary>
    public string Blood { get; set; }
    /// <summary>
    /// 婚姻状态（已婚/未婚/离婚/丧偶）
    /// </summary>
    public string MaritalStatus { get; set; }
    public string IdCardNo { get; set; }
    private string cardStart;
    public string CardStart
    {
        get
        {
            return Utils.ToDateTime(cardStart.Split('至')[0]).ToString("yyyy年MM月dd日");
        }
        set
        {
            cardStart = value;
        }
    }
    /// <summary>
    /// 联系人手机
    /// </summary>
    public string ContactPhone { get; set; }

    /// <summary>
    /// 紧急联系人姓名
    /// </summary>
    public string EmerContactName { get; set; }
    /// <summary>
    /// 紧急联系人手机
    /// </summary>
    public string EmerContactPhone { get; set; }

    /// <summary>
    /// 父亲姓名
    /// </summary>
    public string DadName { get; set; }
    /// <summary>
    /// 母亲姓名
    /// </summary>
    public string MumName { get; set; }
    /// <summary>
    /// 配偶姓名
    /// </summary>
    public string CpName { get; set; }
    /// <summary>
    /// 在京地址 详细
    /// </summary>
    public string Address { get; set; }
    /// <summary>
    /// 提交申请日期
    /// </summary>
    private string applyDate;
    public string ApplyDate
    {
        get
        {
            return Utils.ToDateTime(applyDate).ToString("yyyy-MM-dd");
        }
        set
        {
            applyDate = value;
        }
    }
    /// <summary>
    /// 联系人邮箱
    /// </summary>
    public string Email { get; set; }
}

public class txtResponseBody
{
    public string Success { get; set; }
    public string Code { get; set; }
    public string Message { get; set; }
}

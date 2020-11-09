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
 
//导入
namespace myselfFast.Fund.Services.HukouS
{
    public class ImportFileImpService : BaseService<T_Sys_ImportFiles>, IImportFileImpService
    {
        private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;
 
        private readonly OSSFileStorage _ossFileStorage = new OSSFileStorage();
        private OSSFileConfiguration _fileConfiguration = GlobalConfiguration.Configuration.OSSFileConfigurations.FileConfigurations.First(t => t.Name == "HK");
         
        private IRepository<T_HK_Order> _tTEntityResponsity;

        public ImportFileImpService(IRepository<T_Sys_ImportFiles> tEntityResponsity,
            IRepository<T_HK_Order> tTEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext, ILoggerProviderFactory iLoggerProviderFactory)
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
        public string InsertAndUploadSystemImportFile(string FileNameOld  ,string filepath, T_Admin_Account account)
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

                #region  读取excel 验证订单号是否存在
                int count = 0;
                int countFinished = 0;
                #region 旧模板导入
                //if (it.MoveNext())
                //{
                    //if (it.MoveNext())
                    //{
                    //    while (it.MoveNext())
                    //    {
                    //        count++;
                    //        IRow row = it.Current as IRow;
                    //        T_HK_Order Dt = new T_HK_Order();
                    //        Dt.OrderNo = GetCell(row, 1, 100).Replace(" ", "");
                    //        Dt.Kno = GetCell(row, 2, 100).Replace(" ", "");
                    //        if (Dt.OrderNo == "")
                    //        {
                    //            ICell h;
                    //            h = row.CreateCell(0, CellType.String);
                    //            h.CellStyle = style;
                    //            h.SetCellValue("没有订单号");

                    //        }
                    //        else if (Dt.Kno == "")
                    //        {
                    //            ICell h;
                    //            h = row.CreateCell(0, CellType.String);
                    //            h.CellStyle = style;
                    //            h.SetCellValue("没有运单号");
                    //        }
                    //        else
                    //        {
                    //            List<T_HK_Order> temDtL = this._tTEntityResponsity.Table.Where(p => p.State == 4 && p.OrderNo == Dt.OrderNo).ToList();
                    //            if (temDtL != null && temDtL.Count > 0)
                    //            {
                    //                if (temDtL[0].Id > 0)
                    //                {
                    //                    string msg = "失败";
                    //                    T_HK_Order temDt = this._tTEntityResponsity.GetById(temDtL[0].Id);
                    //                    if (temDt != null && temDt.Id > 0)
                    //                    {
                    //                        temDt.Kno = Dt.Kno;         //更新运单号
                    //                        temDt.KName = "顺丰快递";
                    //                        temDt.State = 5;            //已发货
                    //                        temDt.Statename = "已发货";

                    //                        temDt.UpdateTime = DateTime.Now;
                    //                        temDt.Updater = account.UserName;

                    //                        if (temDt.PiaoState == 0)
                    //                        {
                    //                            countFinished++;
                    //                            this._tTEntityResponsity.Update(temDt);
                    //                            msg = "成功";
                    //                        }
                    //                        else if (temDt.PiaoState == 1 && temDt.PrintState == true)
                    //                        {
                    //                            countFinished++;
                    //                            this._tTEntityResponsity.Update(temDt);
                    //                            msg = "成功";
                    //                        }
                    //                        else if (temDt.PiaoState == 1 && temDt.PrintState == false)
                    //                        {
                    //                            msg = "发票没打印";
                    //                        }

                    //                    }
                    //                    ICell h;
                    //                    h = row.CreateCell(0, CellType.String);
                    //                    h.CellStyle = style;
                    //                    h.SetCellValue(msg);
                    //                }

                    //            }
                    //            else
                    //            {
                    //                ICell h;
                    //                h = row.CreateCell(0, CellType.String);
                    //                h.CellStyle = style;
                    //                h.SetCellValue("当前订单不存在或者不是发货中");
                    //            }
                    //        }

                    //    }
                    //}
                //}
                #endregion 

                if (it.MoveNext())
                {
                    while (it.MoveNext())
                    {
                        count++;
                        IRow row = it.Current as IRow;
                        T_HK_Order Dt = new T_HK_Order();
                        Dt.OrderNo = GetCell(row, 0, 100).Replace(" ", "");
                        Dt.Kno = GetCell(row, 2, 100).Replace(" ", "");
                        if (Dt.OrderNo == "")
                        {
                            ICell h;
                            h = row.CreateCell(76, CellType.String);
                            h.CellStyle = style;
                            h.SetCellValue("没有订单号");

                        }
                        else if (Dt.Kno == "")
                        {
                            ICell h;
                            h = row.CreateCell(76, CellType.String);
                            h.CellStyle = style;
                            h.SetCellValue("没有运单号");
                        }
                        else
                        {
                            List<T_HK_Order> temDtL = this._tTEntityResponsity.Table.Where(p => p.State == 4 && p.OrderNo == Dt.OrderNo).ToList();
                            if (temDtL != null && temDtL.Count > 0)
                            {
                                if (temDtL[0].Id > 0)
                                {
                                    string msg = "失败";
                                    T_HK_Order temDt = this._tTEntityResponsity.GetById(temDtL[0].Id);
                                    if (temDt != null && temDt.Id > 0)
                                    {
                                        temDt.Kno = Dt.Kno;         //更新运单号
                                        temDt.KName = "顺丰快递";
                                        temDt.State = 5;            //已发货
                                        temDt.Statename = "已发货";

                                        temDt.UpdateTime = DateTime.Now;
                                        temDt.Updater = account.UserName;

                                        if (temDt.PiaoState == 0)
                                        {
                                            countFinished++;
                                            this._tTEntityResponsity.Update(temDt);
                                            msg = "成功";
                                        }
                                        else if (temDt.PiaoState == 1 && temDt.PrintState == true)
                                        {
                                            countFinished++;
                                            this._tTEntityResponsity.Update(temDt);
                                            msg = "成功";
                                        }
                                        else if (temDt.PiaoState == 1 && temDt.PrintState == false)
                                        {
                                            msg = "发票没打印";
                                        }

                                    }
                                    ICell h;
                                    h = row.CreateCell(76, CellType.String);
                                    h.CellStyle = style;
                                    h.SetCellValue(msg);
                                }

                            }
                            else
                            {
                                ICell h;
                                h = row.CreateCell(76, CellType.String);
                                h.CellStyle = style;
                                h.SetCellValue("当前订单不存在或者不是发货中");
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

                string secondFolderName = "myself/Hukou/";

                T_Sys_ImportFiles sysImportFiles = new T_Sys_ImportFiles()
                {
                    Type = 10,
                    TypeName = "集体户口快递导入",
                    UserId = account.Id,
                    UserName = account.RealName,
                    FileNameOld = FileNameOld,
                    FileNameNew = fileName,
                    Path = secondFolderName,
                    State = -1, //初始值
                    Message = Message,
                    CreateTime = DateTime.Now,
                    ParaJson = ""
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
                _logger.Error(this.GetType(), "Service Log 集体户口EXCEL生成服务,删除Excel文件失败", ex);

            }
            return result;
        }

        /// <summary>
        /// 2. 快递导入 验证，并更新到数据库
        /// </summary>
        /// <param name="imp"></param>
        private string KuaidiImp(T_Sys_ImportFiles imp)
        {
            string result = string.Empty;
             try
            {
                T_Sys_ImportFiles kuidiFile = _tEntityResponsity.GetById(imp.Id);

                #region 下载要验证的文件

                //从oss阿里云文件服务器下载excel文件
                Stream downloadExcelFile = DownloadExcelFiles(kuidiFile.Path, kuidiFile.FileNameNew);
                IWorkbook workbook = null;
                if (kuidiFile.FileNameNew.IndexOf(".xlsx") > 0) // 2007版本
                    workbook = new XSSFWorkbook(downloadExcelFile);
                else if (kuidiFile.FileNameNew.IndexOf(".xls") > 0) // 2003版本
                    workbook = new HSSFWorkbook(downloadExcelFile);

                ISheet sheet = workbook.GetSheetAt(0);
                IEnumerator it = sheet.GetRowEnumerator();

                #endregion

                #region  读取excel 验证订单号是否存在
                int count = 0;
                int countFinished = 0;

                if (it.MoveNext())
                {
                    if (it.MoveNext())
                    { 
                        while (it.MoveNext())
                        {
                            count++;
                            IRow row = it.Current as IRow;
                            T_HK_Order Dt = new T_HK_Order();
                            Dt.OrderNo = GetCell(row, 1, 100).Replace(" ", "");
                            Dt.Kno = GetCell(row, 2, 100).Replace(" ", "");
                            
                            List<T_HK_Order> temDtL = this._tTEntityResponsity.Table.Where(p => p.State == 4 && p.OrderNo == Dt.OrderNo).ToList();
                            if (temDtL != null)
                            {
                                if (temDtL[0].Id > 0)
                                {
                                    T_HK_Order temDt = this._tTEntityResponsity.GetById(temDtL[0].Id);
                                    if (temDt != null && temDt.Id > 0)
                                    {
                                        temDt.Kno = Dt.Kno;         //更新运单号
                                        temDt.KName = "顺丰快递";
                                        temDt.State = 5;            //已发货
                                        temDt.Statename = "已发货";
                                        if (temDt.PiaoState == 0)
                                        {
                                            countFinished++;
                                            this._tTEntityResponsity.Update(temDt);
                                        }
                                        else if (temDt.PiaoState == 1 && temDt.PrintState == true)
                                        {
                                            countFinished++;
                                            this._tTEntityResponsity.Update(temDt);
                                        }
                                    }
                                }
                                
                            }
                        }
                    }
                }
                kuidiFile.State = 1;
                kuidiFile.Message = "导入记录数：" + count + ".成功：" + countFinished + ".失败：" + (count - countFinished) + ".";
                _tEntityResponsity.Update(kuidiFile);






                #endregion
            }
            catch (Exception ex)
            {
                _logger.Error(this.GetType(), "Service Log 集体户口EXCEL生成服务,删除Excel文件失败", ex);
                result= ex.Message;
            }
             return result;
        }

        private MemoryStream StreamToMemoryStream(Stream instream)
        {
            MemoryStream outstream = new MemoryStream();
            const int bufferLen = 4096;
            byte[] buffer = new byte[bufferLen];
            int count = 0;
            while ((count = instream.Read(buffer, 0, bufferLen)) > 0)
            {
                outstream.Write(buffer, 0, count);
            }
            return outstream;
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

        /// <summary>
        /// 从OSS文件服务器下载EXCEL
        /// </summary>
        /// <returns></returns>
        public System.IO.Stream DownloadExcelFiles(string OSSPath, string fileName)
        {
 
            string accessKeyId = _fileConfiguration.AccessKeyId;
            string accessKeySecret = _fileConfiguration.AccessKeySecret;
            string endPoint = _fileConfiguration.Endpoint;
            string bucketName = _fileConfiguration.DefaultBucketName;

            System.IO.Stream res = _ossFileStorage.DownFile(accessKeyId, accessKeySecret, endPoint, bucketName, OSSPath + fileName);
            return res;
        }
    }
}
 
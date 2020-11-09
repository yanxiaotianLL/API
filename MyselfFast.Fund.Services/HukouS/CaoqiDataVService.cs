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
using System.Threading.Tasks;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core.Domain.Hukou;
using myselfFast.Fund.Services.DTO.Request.Hukou;
using myselfFast.Fund.Services.DTO.Response.Hukou;
using myselfFast.Fund.Core.Domain.ExportImport;
using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Component.Logging;

namespace myselfFast.Fund.Services.HukouS
{
    public class CaoqiDataVService : BaseService<V_HK_Order_List>, ICaoqiDataVService
    {
        private IRepository<T_HK_HuKou_Num> tNumEntityResponsity;
        private IRepository<T_HK_Order> _tTEntityResponsity;
        private IRepository<T_Sys_ExportFiles> _t_Sys_ExportFiles;
        private IRepository<T_Sys_ImportFiles> _t_Imp_ExportFiles;
        private IRepository<V_CD_XIAN> _tXEntityResponsity;
        private IRepository<V_CD_PROVINCE> _tPEntityResponsity;
        private IRepository<T_HK_Hukou_Lend> _tLendEntityResponsity;
        private IRepository<T_HK_Hokou_Transfer> _tTranEntityResponsity;
        private IImportFileImpService _ImportFile;
        private IPictrueFileService _picFile;
        private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;

        public CaoqiDataVService(IRepository<V_HK_Order_List> tEntityResponsity,
            IRepository<T_HK_Order> tTEntityResponsity,
            IRepository<T_HK_HuKou_Num> tNumEntityResponsity,
            IRepository<T_Sys_ExportFiles> t_Sys_ExportFiles,
            IRepository<T_Sys_ImportFiles> t_Imp_ExportFiles,
            IRepository<V_CD_XIAN> tXEntityResponsity,
            IRepository<V_CD_PROVINCE> tPEntityResponsity,
            IRepository<T_HK_Hukou_Lend> tLendEntityResponsity,
            IRepository<T_HK_Hokou_Transfer> tTranEntityResponsity,
            IPictrueFileService PictrueFileService,
            IImportFileImpService ImportFileImpService, IDataProvider _dataProvider, IDbContext _dbContext, ILoggerProviderFactory iLoggerProviderFactory)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.tNumEntityResponsity = tNumEntityResponsity;
            this._tTEntityResponsity = tTEntityResponsity;
            this._t_Sys_ExportFiles = t_Sys_ExportFiles;
            this._t_Imp_ExportFiles = t_Imp_ExportFiles;
            this._ImportFile = ImportFileImpService;
            this._picFile = PictrueFileService;
            this._tXEntityResponsity = tXEntityResponsity;
            this._tPEntityResponsity = tPEntityResponsity;
            this._tLendEntityResponsity = tLendEntityResponsity;
            this._tTranEntityResponsity = tTranEntityResponsity;
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
        }


        //获取集体户口列表
        public JqGridResult<V_HK_Order_List> GetHukouList(SelectHukouRequestModel model, int rows, int page)
        {
            var begintime = Utils.ToDateTime(model.ApplyTimeStart);
            var endtime = Utils.ToDateTime(model.ApplyTimeEnd);

            if (!string.IsNullOrEmpty(model.ApplyTimeEnd))
            {
                endtime = endtime.AddDays(1);
            }
            int [] states ={8,9,98,99};
            bool prtSate = Utils.ToBoolean(model.PrintState);
            string uCname = "";
            if (!string.IsNullOrEmpty(model.uCname))
            {
                uCname = Encryption.Encrypt(model.uCname);
            }
            string uCardId = "";
            if (!string.IsNullOrEmpty(model.uCardId))
            {
                uCardId = Encryption.Encrypt(model.uCardId);
            }

            IPagedList<V_HK_Order_List> pagedList = new PagedList<V_HK_Order_List>(_tEntityResponsity.Table
                //查询条件(超期退款)
                .Where(t => t.IsApplyMoney == 2 && states.Contains(t.State) && t.Transtype == 1)
                .WhereIf(t => t.Id == model.Id, model.Id > 0)
                .WhereIf(t => t.OrderFrom == model.OrderFrom, (model.OrderFrom) != "isnull")
                .WhereIf(t => t.Committime >= begintime, !string.IsNullOrEmpty(model.ApplyTimeStart))
                .WhereIf(t => t.Committime <= endtime, !string.IsNullOrEmpty(model.ApplyTimeEnd))
                .WhereIf(t => (t.State == 8 || t.State == 98), model.State == 1008)
                .WhereIf(t => (t.State == 9 || t.State == 99), model.State == 1009)
                .WhereIf(t => t.Uniqueno == model.Uniqueno, !string.IsNullOrEmpty(model.Uniqueno))
                .WhereIf(t => t.uCname == uCname, !string.IsNullOrEmpty(model.uCname))
                .WhereIf(t => t.uCardId == uCardId, !string.IsNullOrEmpty(model.uCardId))
                .WhereIf(t => t.OrderNo == model.OrderNo, !string.IsNullOrEmpty(model.OrderNo))
                .OrderByDescending(t => t.UpdateTime).ThenByDescending(t => t.Id), page, rows);

            foreach (V_HK_Order_List p in pagedList)
            {
                //加密字段解密
                p.uCname =  Encryption.IsEncrypted(p.uCname) ? Encryption.Decrypt(p.uCname) : "";
                p.uMobile =  Encryption.IsEncrypted(p.uMobile) ? Encryption.Decrypt(p.uMobile) : "";
                p.uEmail =  Encryption.IsEncrypted(p.uEmail) ? Encryption.Decrypt(p.uEmail) : "";
                p.uCardId =  Encryption.IsEncrypted(p.uCardId) ? Encryption.Decrypt(p.uCardId) : "";
            }
           
            return JqGridResult<V_HK_Order_List>.Build(pagedList);
        }
        //批量退款
        public string tuiDataList(string[] tIds, T_Admin_Account account)
        {
            string result = string.Empty;
            string UpdateId = "";
            StringBuilder sql = new StringBuilder();
            try
            {
                List<string> strList = new List<string>();
                strList.Add(Utils.ToString(0));
                //string[] tIds;
                #region 修改状态+修改状态的ID
                //修改状态
                List<V_HK_Order_List> OrderUV = _tEntityResponsity.Table.Where(p => p.IsApplyMoney == 2 && (p.State == 8 || p.State == 98) && p.Transtype == 1).ToList();
                foreach (V_HK_Order_List v in OrderUV)
                {
                    //if (DateTime.Now <= v.TradeTime.AddMonths(3))
                    //{
                    T_HK_Order orderU = _tTEntityResponsity.GetById(v.Id);
                    //if (v.OrderAmount > 0 && v.TradeStatus == 2 && v.State==8)
                    //{//有快递费，且待退款的订单，如果快递费退完了，直接修改状态，如果快递费没退完，退快递费的时候修改状态
                    //    if (v.BKDOperId > 0)
                    //    {
                    //        orderU.TradeStatus = 3;
                    //        orderU.Backno = DateTime.Now.ToString("yyyyMMdd" + orderU.Id.ToString("00000000"));
                    //        orderU.State = 9;
                    //        orderU.Statename = "已退款";
                    //    }
                    //}else 
                    if ( v.State==8)
                    {
                        orderU.TradeStatus = 3;
                        orderU.Backno = DateTime.Now.ToString("yyyyMMdd" + orderU.Id.ToString("00000000"));
                        orderU.State = 9;
                        orderU.Statename = "已退款";
                    }
                    else if (v.State == 98)
                    {
                        orderU.TradeStatus = 3;
                        orderU.Backno = DateTime.Now.ToString("yyyyMMdd" + orderU.Id.ToString("00000000"));
                        orderU.State = 99;
                        orderU.Statename = "借转迁办理结束";
                    }

                    orderU.Updater = account.UserName;
                    orderU.UpdateTime = DateTime.Now;
                    orderU.BYJOperId = account.Id;          //退押金
                    _tTEntityResponsity.Update(orderU);
                    UpdateId += Utils.ToString(orderU.Id) + ", ";
                    strList.Add(Utils.ToString(orderU.Id));
                    //}

                }
                tIds = strList.ToArray();
                string allids = String.Join(",", tIds);
                #endregion 
                #region 根据条件拼接sql
//                sql.Append(@"select dbo.Decrypt(U.Cname,'key!(*&') Name,U.Hno,dbo.Decrypt(U.CardId,'key!(*&') CardId,O.OrderNo,O.UserAlipayNo,O.UserTel,
//                        CASE WHEN CONVERT(varchar(20),O.ApplyTime,20)='1900-01-01 00:00:00' THEN '' ELSE CONVERT(varchar(20),O.ApplyTime,20)  END AS '申请时间'
//                        from T_HK_Order O,T_FES_USER U
//                        where O.Fesid=U.Id and  Transtype=1 and O.IsApplyMoney=2
//                        ");
                sql.Append(@"select U.Cname Name,U.Hno,U.CardId CardId,O.OrderNo,O.UserAlipayNo,O.UserTel,
                        CASE WHEN CONVERT(varchar(20),O.ApplyTime,20)='1900-01-01 00:00:00' THEN '' ELSE CONVERT(varchar(20),O.ApplyTime,20)  END AS '申请时间'
                        from T_HK_Order O,T_FES_USER U
                        where O.Fesid=U.Id and  Transtype=1 and O.IsApplyMoney=2
                        ");
                sql.Append("  AND  O.Id IN(" + allids + ")");
                sql.Append("  order by  O.Id desc");
                #endregion
                T_Sys_ExportFiles newmodel = new T_Sys_ExportFiles();
                newmodel.SetNullToDefalut();
                newmodel.ParmsJson = sql.ToString();
                newmodel.TypeName = "集体户口超期退款导出";
                newmodel.Type = 204;
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
            _logger.Info(this.GetType(), "集体户口财务批量退款" + Environment.NewLine + " IDS:" + UpdateId + " result:" + result);
            return result;
        }
    }
}

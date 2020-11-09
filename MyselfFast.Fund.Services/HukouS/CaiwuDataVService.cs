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
using System.IO;

namespace myselfFast.Fund.Services.HukouS
{
    public class CaiwuDataVService : BaseService<V_HK_Order_List>, ICaiwuDataVService
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
        public CaiwuDataVService(IRepository<V_HK_Order_List> tEntityResponsity,
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

            bool prtSate = Utils.ToBoolean(model.PrintState);
            IPagedList<V_HK_Order_List> pagedList = new PagedList<V_HK_Order_List>(_tEntityResponsity.Table
                //.Where(t => t.Transtype ==1)
                //查询条件
                .WhereIf(t => t.Id == model.Id, model.Id > 0)
                .WhereIf(t => t.Transtype == model.Transtype, model.Transtype > -1)
                .WhereIf(t => t.OrderFrom == model.OrderFrom, (model.OrderFrom) != "isnull")
                .WhereIf(t => t.Committime >= begintime, !string.IsNullOrEmpty(model.ApplyTimeStart))
                .WhereIf(t => t.Committime <= endtime, !string.IsNullOrEmpty(model.ApplyTimeEnd))
                .WhereIf(t => t.State == model.State, model.State != 0 && model.State != 1000 && model.State != 1001)
                .WhereIf(t => t.TradeStatus == 2 && t.BYJOperId == 0 && t.OrderDeposit > 0 && (t.State == 8 || t.State == 98 || t.State == -9 || t.State == -7) && t.IsApplyMoney == 0, model.State == 1000)
                 .WhereIf(t => (t.TradeStatus == 2 || t.TradeStatus == 3) && t.BYJOperId > 0 && t.OrderDeposit > 0, model.State == 1001)
                .WhereIf(t => t.kuaidiOrder == 1, model.OrderType == 1)
                .WhereIf(t => t.dianziOrder == 1, model.OrderType == 2)
                .WhereIf(t => t.PiaoState == model.PiaoState, model.PiaoState > -1)
                .WhereIf(t => t.PrintState == prtSate, model.PrintState > -1)
                .WhereIf(t => t.Uniqueno == model.Uniqueno, !string.IsNullOrEmpty(model.Uniqueno))
                .WhereIf(t => t.uCname == uCname, !string.IsNullOrEmpty(model.uCname))//用户名加密
                .WhereIf(t => t.OrderNo == model.OrderNo, !string.IsNullOrEmpty(model.OrderNo))
                .WhereIf(t => t.uCardId == uCardId, !string.IsNullOrEmpty(model.uCardId))//身份证加密
                .OrderByDescending(t => t.OrderRelevance).ThenBy(t => t.Id), page, rows);

            foreach (V_HK_Order_List p in pagedList)
            {
                //加密字段解密
                p.uCname =  Encryption.IsEncrypted(p.uCname) ? Encryption.Decrypt(p.uCname) : "";
                p.uMobile = Encryption.IsEncrypted(p.uMobile) ? Encryption.Decrypt(p.uMobile) : "";
                p.uEmail =  Encryption.IsEncrypted(p.uEmail)  ? Encryption.Decrypt(p.uEmail) : "";
                p.uCardId = Encryption.IsEncrypted(p.uCardId) ? Encryption.Decrypt(p.uCardId) : "";
            }
            return JqGridResult<V_HK_Order_List>.Build(pagedList);
        }
        //批量退款
        public string tuiDataList(T_Admin_Account account)
        {
            string result = string.Empty;
            string UpdateId = "";
            StringBuilder sql = new StringBuilder();
            try
            {
                List<string> strList = new List<string>();
                strList.Add(Utils.ToString(0));
                string[] tIds={};
                #region 修改状态+修改状态的ID
                //修改状态
                List<V_HK_Order_List> OrderUV = _tEntityResponsity.Table.Where(p => p.Alipayno != "" && p.OrderDeposit > 0 && p.TradeStatus == 2 && p.BYJOperId <= 0 && (p.State == 8 || p.State == 98 || p.State == -9 || p.State == -7) && p.Transtype == 1 && p.IsApplyMoney == 0).ToList();
                foreach (V_HK_Order_List v in OrderUV)
                {
                    if (v.IsApplyMoney == 0 && v.BYJOperId <= 0)//DateTime.Now <= v.TradeTime.AddMonths(3) //没有超期的，没有退款的
                    {
                        T_HK_Order orderU = _tTEntityResponsity.GetById(v.Id);
                        
                        if (v.OrderAmount > 0 && (v.State == -9 || v.State == -7))
                        {//有快递费，且待退款的订单，如果快递费退完了，直接修改状态，如果快递费没退完，退快递费的时候修改状态
                            if (v.BKDOperId > 0 )
                            {
                                orderU.TradeStatus = 3;
                            }
                        }
                        else
                        {
                            //不需要退快递费
                            orderU.TradeStatus = 3;
                            if (v.State == 8)
                            {
                                orderU.State = 9;
                                orderU.Statename = "已退款";
                            }
                            else if (v.State == 98)
                            {
                                orderU.State = 99;
                                orderU.Statename = "借转迁办理结束";
                            }
                        }
                        orderU.Backno = DateTime.Now.ToString("yyyyMMdd" + orderU.Id.ToString("00000000"));
                        orderU.Updater = account.UserName;
                        orderU.UpdateTime = DateTime.Now;
                        orderU.BYJOperId = account.Id;          //退押金
                        //orderU.IsBackYajin = "押金已退";
                        _tTEntityResponsity.Update(orderU);
                        UpdateId += Utils.ToString(orderU.Id) + ", ";
                        strList.Add(Utils.ToString(orderU.Id));
                    }
                    tIds = strList.ToArray();
                }
                #endregion

                string allids = String.Join(",", tIds);
                #region 根据条件拼接sql
                //replace(replace(replace(CONVERT(varchar, getdate(), 120 ),'-',''),' ',''),':','')  '批次号'
                sql.Append(@"select Backno 
                        ,Alipayno 
                        ,OrderDeposit 
                        , '批量退款' '退款备注'
                         FROM dbo.T_HK_Order WHERE Alipayno!='' AND  Transtype=1 AND IsApplyMoney=0");//dateadd(month,3,TradeTime) >= GETDATE()
                sql.Append("  AND Id IN(" + allids + ")");
                sql.Append("  order by Id desc");
                #endregion
                T_Sys_ExportFiles newmodel = new T_Sys_ExportFiles();
                newmodel.SetNullToDefalut();
                newmodel.ParmsJson = sql.ToString();
                newmodel.TypeName = "集体户口批量退款导出";
                newmodel.Type = 203;
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
            _logger.Info(this.GetType(), "集体户口财务批量超期退款" + Environment.NewLine + " IDS:" + UpdateId + " result:" + result);
            return result;
        }

        //上传退款证明
        public string setImg(int id, string path, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                string savePath = System.Web.HttpContext.Current.Server.MapPath("~/Images/HK");//建立虚拟路径
                if (System.IO.Directory.Exists(savePath) == false)//如果不存在就创建文件夹
                {
                    System.IO.Directory.CreateDirectory(savePath);
                }
 
                string  UserPhoto = "";
                //读图片转为Base64String
                System.Drawing.Bitmap bmp1 = new System.Drawing.Bitmap(savePath +"/"+ path);
                using (MemoryStream ms1 = new MemoryStream())
                {
                    bmp1.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arr1 = new byte[ms1.Length];
                    ms1.Position = 0;
                    ms1.Read(arr1, 0, (int)ms1.Length);
                    ms1.Close();
                    UserPhoto = Convert.ToBase64String(arr1);
                }

                //上传图片
                result = _picFile.SaveBase64Pictrue(UserPhoto, 9,id, account);       
                
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        
        //批量打印快递
        public string setPrintState(string[] tIds, T_Admin_Account account)
        {
            string result = string.Empty;
             int[] ttIds = new int[tIds.Length];
              for (int i = 0; i <tIds.Length; i++)
              {
                  ttIds[i] = Utils.ToInt(tIds[i]);
              }
 

            List<T_HK_Order> Order = _tTEntityResponsity.Table.Where(o => ttIds.Contains(o.Id)).ToList();

            if (Order == null || Order.Count == 0)
            {
                result = "您勾选的内容里没有数据！";
            }
            else
            {
                foreach (T_HK_Order o in Order)
                {
                    o.PrintState = true;
                    o.PrintDate = DateTime.Now;
                    o.UpdateTime = DateTime.Now;
                    o.Updater = account.UserName;
                    this._tTEntityResponsity.Update(o);
                }
                
            }
            return result;
        }
        //确认收款
        public string setShoukuan(int id,string Alipayno,string BuyerAccount,DateTime TradeTime, T_Admin_Account account)
        {
            string result = string.Empty;
            T_HK_Order Order = _tTEntityResponsity.GetById(id);

            if (Order != null && Order.Id > 0)
            {
                if (Order.State == 1)
                {
                    Order.BuyerAccount = BuyerAccount;      //只有在未支付的状况下，允许修改支付宝账号
                    Order.TradeTime = TradeTime;            //交易时间
                }
                Order.State = 3;
                Order.Statename = "已收款";
                Order.Alipayno = Alipayno;
                
                Order.UpdateTime = DateTime.Now;
                Order.Updater = account.UserName;
                this._tTEntityResponsity.Update(Order);

            }
            _logger.Info(this.GetType(), "集体户口-确认收款" + Environment.NewLine + " ID:" + Order.Id + "支付宝流水号:" + Alipayno + " result:" + result);
            return result;
 
        }
    }
}

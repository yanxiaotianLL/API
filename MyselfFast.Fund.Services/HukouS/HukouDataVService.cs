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
using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Services.Admin;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Component.Logging;
using System.IO;
using System.Data;
using System.Data.SqlClient;


namespace myselfFast.Fund.Services.HukouS
{
    public class HukouDataVService : BaseService<V_HK_Order_List>, IHukouDataVService
    {
        private IRepository<T_HK_HuKou_Num> tNumEntityResponsity;
        private IRepository<T_HK_Order> _tTEntityResponsity;
        private IRepository<T_Sys_ExportFiles> _t_Sys_ExportFiles;
        private IRepository<T_Sys_ImportFiles> _t_Imp_ExportFiles;
        private IRepository<V_CD_XIAN> _tXEntityResponsity;
        private IRepository<V_CD_PROVINCE> _tPEntityResponsity;
        private IRepository<T_HK_Hukou_Lend> _tLendEntityResponsity;
        private IRepository<T_HK_Hokou_Transfer> _tTranEntityResponsity;
        private IRepository<T_Fes_User> _fesUserEntity;

        private IImportFileImpService _ImportFile;
        private IPictrueFileService _picFile;
        private ISendMessageService _SendMessage;
        private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;
        public HukouDataVService(IRepository<V_HK_Order_List> tEntityResponsity,
            IRepository<T_HK_Order> tTEntityResponsity,
            IRepository<T_HK_HuKou_Num> tNumEntityResponsity,
            IRepository<T_Sys_ExportFiles> t_Sys_ExportFiles,
            IRepository<T_Sys_ImportFiles> t_Imp_ExportFiles,
            IRepository<V_CD_XIAN> tXEntityResponsity,
            IRepository<V_CD_PROVINCE> tPEntityResponsity,
            IRepository<T_Fes_User> tfesUserEntity,
            IRepository<T_HK_Hukou_Lend> tLendEntityResponsity,
            IRepository<T_HK_Hokou_Transfer> tTranEntityResponsity,
            ISendMessageService SendMessage,
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
            this._fesUserEntity = tfesUserEntity;
            this._tLendEntityResponsity = tLendEntityResponsity;
            this._tTranEntityResponsity = tTranEntityResponsity;
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            this._SendMessage = SendMessage;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
        }
 
        //获取集体户口列表
        public JqGridResult<V_HK_Order_List> GetHukouList(SelectHukouRequestModel model,T_Admin_Account account, int rows, int page)
        {
            var begintime = Utils.ToDateTime(model.ApplyTimeStart);
            var endtime = Utils.ToDateTime(model.ApplyTimeEnd);

            if (!string.IsNullOrEmpty(model.ApplyTimeEnd))
            {
                endtime = endtime.AddDays(1);
            }
            string IsGuihuanMenu="";
            string IsEditKuaidiMenu = "";
            string IsGuanliMenu = "";
            if (account.IsAuthorizationMenuDataKey("13131313-0001", "HKGuihuan"))
            {
                IsGuihuanMenu = "T";
            }
            if (account.IsAuthorizationMenuDataKey("13131313-0001", "HKGuanli"))
            {
                IsGuanliMenu = "T";
            }
            if (account.IsAuthorizationMenuDataKey("13131313-0001", "HKkuaidi"))
            {
                IsEditKuaidiMenu = "T";
            }
            bool prtSate = Utils.ToBoolean(model.PrintState);
            //List<SqlParameter> prams = new List<SqlParameter>();
            //prams.Add(ConnBase.MakeInParam("@para1", SqlDbType.NVarChar, 100, para1));
            //DataTable dt = myselfEntity.SelectProcdure(prams, "P_HK_Order_List");
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
                //查询条件
                .WhereIf(t => t.Id == model.Id, model.Id > 0)
                .WhereIf(t => t.Transtype == model.Transtype, model.Transtype > -1)
                .WhereIf(t => t.OrderFrom == model.OrderFrom, (model.OrderFrom) != "isnull")
                .WhereIf(t => t.Committime >= begintime, !string.IsNullOrEmpty(model.ApplyTimeStart))
                .WhereIf(t => t.Committime <= endtime, !string.IsNullOrEmpty(model.ApplyTimeEnd))
                .WhereIf(t => t.State == model.State, model.State != 0 && model.State!=1000  && model.State!=1001)
                .WhereIf(t => t.TradeStatus == 2 && t.BKDOperId == 0 && t.OrderAmount > 0 && (t.State == -9 || t.State == -7), model.State == 1000)
                .WhereIf(t => (t.TradeStatus == 2 || t.TradeStatus == 3) && t.BKDOperId > 0 && t.OrderAmount > 0, model.State == 1001)
                .WhereIf(t => t.kuaidiOrder == 1, model.OrderType == 1)
                .WhereIf(t => t.dianziOrder == 1, model.OrderType == 2)
                .WhereIf(t => t.PiaoState == model.PiaoState, model.PiaoState >-1)
                .WhereIf(t => t.PrintState == prtSate, model.PrintState > -1)
                .WhereIf(t => t.Uniqueno == model.Uniqueno, !string.IsNullOrEmpty(model.Uniqueno))
                .WhereIf(t => t.uCname == uCname, !string.IsNullOrEmpty(model.uCname))
                .WhereIf(t => t.OrderNo == model.OrderNo, !string.IsNullOrEmpty(model.OrderNo))
                .WhereIf(t => t.uCardId == uCardId, !string.IsNullOrEmpty(model.uCardId))
                .OrderByDescending(t => t.OrderRelevance).ThenBy(t => t.Id), page, rows);
            foreach (V_HK_Order_List p in pagedList)
            {
                p.IsGuihuanMenu = IsGuihuanMenu;
                p.IsGuanliMenu = IsGuanliMenu;
                p.IsEditKuaidiMenu = IsEditKuaidiMenu;
                p.IsJyQianchu = "";
                if (p.Transtype == 0)
                {
                    List<V_HK_Order_List> orderComp = _tEntityResponsity.Table.Where(v => v.Uniqueno == p.Uniqueno && v.State >= 4 && v.State < 8 && v.Transtype == 1 && v.Originaldoc == 1).ToList();
                    if (orderComp != null && orderComp.Count > 0)
                    {
                        p.IsJyQianchu = "T";        //存在借阅未归还的订单
                    }
                }
                //加密字段解密
                p.uCname =  Encryption.IsEncrypted(p.uCname) ? Encryption.Decrypt(p.uCname) : "";
                p.uMobile =  Encryption.IsEncrypted(p.uMobile) ? Encryption.Decrypt(p.uMobile) : "";
                p.uEmail =  Encryption.IsEncrypted(p.uEmail) ? Encryption.Decrypt(p.uEmail) : "";
                p.uCardId =  Encryption.IsEncrypted(p.uCardId) ? Encryption.Decrypt(p.uCardId) : "";
            }
           
            return JqGridResult<V_HK_Order_List>.Build(pagedList);
        }
 
        // 获取集体户口详情
        public ResHukouDetailListResponseModel GetHukouDetail(int id)
        {
            ResHukouDetailListResponseModel res = new ResHukouDetailListResponseModel();
            List<V_HK_Order_List> Order = _tEntityResponsity.Table.Where(p => p.Id == id).ToList();
            List<T_HK_HuKou_Num> ordernum = new List<T_HK_HuKou_Num>();
            T_HK_Hukou_Lend orderlen = new T_HK_Hukou_Lend();
            if (Order != null && Order.Count > 0)
            {
                var ii = Order[0].BussinessId;
                ordernum = tNumEntityResponsity.Table.Where(p => p.BusinessId == ii && p.Isdelete == false).ToList();
                
                if (Order[0].Firstpage == 1)
                {
                    res.showNum = "display:block";
                }
                else
                {
                    res.showNum = "display:none";
                }
                res.vHk = Order[0];
                //加密字段解密
 
                res.vHk.uCname =  Encryption.IsEncrypted(res.vHk.uCname) ? Encryption.Decrypt(res.vHk.uCname) : "";
                res.vHk.uMobile =  Encryption.IsEncrypted(res.vHk.uMobile)   ? Encryption.Decrypt(res.vHk.uMobile) : "";
                res.vHk.uEmail =  Encryption.IsEncrypted(res.vHk.uEmail)   ? Encryption.Decrypt(res.vHk.uEmail) : "";
                res.vHk.uCardId =  Encryption.IsEncrypted(res.vHk.uCardId)   ? Encryption.Decrypt(res.vHk.uCardId) : "";
                //迁出信息
                if (Order[0].Transtype == 0)
                {
                    T_HK_Hokou_Transfer hktran = _tTranEntityResponsity.GetById(Order[0].BussinessId);
                    res.hktran = hktran;
                    if (hktran.EmigrationReason=="其他")
                    {
                        res.Otherdesc = hktran.Remark;      //迁出其他原因
                    }
                    
                }
                 
            }
            foreach (T_HK_HuKou_Num n in ordernum)
            {
                orderlen = _tLendEntityResponsity.Table.Where(p => p.Id == n.BusinessId && p.Isdelete == false).ToList().First();
                res.Useageid.Add(n.UseageId);
                res.Useage.Add(n.Useage);
                res.UseageNum.Add(Utils.ToString(n.Num));
                //res.Otherdesc = "";
                if (n.UseageId == 10)
                {
                    res.Otherdesc = orderlen.Otherdesc;
                }
            }
            return res;
        }

        //后台取消订单
        public string tuiOrder(int id, string Cancelcause, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                //
                T_HK_Order f = this._tTEntityResponsity.GetById(id);
                if ((f.OrderDeposit > 0 || f.OrderAmount > 0) && f.State == 3)
                {//财务已收款
                    List<T_HK_Order> temDt = this._tTEntityResponsity.Table.Where(p => p.State == 3 && p.OrderRelevance == id).ToList<T_HK_Order>();
                    if (temDt != null && temDt.Count == 1)
                    {//此单没有合并订单或者相关子订单已经取消了,可直接取消
                        T_HK_Order u = this._tTEntityResponsity.GetById(id);
                        u.State = -9;
                        u.Statename = "后台取消";
                        u.Cancelcause = Cancelcause;
                        u.TradeStatus = 2;
                        u.UpdateTime = DateTime.Now;
                        u.Updater = account.UserName;
                        this._tTEntityResponsity.Update(u);
                        if(u.Transtype==0)
                        {//迁出
                            T_HK_Hokou_Transfer orderTra = this._tTranEntityResponsity.GetById(u.BussinessId);
                            orderTra.State=88;
                            orderTra.StateName="办理结束";
                            this._tTranEntityResponsity.Update(orderTra);
                        }
                        else if(u.Transtype==1)
                        {//借阅
                            T_HK_Hukou_Lend orderlen =this._tLendEntityResponsity.GetById(u.BussinessId);
                            orderlen.State=88;
                            orderlen.StateName="办理结束";
                            this._tLendEntityResponsity.Update(orderlen);
                        }

       
                    }
                    else if (temDt != null && temDt.Count > 1)
                    {//此单有多个未取消的合并订单
                        List<T_HK_Order> temDt1 = this._tTEntityResponsity.Table.Where(p => p.State == 3 && p.OrderRelevance == id && p.Id == id).ToList<T_HK_Order>();
                        if (temDt1 != null && temDt1.Count == 1)
                        { //此单是父订单
                            return "此订单存在有效的合并订单，无法退快递费，请先将合并订单取消？";
                        }
                        else
                        {//此单是子订单（一定没有快递费,快递费在父订单上,一定存在押金）
                            T_HK_Order u = this._tTEntityResponsity.GetById(id);
                            if (u.OrderDeposit > 0)
                            {//存在押金，退款,取消
                                u.State = -9;
                                u.Statename = "后台取消";
                                u.Cancelcause = Cancelcause;
                                u.TradeStatus = 2;
                                u.UpdateTime = DateTime.Now;
                                u.Updater = account.UserName;
                                this._tTEntityResponsity.Update(u);
                                if (u.Transtype == 0)
                                {//迁出
                                    T_HK_Hokou_Transfer orderTra = this._tTranEntityResponsity.GetById(u.BussinessId);
                                    orderTra.State = 88;
                                    orderTra.StateName = "办理结束";
                                    this._tTranEntityResponsity.Update(orderTra);
                                }
                                else if (u.Transtype == 1)
                                {//借阅
                                    T_HK_Hukou_Lend orderlen = this._tLendEntityResponsity.GetById(u.BussinessId);
                                    orderlen.State = 88;
                                    orderlen.StateName = "办理结束";
                                    this._tLendEntityResponsity.Update(orderlen);
                                }
                            }
                        }
                    }
                }
                else if ((f.OrderDeposit > 0 || f.OrderAmount > 0) && f.State == 1)
                {//未支付
                    f.State = -9;
                    f.Statename = "后台取消";
                    f.Cancelcause = Cancelcause;
                    f.UpdateTime = DateTime.Now;
                    f.Updater = account.UserName;
                    this._tTEntityResponsity.Update(f);
                    if (f.Transtype == 0)
                    {//迁出
                        T_HK_Hokou_Transfer orderTra = this._tTranEntityResponsity.GetById(f.BussinessId);
                        orderTra.State = 88;
                        orderTra.StateName = "办理结束";
                        this._tTranEntityResponsity.Update(orderTra);
                    }
                    else if (f.Transtype == 1)
                    {//借阅
                        T_HK_Hukou_Lend orderlen = this._tLendEntityResponsity.GetById(f.BussinessId);
                        orderlen.State = 88;
                        orderlen.StateName = "办理结束";
                        this._tLendEntityResponsity.Update(orderlen);
                    }
                }
                else
                { //该订单无费用，直接取消
                    f.State = -9;
                    f.Statename = "后台取消";
                    f.Cancelcause = Cancelcause;
                    f.UpdateTime = DateTime.Now;
                    f.Updater = account.UserName;
                    this._tTEntityResponsity.Update(f);
                    if (f.Transtype == 0)
                    {//迁出
                        T_HK_Hokou_Transfer orderTra = this._tTranEntityResponsity.GetById(f.BussinessId);
                        orderTra.State = 88;
                        orderTra.StateName = "办理结束";
                        this._tTranEntityResponsity.Update(orderTra);
                    }
                    else if (f.Transtype == 1)
                    {//借阅
                        T_HK_Hukou_Lend orderlen = this._tLendEntityResponsity.GetById(f.BussinessId);
                        orderlen.State = 88;
                        orderlen.StateName = "办理结束";
                        this._tLendEntityResponsity.Update(orderlen);
                    }
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        //借阅转迁出审核不通过
        public string tuiOrderJYno(int id, string Backcause, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            { 
                T_HK_Order f = this._tTEntityResponsity.GetById(id);
                if (f.State == 96)
                {
                    f.State = 97;
                    f.Statename = "迁出审核失败";
                    f.Backcause = Backcause;//审核不通过原因
                    f.UpdateTime = DateTime.Now;
                    f.Updater = account.UserName;
                    this._tTEntityResponsity.Update(f);
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        public string tuiOrderJYok(int id, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                T_HK_Order f = this._tTEntityResponsity.GetById(id);
                if (f.State == 96)
                {
                    if (DateTime.Now > f.TradeTime.AddDays(80) && Utils.ToString(f.TradeTime) != "1900-1-1 0:00:00")
                    {
                        result = _SendMessage.SendMessageQianchu(Utils.ToString(f.Id));
                        f.IsApplyMoney = 1;
                    }
                    f.TradeStatus = 2;       

                    f.State = 98;
                    f.Statename = "迁出审核通过";
                    f.UpdateTime = DateTime.Now;
                    f.Updater = account.UserName;
                    this._tTEntityResponsity.Update(f);
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        //确认邮件已发
        public string setIsSendEmail(int id, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                V_HK_Order_List v = new V_HK_Order_List();
                List<V_HK_Order_List> Order = _tEntityResponsity.Table.Where(p => p.Id == id).ToList();
                if(Order!=null && Order.Count>0)
                {
                    v = Order[0];
                }
                
                T_HK_Order f = this._tTEntityResponsity.GetById(id);
                f.IsSendEmail = 2;      //设置电子版邮件已发
                if (v.dianziOrder == 1 && v.kuaidiOrder == 0)
                {
                    f.State = 88;           //纯电子订单，发完邮件，订单结束
                    f.Statename = "办理结束";
                    f.UpdateTime = DateTime.Now;
                    f.Updater = account.UserName;
                    this._tTEntityResponsity.Update(f);
                }
                else if (v.dianziOrder == 1 && v.kuaidiOrder == 1)
                {
                    //有快递订单，判断快递订单是否结束
                    if (v.OrderDeposit > 0 && (v.State == 9 || v.State == 99)  )
                    {
                        //有押金的，
                        f.State = 88;           
                        f.Statename = "办理结束";
                    }
                    else if (v.OrderDeposit <= 0 && v.State >= 6)
                    {
                        //无押金的，6：本人已经签收，直接办理结束
                        f.State = 88;            
                        f.Statename = "办理结束";
                    }
                    f.UpdateTime = DateTime.Now;
                    f.Updater = account.UserName;
                    this._tTEntityResponsity.Update(f);
                }
                
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        //批量确认邮件已发
        public string setIsSendEmailByids(string[] tIds, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                // (rowObject.State >= 3 && rowObject.State <= 9 && rowObject.dianziOrder == 1 && rowObject.IsSendEmail != 2) && rowObject.Transtype == 1 
                List<V_HK_Order_List> Order = _tEntityResponsity.Table.Where(p => p.State >= 3 && p.State <= 9 && p.dianziOrder == 1 && p.Transtype == 1 && p.IsSendEmail != 2)
                 .ToList().Where(o => tIds.Contains((o.Id).ToString())).ToList();
                if (Order == null || Order.Count == 0)
                {
                    result = "您勾选的内容里没有需要归还的订单！";
                }
                else
                {
                    foreach (V_HK_Order_List o in Order)
                    {
                        T_HK_Order f = this._tTEntityResponsity.GetById(o.Id);
                        result=this.setIsSendEmail(f.Id, account);
                    }
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;

        }
        //确认材料已归还 
        public string setBackTime(int id, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                T_HK_Order f = this._tTEntityResponsity.GetById(id);
                if (DateTime.Now > f.TradeTime.AddDays(80))
                {
                    result = _SendMessage.SendMessage(Utils.ToString(id));
                    f.IsApplyMoney = 1;
                }
                f.BackTime = DateTime.Now;
                f.State = 8;            
                f.Statename = "已归还";
                f.TradeStatus = 2;                      
                f.UpdateTime = DateTime.Now;
                f.Updater = account.UserName;
                this._tTEntityResponsity.Update(f);

            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        //批量归还
        public string setBackTimeByids(string[] tIds, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                // (rowObject.State == 7 || rowObject.State == 5 || rowObject.State == 6) && rowObject.Transtype == 1
                List<V_HK_Order_List> Order = _tEntityResponsity.Table.Where(p => (p.State == 5 || p.State == 6 || p.State == 7) && p.Transtype == 1 && p.OrderDeposit>0 && p.kuaidiOrder==1)
                 .ToList().Where(o => tIds.Contains((o.Id).ToString())).ToList();
                if (Order == null || Order.Count == 0)
                {
                    result = "您勾选的内容里没有需要归还的订单！";
                }
                else
                {
                    foreach (V_HK_Order_List o in Order)
                    {
                        T_HK_Order f = this._tTEntityResponsity.GetById(o.Id);
                        if (DateTime.Now > f.TradeTime.AddDays(80) && Utils.ToString(f.TradeTime) != "1900-1-1 0:00:00")
                        {
                            result = _SendMessage.SendMessage(Utils.ToString(o.Id));
                            f.IsApplyMoney = 1;
                        }
                        f.BackTime = DateTime.Now;
                        f.State = 8;
                        f.Statename = "已归还";
                        f.TradeStatus = 2;       
                        f.UpdateTime = DateTime.Now;
                        f.Updater = account.UserName;
                        this._tTEntityResponsity.Update(f);
                    }
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        //上传退款证明
        public string setImg(int id,string path, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                string savePath = System.Web.HttpContext.Current.Server.MapPath("~/Images/HK");//建立虚拟路径
                if (System.IO.Directory.Exists(savePath) == false)//如果不存在就创建文件夹
                {
                    System.IO.Directory.CreateDirectory(savePath);
                }

                string UserPhoto = "";
                //读图片转为Base64String
                System.Drawing.Bitmap bmp1 = new System.Drawing.Bitmap(savePath + "/" + path);
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
                result = _picFile.SaveBase64Pictrue(path, 9, id, account);

            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        
        //快递导出
        public string kuaidiDataOut(string[] tIds, T_Admin_Account account)
        {
            string result = string.Empty;
            string UpdateId = "";
            //PiaoState == 1 && PrintState == true
            List<V_HK_Order_List> Order = _tEntityResponsity.Table.Where(p => p.State == 3 && p.kuaidiOrder == 1 && ((p.PiaoState == 1 && p.PrintState==true) || p.PiaoState == 0))
                 .ToList().Where(o => tIds.Contains((o.Id).ToString())).ToList();
            
            if (Order == null || Order.Count==0)
            {
                result ="您勾选的内容里没有可以发快递的订单，不能导出！";
            }
            else
            {
                #region 绑定关联订单一起导出
                //绑定关联订单一起导出
                List<string> strList = new List<string>();
                strList.Add(Utils.ToString(0));
                foreach (V_HK_Order_List o in Order)
                {
                    int pId = 0;
                    if (o.OrderRelevance != o.Id)//存在关联的父订单，找到父订单的ID
                    {
                        V_HK_Order_List pOrder = _tEntityResponsity.Table.Where(M => M.Id == o.OrderRelevance).ToList().FirstOrDefault();
                        if (pOrder != null && pOrder.Id > 0)
                        {
                            pId = pOrder.Id;
                        }
                        else
                        {
                            pId = o.Id;
                        }
                    }
                    else
                    {
                        pId = o.Id;
                    }
                    //通过父订单，找到全部订单
                    List<V_HK_Order_List> zOrder = _tEntityResponsity.Table.Where(p => p.State == 3 && p.kuaidiOrder == 1 && p.OrderRelevance == pId ).ToList();
                    //关联订单是否都开了发票
                    bool piaoT =true;
                    foreach (V_HK_Order_List z in zOrder)
                    {
                        if( z.PiaoState == 1 && z.PrintState==false)
                        {
                            piaoT=false;//存在未开发票的关联订单
                        }
                    }
                    if (piaoT == true)
                    {
                        foreach (V_HK_Order_List z in zOrder)
                        {
                            strList.Add(Utils.ToString(z.Id));
                        }
                    }
                    
                }
                tIds = strList.ToArray(); 
                #endregion 
                
                StringBuilder sql = new StringBuilder();
                try
                {
                    string allids = String.Join(",", tIds);
                    #region 根据条件拼接sql
                    // +(select stuff((select ','+(Useage+CONVERT(nvarchar(10), Num) +'张'+CHAR(10)) FROM T_HK_HuKou_Num  where  Isdelete=0 AND BusinessId= o.BussinessId  FOR xml path ('')),1,1,''))

                    sql.Append(@"SELECT OrderNo 
                                    ,'北京外企人力资源服务有限公司'
                                    ,'集体户口组'
                                    ,'010-85691111'
                                    ,'北京市朝阳区朝阳门南大街14号，一层服务大厅'
                                    ,Fname
                                    ,Letterpeople
                                    ,Pone
                                    ,Pone
                                    ,(ProvinceName+CityName+AddrStr)  AS Adress
                                   ,CASE WHEN  Transtype=1 THEN 
                                    (CASE WHEN (Originaldoc=1 )  THEN '集体户口卡原件'+CHAR(10) ELSE '' END)  
                                    +(CASE WHEN (Firstcopy =1)  THEN '集体户口首页' +CHAR(10) 
                                    ELSE '' END )  
                                    ELSE '迁出相关材料' END
                                    AS name
                                    ,1
                                    ,1
                                    ,''
                                    ,'寄付月结'
                                    ,'顺丰标快'
                                    ,1
                                     FROM  dbo.V_HK_Order_List o  WHERE kuaidiOrder=1
                                    ");

                    sql.Append("  AND Id IN(" + allids + ")");
                    sql.Append("  ORDER BY OrderRelevance DESC,Id ASC");
                    #endregion
                    T_Sys_ExportFiles newmodel = new T_Sys_ExportFiles();
                    newmodel.SetNullToDefalut();
                    newmodel.ParmsJson = sql.ToString();
                    newmodel.TypeName = "集体户口快递订单记录";
                    newmodel.Type = 202;
                    newmodel.UserId = account.Id;
                    newmodel.UserName = account.UserName + "";
                    newmodel.CreateTime = DateTime.Now;
                    newmodel.State = -1;
                    _t_Sys_ExportFiles.Insert(newmodel);
                    //修改状态
                    List<V_HK_Order_List> OrderUV = _tEntityResponsity.Table.Where(p => p.State == 3 && p.kuaidiOrder == 1).ToList().Where(o => tIds.Contains((o.Id).ToString())).ToList();
                    
                    foreach (V_HK_Order_List f in OrderUV)
                    {
                        T_HK_Order OrderU = _tTEntityResponsity.GetById(f.Id);
                        OrderU.State = 4;                       //状态改为发货中
                        OrderU.Statename = "发货中";                     
                        OrderU.UpdateTime = DateTime.Now;
                        OrderU.Updater = account.UserName;
                        this._tTEntityResponsity.Update(OrderU);
                        UpdateId +=Utils.ToString( OrderU.Id )+ ", ";
                    }
                }
                catch (Exception e)
                {
                    result = e.Message;
                }
            }
            _logger.Info(this.GetType(), "集体户口快递导出" + Environment.NewLine + " IDS:" + UpdateId + " result:" + result);
            return result;
        }

        //迁出导出
        public string qianchuDataOut(string[] tIds, T_Admin_Account account)
        {
            string result = string.Empty;
            string UpdateId = "";
            List<V_HK_Order_List> Order = _tEntityResponsity.Table.Where(p => p.Transtype == 0 && p.State>2)
                 .ToList().Where(o => tIds.Contains((o.Id).ToString())).ToList();

            if (Order == null || Order.Count == 0)
            {
                result = "您勾选的内容里没有已支付的迁出订单，不能导出！";
            }
            else
            {
                StringBuilder sql = new StringBuilder();
                try
                {
                    string allids = String.Join(",", tIds);
                    #region 根据条件拼接sql
                    sql.Append(@"select O.Uniqueno,O.uCardId,O.uCname,T.MaritalStatus,
                                     T.Sex,Convert(varchar(20),T.Birthday,23)Birthday,T.Native,T.Phone,T.NewCompany,T.EmigrationReason,
                                     T.EmigrationAddress,T.CancelReason,T.ToCountry,
                                     CASE WHEN CONVERT(varchar(20),T.Inhometime,23)='1900-01-01' THEN '' ELSE CONVERT(varchar(20),T.Inhometime,23) END  Inhometime,
                                     CASE WHEN CONVERT(varchar(20),T.Emigrationtime,23)='1900-01-01' THEN '' ELSE CONVERT(varchar(20),T.Emigrationtime,23) END  Emigrationtime
                                     from dbo.V_HK_Order_List O,T_HK_Hokou_Transfer T 
                                     where O.Transtype=0 and O.BussinessId=T.Id  
                                     AND O.State>2
                                    ");

                    sql.Append("  AND  O.Id IN(" + allids + ")");
                    sql.Append("  order by O.Id Desc");
                    #endregion
                    T_Sys_ExportFiles newmodel = new T_Sys_ExportFiles();
                    newmodel.SetNullToDefalut();
                    newmodel.ParmsJson = sql.ToString();
                    newmodel.TypeName = "集体户口迁出存档记录";
                    newmodel.Type = 205;
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
            }
            _logger.Info(this.GetType(), "集体户口迁出存档记录导出" + Environment.NewLine + " IDS:" + UpdateId + " result:" + result);
            return result;
        }

        //查询数据导出
        public string searchDataOut(string[] tIds, T_Admin_Account account)
        { 
            string result = string.Empty;
            
            List<V_HK_Order_List> Order = _tEntityResponsity.Table.Where(p => p.Id >0).ToList().Where(o => tIds.Contains((o.Id).ToString())).ToList();
            if (Order == null || Order.Count==0)
            {
                result ="没有要导出的订单！";
            }
            else
            {
                #region 绑定关联订单一起导出
                //绑定关联订单一起导出
                List<string> strList = new List<string>();
                strList.Add(Utils.ToString(0));
                foreach (V_HK_Order_List o in Order)
                {
                    int pId = 0;
                    if (o.OrderRelevance != o.Id)//存在关联的父订单，找到父订单的ID
                    {
                        V_HK_Order_List pOrder = _tEntityResponsity.Table.Where(M => M.Id == o.OrderRelevance).ToList().First();
                        pId = pOrder.Id;
                    }
                    else
                    {
                        strList.Add(Utils.ToString(o.Id));          //数据导出，可以导出电子订单等
                        pId = o.Id;
                    }
                    //通过父订单，找到全部订单
                    List<V_HK_Order_List> zOrder = _tEntityResponsity.Table.Where(p => p.State == 3 && p.kuaidiOrder == 1 && p.OrderRelevance == pId).ToList();
                    foreach (V_HK_Order_List z in zOrder)
                    {
                        strList.Add(Utils.ToString(z.Id));
                    }
                }
                tIds = strList.ToArray();
                #endregion 

                StringBuilder sql = new StringBuilder();
                try
                {
                    string allids = String.Join(",", tIds);
                    #region 根据条件拼接sql
                    sql.Append(@"SELECT ROW_NUMBER() over(order by OrderRelevance DESC,Id ASC ) rowNum
                        ,CASE WHEN Transtype=0 THEN '迁出' ELSE '借阅' END AS '业务类型'
                        ,OrderNo AS '订单编号'
                        ,CASE WHEN CONVERT(varchar(20),Committime,20)='1900-01-01 00:00:00' THEN '' ELSE CONVERT(varchar(20),Committime,20)  END AS '申请时间'
                        ,Uniqueno AS '唯一号'
                        ,uCname AS '姓名'
                        ,uCardId AS '身份证号'
                        ,Fname AS '所属企业'
                        ,CASE WHEN  Transtype=1 THEN 
                        (CASE WHEN (Originaldoc=1 )  THEN '集体户口卡原件'+CHAR(10) ELSE '' END)  
                        +(CASE WHEN (Firstcopy =1)  THEN '集体户口首页' +CHAR(10) 
                        +(select stuff((select ','+(Useage+CONVERT(nvarchar(10), Num) +'张'+CHAR(10)) FROM T_HK_HuKou_Num  where  Isdelete=0 AND BusinessId= o.BussinessId  FOR xml path ('')),1,1,''))
                         ELSE '' END )  
                        ELSE '迁出相关材料' END
                        AS '借阅材料及用途'
                        ,CASE o.State
	                        WHEN -9 THEN '后台取消' 
	                        WHEN -7 THEN '前台取消' 
	                        WHEN 1 THEN '未支付'
                            WHEN 2 THEN '已支付'
                            WHEN 3 THEN '已收款/待审核'
                            WHEN 4 THEN '发货中'
                            WHEN 5 THEN '快递已发'
                            WHEN 6 THEN '本人已签收'
                            WHEN 7 THEN '待归还'
                            WHEN 8 THEN 'myself已签收'
                            WHEN 9 THEN '退款完成'
                            WHEN 88 THEN '办理结束'
                            WHEN 95 THEN '待上传迁出证明'
                            WHEN 96 THEN '已提交迁出证明'
                            WHEN 97 THEN '迁出审核失败'
                            WHEN 98 THEN '迁出审核通过'
                            WHEN 99 THEN '借转迁办理结束'
                        END AS '订单状态'
                        ,CASE WHEN CONVERT(varchar(20),TradeTime,20)='1900-01-01 00:00:00' THEN '' ELSE CONVERT(varchar(20),TradeTime,20)  END AS '支付时间'
                        ,TradeName AS '支付方式'
                        ,OrderDeposit AS '借阅押金'
                        ,OrderAmount AS '快递费'
                        ,CASE o.PiaoState
	                        WHEN 1 THEN '是'
	                        WHEN 0 THEN '否'
	                        END  AS '是否开具发票'
                        ,CASE InvoiceTitleType when 1 THEN '个人'  when 2 THEN '公司' END  AS '发票类型'
                        ,InvoiceTitle AS '发票抬头'
                        ,InvoiceName AS '发票内容'
                        ,TaxpayerNum AS '纳税人识别号'
                        ,Letterpeople AS '收件人'
                        ,Pone AS 联系电话
                        ,(ProvinceName+CityName+AddrStr)  AS '收件人地址'
                        ,Email AS '邮箱'
                        ,Postcode AS '邮编'
                        ,KName AS '快递公司'
                        ,KNo AS '快递单号'
                        FROM dbo.V_HK_Order_List o   WHERE id>0
                        ");

                    sql.Append("  AND Id IN(" + allids + ")");
                    sql.Append("  ORDER BY OrderRelevance DESC,Id ASC ");
                    #endregion
                    T_Sys_ExportFiles newmodel = new T_Sys_ExportFiles();
                    newmodel.SetNullToDefalut();
                    newmodel.ParmsJson = sql.ToString();
                    newmodel.TypeName = "集体户口管理数据导出记录";
                    newmodel.Type = 201;
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
            }

            return result;
        }
        
        //集体户口快递导入
        public string kuidiDataIn(string FileNameOld,string path,T_Admin_Account account)
        {
            //文件路径
            string result = string.Empty;
            result = _ImportFile.InsertAndUploadSystemImportFile(FileNameOld, path, account);
            return result;
        }
        //批量退款
        public string tuiDataList(string[] tIds, T_Admin_Account account)
        {
            string result = string.Empty;
            string UpdateId = "";
            List<V_HK_Order_List> Order = _tEntityResponsity.Table.Where(p => p.OrderAmount > 0 && p.TradeStatus == 2 && p.BKDOperId <= 0 && (p.State == -9 || p.State == -7)).ToList().Where(o => tIds.Contains((o.Id).ToString())).ToList();
            if (Order == null || Order.Count == 0)
            {
                result = "没有要退款的订单！";
            }
            else {
                foreach (V_HK_Order_List v in Order)
                {
                    T_HK_Order orderU = _tTEntityResponsity.GetById(v.Id);
                    //如果押金没退，不修改状态。如果没有押金或者押金已退了，修改状态
                    if (v.OrderDeposit > 0 && v.BYJOperId > 0)
                    {
                        //押金已退
                        orderU.TradeStatus = 3;
                        //if (v.State != -9 || v.State != -7)
                        //{
                        //    orderU.Backno = DateTime.Now.ToString("yyyyMMdd" + orderU.Id.ToString("00000000"));
                        //    orderU.State = 9;
                        //    orderU.Statename = "已退款";
                        //}
                    }
                    else if (v.OrderDeposit <= 0 )
                    {
                        //没有押金
                        orderU.TradeStatus = 3;
                        //if (v.State != -9 || v.State != -7)
                        //{
                        //    orderU.Backno = DateTime.Now.ToString("yyyyMMdd" + orderU.Id.ToString("00000000"));
                        //    orderU.State = 9;
                        //    orderU.Statename = "已退款";
                        //}
                    }
                    
                    orderU.Updater = account.UserName;
                    orderU.UpdateTime = DateTime.Now;
                    orderU.BKDOperId = account.Id;
                    _tTEntityResponsity.Update(orderU);
                    UpdateId += Utils.ToString(orderU.Id) + ", ";
                }
            }
            _logger.Info(this.GetType(), "集体户口批量退款" + Environment.NewLine + " IDS:" + UpdateId + " result:" + result);
            return result;
        }
        //修改地址
        public string editKuaidiPara(T_HK_Order model,T_Admin_Account account)
        {
            string result = string.Empty;
            int idd = Utils.ToInt(model.Id);
            T_HK_Order o = _tTEntityResponsity.GetById(idd);
            int pId = 0;
            if (o.OrderRelevance != o.Id)//存在关联的父订单，找到父订单的ID
            {
                V_HK_Order_List pOrder = _tEntityResponsity.Table.Where(M => M.Id == o.OrderRelevance).ToList().First();
                pId = pOrder.Id;
            }
            else
            {
                pId = o.Id;
            }
            //通过父订单，找到全部订单
            List<V_HK_Order_List> zOrder = _tEntityResponsity.Table.Where(p => (p.State == 1 || p.State == 2 || p.State == 3) && p.kuaidiOrder == 1 && p.OrderRelevance == pId).ToList();
            foreach (V_HK_Order_List z in zOrder)
            {
                T_HK_Order orderU = _tTEntityResponsity.GetById(z.Id);
                orderU.Letterpeople = model.Letterpeople;
                orderU.Pone = model.Pone;
                orderU.Email = model.Email;
                orderU.Postcode = model.Postcode;

                orderU.ProvinceName = model.ProvinceName;
                orderU.CityName = model.CityName;
                orderU.AddrStr = model.AddrStr;

                orderU.Updater = account.UserName;
                orderU.UpdateTime = DateTime.Now;

                _tTEntityResponsity.Update(orderU);

                _logger.Info(this.GetType(), "集体户口后台修改地址" + Environment.NewLine + " ID:" + orderU.Id + " result:" + result);
            }

            return result;
        }
        //获取地址
        public T_HK_Order getKuaidiPara(string id)
        {
            T_HK_Order result = new T_HK_Order();
            int idd = Utils.ToInt(id);
            result = _tTEntityResponsity.GetById(idd);
            return result;
        }
        //获取省
        public List<V_CD_PROVINCE> getProvinceList()
        {
            List<V_CD_PROVINCE> result = new List<V_CD_PROVINCE>();
            int[] noProvs={3200,3400,3500,3600,4000,4100,4200,4300};
            result = _tPEntityResponsity.Table.Where(t => t.id > 0 && !noProvs.Contains(t.id)).ToList(); ;
            return result;
        }
        //获取根据省城市列表
        public List<V_CD_XIAN> getXianList(string PROVINCE)
        {
            List<V_CD_XIAN> result = new List<V_CD_XIAN>();
            result = _tXEntityResponsity.Table.Where(t => t.id > 0 && t.PROVINCE == PROVINCE).ToList(); ;
            return result;
        }
        //借阅图片
        public string[] getJYpic(string id)
        {
            string[] resStr=new string[4];
            int idd = Utils.ToInt(id);
            T_HK_Order Order = _tTEntityResponsity.GetById(idd);
            T_HK_Hukou_Lend lend = _tLendEntityResponsity.GetById(Order.BussinessId);
            if (lend != null && lend.Id>0)
            {

                resStr[0] =lend.FrontIDCard>0 ? GetPictrueForBase64(lend.FrontIDCard) : "";//身份证正面
                resStr[1] = lend.ReverseIDCard > 0 ? GetPictrueForBase64(lend.ReverseIDCard) : "";//身份证反面
                resStr[2] = lend.NewHKfirstPage > 0 ? GetPictrueForBase64(lend.NewHKfirstPage) : "";//新户口本首页
                resStr[3] = lend.NewHKSelfPage > 0 ? GetPictrueForBase64(lend.NewHKSelfPage) : "";//新户口本本人页
            }
            return resStr;
        }
        //迁出图片
        public string[] getQCpic(string id)
        {
            string[] resStr = new string[3];
            int idd = Utils.ToInt(id);
            T_HK_Order Order = _tTEntityResponsity.GetById(idd);
            T_HK_Hokou_Transfer lend = _tTranEntityResponsity.GetById(Order.BussinessId);
            if (lend != null && lend.Id > 0)
            {
                resStr[0] = lend.FrontIDCard>0 ? GetPictrueForBase64(lend.FrontIDCard):"";//身份证正面
                resStr[1] = lend.ReverseIDCard>0 ? GetPictrueForBase64(lend.ReverseIDCard):"";//身份证反面
                resStr[2] =lend.PermitCard>0 ? GetPictrueForBase64(lend.PermitCard):"";
            }
            return resStr;
        }
        //退款证明
        public string getTuipic(string id)
        {
            string resStr = string.Empty;
            int idd = Utils.ToInt(id);
            T_HK_Order Order = _tTEntityResponsity.GetById(idd);
            if (Order != null && Order.Id > 0)
            {
                resStr = Order.BackMoneyPic > 0 ? GetPictrueForBase64(Order.BackMoneyPic) : "";   //退款证明
            }
            return resStr;
        }
        //发快递
        public string setKuaidiOk(int id,string Kno, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                T_HK_Order f = this._tTEntityResponsity.GetById(id);
                if(f!=null && f.Id>0 && f.State==4)
                {
                    f.Kno = Kno;            //更新运单号
                    f.KName = "顺丰快递";
                    f.State = 5;            //已发货
                    f.Statename = "已发货";
                }

                f.UpdateTime = DateTime.Now;
                f.Updater = account.UserName;
                this._tTEntityResponsity.Update(f);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        //获取阿里云图片返回base64串
        public string GetPictrueForBase64(int fileId)
        {
            string resStr = string.Empty;
            T_Sys_ImportFiles pic = _t_Imp_ExportFiles.Table.Where(t => t.Id == fileId && t.State == 1).ToList().First();

            if (pic != null)
            {
                resStr = _picFile.GetBase64PictrueFromStream(pic.Path, pic.FileNameNew);//"myself-helo-oss",
            }
            return resStr;
        } 
    }
}

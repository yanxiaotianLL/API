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
namespace myselfFast.Fund.Services.HukousettledS
{
    public class HukousettledSpecdayService : BaseService<T_HK_Settled_Specday>, IHukousettledSpecdayService
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
        private IRepository<T_HK_Settled_Info> _settledEntity;
        

        public HukousettledSpecdayService(IRepository<T_HK_Settled_Specday> tEntityResponsity,
            IRepository<T_Fes_User> tfesUserEntity,
            IRepository<T_HK_Settled_FileItem> tfileItemEntity,
            IRepository<T_HK_Dictionary> tfileDicEntity,
            IRepository<T_Sys_File> tfileSysEntity,
            IRepository<T_Sys_IdCardInfo> tIdCardEntity,
            IRepository<T_Tb_dictionarylist> tdicEntity,
            IRepository<T_HK_Settled_Info> tsettledEntity,
            IFileDownService fileDownService,
            IFileUploadService fileUploadService,
            IDataProvider _dataProvider, IDbContext _dbContext, ILoggerProviderFactory iLoggerProviderFactory)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this._fesUserEntity = tfesUserEntity;
            this._fileItemEntity = tfileItemEntity;
            this._fileDicEntity = tfileDicEntity;
            this._fileSysEntity = tfileSysEntity;
            this._IdCardEntity = tIdCardEntity;
            this._dicEntity = tdicEntity;
            this._settledEntity=tsettledEntity;
            this._fileDownService = fileDownService;
            this._fileUploadService = fileUploadService;
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
        }
        //获取默认天数和时间段默认人数
        public dicShowday GetShowItem()
        {
            dicShowday showday = new dicShowday();
            List<T_HK_Dictionary> resultList = this._fileDicEntity.Table.Where(p => p.DictValue == "LocalShowDay" && p.Flag == 1).ToList();
            if (resultList == null || resultList.Count <= 0)
            {
                showday.LocalShowDay = "90";
            }
            else
            {
                T_HK_Dictionary result = resultList.First();
                showday.LocalShowDay = result.KeyValue;
            }
            List<T_HK_Dictionary> resultList1 = this._fileDicEntity.Table.Where(p => p.DictValue == "NonLocalShowDay" && p.Flag == 1).ToList();
            if (resultList1 == null || resultList1.Count <= 0)
            {
                showday.NonLocalShowDay = "90";
            }
            else
            {
                T_HK_Dictionary result1 = resultList1.First();
                showday.NonLocalShowDay = result1.KeyValue;
            }
            List<T_HK_Dictionary> resultList2 = this._fileDicEntity.Table.Where(p => p.DictValue == "DefaultShowDay" && p.Flag == 1).ToList();
            if (resultList2 == null || resultList2.Count <= 0)
            {
                showday.DefaultShowDay = "5";
            }
            else
            {
                T_HK_Dictionary result2 = resultList2.First();
                showday.DefaultShowDay = result2.KeyValue;
            }
            return showday;
        }
        //保存默认天数和时间段默认人数
        public string setShowItem(dicShowday Dshow, T_Admin_Account account)
        {
            string result = string.Empty;
            try
            {
                List<T_HK_Dictionary> dList1 = this._fileDicEntity.Table.Where(p => p.DictValue == "LocalShowDay" && p.Flag == 1).ToList();
                if (dList1 == null || dList1.Count <= 0)
                {
                    T_HK_Dictionary dcreat1 = new T_HK_Dictionary();
                    dcreat1.DictValue = "LocalShowDay";
                    dcreat1.DictName = "集体户口落户排期";
                    dcreat1.KeyValue = Dshow.LocalShowDay;
                    dcreat1.keyDesc = "本市户籍显示天数";
                    this._fileDicEntity.Insert(dcreat1);
                }
                else
                {
                    T_HK_Dictionary d1 = dList1.First();
                    d1.KeyValue = Dshow.LocalShowDay;
                    this._fileDicEntity.Update(d1);
                }

                List<T_HK_Dictionary> dList2 = this._fileDicEntity.Table.Where(p => p.DictValue == "NonLocalShowDay" && p.Flag == 1).ToList();
                if (dList2 == null || dList2.Count <= 0)
                {
                    T_HK_Dictionary dcreat2 = new T_HK_Dictionary();
                    dcreat2.DictValue = "NonLocalShowDay";
                    dcreat2.DictName = "集体户口落户排期";
                    dcreat2.KeyValue = Dshow.NonLocalShowDay;
                    dcreat2.keyDesc = "外地户籍显示天数";
                    this._fileDicEntity.Insert(dcreat2);
                }
                else
                {
                    T_HK_Dictionary d2 = dList2.First();
                    d2.KeyValue = Dshow.NonLocalShowDay;
                    this._fileDicEntity.Update(d2);
                }

                List<T_HK_Dictionary> dList3 = this._fileDicEntity.Table.Where(p => p.DictValue == "DefaultShowDay" && p.Flag == 1).ToList();
                if (dList3 == null || dList3.Count <= 0)
                {
                    T_HK_Dictionary dcreat3 = new T_HK_Dictionary();
                    dcreat3.DictValue = "NonLocalShowDay";
                    dcreat3.DictName = "集体户口落户排期";
                    dcreat3.KeyValue = Dshow.DefaultShowDay;
                    dcreat3.keyDesc = "默认每天预约人数";
                    this._fileDicEntity.Insert(dcreat3);
                }
                else
                {
                    T_HK_Dictionary d3 = dList3.First();
                    d3.KeyValue = Dshow.DefaultShowDay;
                    this._fileDicEntity.Update(d3);
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        //获取每一天的状态type（0默认，1休息日，2特殊日，21可约，22约满） 以及信息（每个时间段 总人数，已经约的人数，剩余人数）
        public List<dayshowType> GetDayshowlist()
        {
            List<dayshowType> result = new List<dayshowType>();

            DateTime dNow =DateTime.Now.Date;                                           //当前日期
            DateTime startDate = Utils.ToDateTime(Utils.ToString(dNow.Year) + "-" + Utils.ToString(dNow.Month) + "-" + "01");       //当前月的1号
            //截止日期
            dicShowday dic = GetShowItem();
            int endDay = Utils.ToInt(dic.LocalShowDay) > Utils.ToInt(dic.NonLocalShowDay) ? Utils.ToInt(dic.LocalShowDay) : Utils.ToInt(dic.NonLocalShowDay);
            DateTime endDate = dNow.AddDays(endDay);
            
            #region 起始日期到当前日期 状态为默认值0，没有样式
            
            for (var i = 0; ; i++)
            {
                DateTime tmpDate = startDate.AddDays(i);
                dayshowType dType = new dayshowType();
                if (DateTime.Compare(tmpDate, dNow) <= 0)
                {
                    dType.dangtian = tmpDate;
                    dType.Type = "0";
                    dType.AnumALL = 0;// getnumALL(tmpDate, 1);
                    dType.AnumNow = 0;// getnumNow(tmpDate, 1);
                    dType.AnumYu = 0;// dType.AnumALL - dType.AnumNow;
                    dType.BnumALL = 0;//  getnumALL(tmpDate, 2);
                    dType.BnumNow = 0;// getnumNow(tmpDate, 2);
                    dType.BnumYu = 0;// dType.BnumALL - dType.BnumNow;
                    dType.CnumALL = 0;// getnumALL(tmpDate, 3);
                    dType.CnumNow = 0;// getnumNow(tmpDate, 3);
                    dType.CnumYu = 0;// dType.CnumALL - dType.CnumNow;
                    dType.DnumALL = 0;// getnumALL(tmpDate, 4);
                    dType.DnumNow = 0;// getnumNow(tmpDate, 4);
                    dType.DnumYu = 0;// dType.DnumALL - dType.DnumNow;
                    dType.EnumALL = 0;// getnumALL(tmpDate, 5);
                    dType.EnumNow = 0;// getnumNow(tmpDate, 5);
                    dType.EnumYu = 0;// dType.EnumALL - dType.EnumNow;
                    result.Add(dType);
                        
                }
                else
                {
                    break;
                }
            }

            #endregion

            #region 当天到 截止日期
            List<P_HK_getNumNow> getnumNow = ExecGetnumNow(endDay);           //当前已经预约的人数
             List<P_HK_getNumALL> getnumALL = ExecGetnumALL(endDay);          //总
            for (var i = 1; ; i++)
            {
                DateTime tmpDate = dNow.AddDays(i);
                dayshowType dType = new dayshowType();
                if (DateTime.Compare(tmpDate, endDate) <= 0)
                {
                    int numYu=0;
                    dType.dangtian = tmpDate;

                    dType.AnumALL = getnumALL[i].A;
                    dType.BnumALL = getnumALL[i].B;
                    dType.CnumALL = getnumALL[i].C;
                    dType.DnumALL = getnumALL[i].D;
                    dType.EnumALL = getnumALL[i].E;

                    dType.AnumNow = getnumNow[i].A;
                    dType.BnumNow = getnumNow[i].B;
                    dType.CnumNow = getnumNow[i].C;
                    dType.DnumNow = getnumNow[i].D;
                    dType.EnumNow = getnumNow[i].E;

                    dType.AnumYu = dType.AnumALL - dType.AnumNow;
                    dType.AnumYu=dType.AnumYu<0?0:dType.AnumYu;

                    dType.BnumYu = dType.BnumALL - dType.BnumNow;
                    dType.BnumYu=dType.AnumYu<0?0:dType.BnumYu;

                    dType.CnumYu = dType.CnumALL - dType.CnumNow;
                    dType.CnumYu=dType.AnumYu<0?0:dType.CnumYu;

                    dType.DnumYu = dType.DnumALL - dType.DnumNow;
                    dType.DnumYu=dType.AnumYu<0?0:dType.DnumYu;

                    dType.EnumYu = dType.EnumALL - dType.EnumNow;
                    dType.EnumYu=dType.AnumYu<0?0:dType.EnumYu;
                    numYu=(dType.AnumYu+dType.BnumYu+dType.CnumYu+dType.DnumYu+dType.EnumYu);

                    if (getnumALL[i].SpecType>0) 
                    {
                        //有排期
                        dType.Type = Utils.ToString(getnumALL[i].SpecType);   //1休息日；2特殊日
                        if(dType.Type=="2")
                        {
                            dType.Type=numYu>0?"22":"23";
                        }
                    }
                    else
                    {
                        //没有排期(默认)
                        if (Convert.ToInt16(tmpDate.DayOfWeek) != 0 && Convert.ToInt16(tmpDate.DayOfWeek) != 6)
                        {
                            dType.Type = numYu > 0 ? "22" : "23"; 
                        }
                        else
                        {
                            dType.Type = "1";
                        }

                    }
                    result.Add(dType);
                }
                else
                {
                    break;
                }
            }

            #endregion

            return result;
        }


        //获取  每个时间段 已经预约的人数   --只是用于一条
        private int  getnumNow(DateTime nowDay, int TimeType)
        {
            //shijianduan sjd = getShijianduan(TimeType);
            //string tmeStart = sjd.tmeStart ;
            //string tmeEnd = sjd.tmeEnd;
            //DateTime dayStar = Utils.ToDateTime(Utils.ToString(nowDay) + tmeStart);
            //DateTime dayEed = Utils.ToDateTime(Utils.ToString(nowDay) + tmeEnd);

            //int res ;
            //List<T_HK_Settled_Info> s1 = _settledEntity.Table.Where(p => p.ChekcDate >= dayStar && p.ChekcDate <= dayEed && p.State == 8).ToList();
            //if (s1 != null && s1.Count > 0)
            //{
            //    res = s1.Count; 
            //}
            //else
            //{
            //    res = 0;
            //}
            //return res;
            return 0;
        }


        //获取  每个时间段 已经预约的人数   --适用于多条
        private List<P_HK_getNumNow> ExecGetnumNow(int endDay)
        {
            List<P_HK_getNumNow> result = _dbContext.SqlQuery<P_HK_getNumNow>("EXEC P_HK_getNumNow @endDay={0}", endDay).ToList();
            return result;
        }

        ///获取  每个时间段 总人数  ---适用于多条
        private List<P_HK_getNumALL> ExecGetnumALL(int endDay)
        {
            DateTime dNow =DateTime.Now.Date;
            List<P_HK_getNumALL> result = new List<P_HK_getNumALL>();
            #region 读取默认值
            List<T_HK_Dictionary> DefaultShowDayList = this._fileDicEntity.Table.Where(p => p.DictValue == "DefaultShowDay" && p.Flag == 1).ToList();
            T_HK_Dictionary DefaultShowDay = new T_HK_Dictionary();
            if (DefaultShowDayList != null && DefaultShowDayList.Count > 0)
            {
                DefaultShowDay = DefaultShowDayList.First();
            }
            if (DefaultShowDay == null || DefaultShowDay.Id <= 0)
            {
                DefaultShowDay.KeyValue = "5";
            }
            #endregion 
            #region 判断是否有特殊排期
 
            //排期表
            string nowDayStr = dNow.ToString("yyyy") + dNow.ToString("MM") + dNow.ToString("dd");
            DateTime endDate = dNow.AddDays(endDay);
            string endDayStr = endDate.ToString("yyyy") + endDate.ToString("MM") + endDate.ToString("dd");
            int nowDayint = Utils.ToInt(nowDayStr);
            int endDayint = Utils.ToInt(endDayStr);
            List<T_HK_Settled_Specday> spec = this._tEntityResponsity.Table.Where(p => p.Date >= nowDayint && p.Date <= endDayint && p.IsUse == 1).ToList();
            
            for (int j = 0; j <= endDay; j++)
            {
                P_HK_getNumALL res = new P_HK_getNumALL();
                DateTime d = dNow.AddDays(j);
                string dStr = d.ToString("yyyy") + endDate.ToString("MM") + endDate.ToString("dd");
                int dInt = Utils.ToInt(dStr);

                foreach (T_HK_Settled_Specday s in spec)
                {
                    if (s.Date == dInt)
                    {
                        res.SpecType = s.SpecType;
                        //非默认值
                        res.A = Utils.ToInt(s.A);
                        res.B = Utils.ToInt(s.B);
                        res.C = Utils.ToInt(s.C);
                        res.D = Utils.ToInt(s.D);
                        res.E = Utils.ToInt(s.E);
                    }
                }

                if (res.SpecType <= 0)
                {
                    //默认值
                    res.A = Utils.ToInt(DefaultShowDay.KeyValue);
                    res.B = res.A;
                    res.C = res.A;
                    res.D = res.A;
                    res.E = res.A;
                    res.SpecType = 0;
                }
                result.Add(res);
            }
            
            #endregion
            return result;
        }

        //时间段 默认值
        public shijianduan getShijianduan(int TimeType)
        {
            shijianduan res = new shijianduan();
            string tmeStart = "";
            string tmeEnd = "";
            switch (TimeType)
            {
                case 1:
                    tmeStart = " 09:00:00";
                    tmeEnd = " 09:59:59";
                    break;
                case 2:
                    tmeStart = " 10:00:00";
                    tmeEnd = " 10:59:59";
                    break;
                case 3:
                    tmeStart = " 13:30:00";
                    tmeEnd = " 14:29:59";
                    break;
                case 4:
                    tmeStart = " 14:30:00";
                    tmeEnd = " 15:29:59";
                    break;
                case 5:
                    tmeStart = " 15:30:00";
                    tmeEnd = " 16:29:59";
                    break;

            }
            res.tmeStart = tmeStart;
            res.tmeEnd = tmeEnd;
            return res;
        }
        //设置成休息日
        public string setXiuxi(DateTime dTime, T_Admin_Account account)
        {
            string result = string.Empty;

            try
            {
                string DateString = dTime.ToString("yyyy") + dTime.ToString("MM") + dTime.ToString("dd");
                int Date = Utils.ToInt(DateString);
                List<T_HK_Settled_Specday> fList = this._tEntityResponsity.Table.Where(t => t.Date == Date && t.IsUse==1).ToList();
                if (fList != null && fList.Count > 0 && Date > 0)
                {
                    T_HK_Settled_Specday f = fList.First();
                    f.SpecType = 1;
                    this._tEntityResponsity.Update(f);
                }
                else if (Date>0) 
                {
                    T_HK_Settled_Specday f =new T_HK_Settled_Specday();
                    f.Date = Date;
                    f.SpecType = 1;
                    f.IsUse = 1;
                    dicShowday dic=this.GetShowItem();
                    f.A = Utils.ToInt(dic.DefaultShowDay);
                    f.B = Utils.ToInt(dic.DefaultShowDay);
                    f.C = Utils.ToInt(dic.DefaultShowDay);
                    f.D = Utils.ToInt(dic.DefaultShowDay);
                    f.E = Utils.ToInt(dic.DefaultShowDay);
                    this._tEntityResponsity.Insert(f);
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        //设置成工作日
        public string setGongzuo(DateTime dTime, T_Admin_Account account)
        {
            string result = string.Empty;

            try
            {
                string DateString = dTime.ToString("yyyy") + dTime.ToString("MM") + dTime.ToString("dd");
                int Date = Utils.ToInt(DateString);
                List<T_HK_Settled_Specday> fList = this._tEntityResponsity.Table.Where(t => t.Date == Date && t.IsUse == 1).ToList();
                if (fList != null && fList.Count > 0 && Date > 0)
                {
                    T_HK_Settled_Specday f = fList.First();
                    f.SpecType = 2;
                    this._tEntityResponsity.Update(f);
                }
                else if (Date > 0) 
                {
                    T_HK_Settled_Specday f = new T_HK_Settled_Specday();
                    f.Date = Date;
                    f.SpecType = 2;
                    f.IsUse = 1;
                    dicShowday dic = this.GetShowItem();
                    f.A = Utils.ToInt(dic.DefaultShowDay);
                    f.B = Utils.ToInt(dic.DefaultShowDay);
                    f.C = Utils.ToInt(dic.DefaultShowDay);
                    f.D = Utils.ToInt(dic.DefaultShowDay);
                    f.E = Utils.ToInt(dic.DefaultShowDay);
                    this._tEntityResponsity.Insert(f);
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
        //设置默认天数
        public string setshowdaynum(DateTime dTime,int A,int B,int C,int D,int E, T_Admin_Account account)
        {
            string result = string.Empty;

            try
            {
                string DateString = dTime.ToString("yyyy") + dTime.ToString("MM") + dTime.ToString("dd");
                int Date = Utils.ToInt(DateString);
                List<T_HK_Settled_Specday> fList = this._tEntityResponsity.Table.Where(t => t.Date == Date && t.IsUse == 1).ToList();
                if (fList != null && fList.Count > 0 && Date > 0)
                {
                    T_HK_Settled_Specday f = fList.First();
                    f.A = A;
                    f.B = B;
                    f.C = C;
                    f.D = D;
                    f.E = E;
                    this._tEntityResponsity.Update(f);
                }
                else if (Date > 0)
                {
                    T_HK_Settled_Specday f = new T_HK_Settled_Specday();
                    f.Date = Date;
                    f.SpecType = 2;
                    f.IsUse = 1;
                    f.A = A;
                    f.B = B;
                    f.C = C;
                    f.D = D;
                    f.E = E;
                    this._tEntityResponsity.Insert(f);
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
    }
}


 
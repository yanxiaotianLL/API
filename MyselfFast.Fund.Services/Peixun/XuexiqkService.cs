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
using myselfFast.Fund.Core.Domain.Peixun;
using myselfFast.Fund.Services.DTO.Request.Peixun;
using myselfFast.Fund.Core.Domain.ExportImport;
using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Services.Admin;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Component.Logging;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using myselfFast.Fund.Services.DTO.Response.Peixun;
using NewSystem.SDK.Interfaces;
using NewSystem.SDK.Factory;
using NewSystem.SDK.Entities.Request;
using NewSystem.SDK.Entities.Response;

namespace myselfFast.Fund.Services.Peixun
{
    public class XuexiqkService : BaseService<T_Trn_StuRec>, IXuexiqkService
    {
        private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;
        private IRepository<T_Trn_Label> _tTrnLabelEntity;
        private IRepository<T_Sys_ExportFiles> _t_Sys_ExportFiles;
        private readonly IEmployeeHttpsService iEmployee = NewSystemFactory.GetEmployeeHttpsService(); //调用SDK文件上传接口

        public XuexiqkService(IRepository<T_Trn_StuRec> tEntityResponsity,
            IRepository<T_Trn_Label> tTrnLabelEntity,
            IRepository<T_Sys_ExportFiles> t_Sys_ExportFiles,
            IDataProvider _dataProvider, IDbContext _dbContext, ILoggerProviderFactory iLoggerProviderFactory)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
            this._tTrnLabelEntity = tTrnLabelEntity;
            this._t_Sys_ExportFiles = t_Sys_ExportFiles;
        }
        //获取学习情况列表
        public JqGridResult<ResPeixunxxqkResponseModel> GetXuexiqkList(SelectXuexiqkRequestModel model, T_Admin_Account account, int rows, int page)
        {
            var begintime= Utils.ToDateTime(model.BeginTimeStart); 
            var endtime = Utils.ToDateTime(model.BeginTimeEnd);

            if (!string.IsNullOrEmpty(model.BeginTimeEnd))
            {
                endtime = endtime.AddDays(1);
            }

            string sqlText = string.Format("EXEC P_PeixunXXQK_Info @id={0}", 0);
            IPagedList<ResPeixunxxqkResponseModel> pagedList = new PagedList<ResPeixunxxqkResponseModel>(
                _dbContext.SqlQuery<ResPeixunxxqkResponseModel>(sqlText, true)
                //查询条件
                .WhereIf(t => t.Id == model.Id, model.Id > 0)
                .WhereIf(t => t.Name.Contains(model.Name), !string.IsNullOrEmpty(model.Name)) //课程名称
                .WhereIf(t => t.busiCustName.Contains(model.busiCustName), !string.IsNullOrEmpty(model.busiCustName) && model.busiCustName != "undefined") //公司
                .WhereIf(t => t.Yewubu == model.Yewubu, !string.IsNullOrEmpty(model.Yewubu) && model.Yewubu != "undefined")
                .WhereIf(t => t.IsFinish == model.IsFinish, model.IsFinish > -1)
                .WhereIf(t => t.BeginTime >= begintime, !string.IsNullOrEmpty(model.BeginTimeStart)&& model.BeginTimeStart != "undefined")
                .WhereIf(t => t.BeginTime <= endtime, !string.IsNullOrEmpty(model.BeginTimeEnd) && model.BeginTimeEnd != "undefined")
                , page, rows);

            foreach (ResPeixunxxqkResponseModel vRes in pagedList)
            {
                //解密
                vRes.Cname = Encryption.IsEncrypted(vRes.Cname) ? Encryption.Decrypt(vRes.Cname) : "";
                vRes.FesUserCardId = Encryption.IsEncrypted(vRes.FesUserCardId) ? Encryption.Decrypt(vRes.FesUserCardId) : "";
            }
            return JqGridResult<ResPeixunxxqkResponseModel>.Build(pagedList);
        }

        //学习情况导出
        public string yuangongDataOut(string[] tIds, T_Admin_Account account)
        {
            string result = string.Empty;
            if (true)
            {
                StringBuilder sql = new StringBuilder();
                try
                {
                    string allids = String.Join(",", tIds);
                    #region 根据条件拼接sql
                    sql.Append(@"SELECT 
                         Stu_rec_coz.PersonName,
                         Stu_rec_coz.CardType,
                         Stu_rec_coz.PersonId,
                         Stu_rec_coz.Name,
                         Stu_rec_coz.Credit,
                         Stu_rec_coz.SumMin,
                         Stu_rec_coz.FinishPct,
                         usr.busiCustName,
                         ext.Yewubu,
                         usr.Hno,
                         Stu_rec_coz.BeginTime
                         FROM (SELECT
                         rec.Id, 
                         rec.FesId,
                         stu.PersonName,
                         stu.CardType,
                         stu.PersonId,
                         coz.Name,
                         coz.Credit,
                         coz.SumMin,
                         rec.FinishPct,
                         coz.BeginTime
                         FROM dbo.T_Trn_StuRec rec                     
                         LEFT JOIN  dbo.T_Trn_Stu stu on stu.FesId=rec.FesId
                         LEFT JOIN  dbo.T_Trn_CozInfo coz ON coz.Id =rec.CozInfoId AND coz.IsOpen=1
                         ) Stu_rec_coz ,dbo.T_Fes_User usr,dbo.T_Fes_User_Ext ext
                         WHERE usr.id=Stu_rec_coz.FesId AND ext.Fesid=Stu_rec_coz.FesId AND usr.IsNewSysSyn=1");
                    sql.Append("  AND Stu_rec_coz.PersonId IS NOT NULL");
                    sql.Append("  AND Stu_rec_coz.Name IS NOT NULL");
                    sql.Append("  ORDER BY Stu_rec_coz.Id,usr.Id");
                    #endregion
                    T_Sys_ExportFiles newmodel = new T_Sys_ExportFiles();
                    newmodel.SetNullToDefalut();
                    newmodel.ParmsJson = sql.ToString();
                    newmodel.TypeName = "视频培训课程导出";
                    newmodel.Type = 401;
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
            _logger.Info(this.GetType(), "视频培训课程导出" + Environment.NewLine + " result:" + result);
            return result;
        }



        //判断员工是否有导出资格
        public string  getPerson(string Hno)
        {
            string res = string.Empty;
            if (!GetEmpEffectOrderInfo(Hno))
            {
                res += "没有委派</br>";
            }
            if (!GetEmpLconInfos(Hno))
            {
                res += "没有有效合同</br>";
            }
            if (!getEmpSendStatistics(Hno))
            {
                res += "不在职</br>";
            }
            return res;

        }
        //调获取最新雇员有效订接口，看是否【已委派】
        private bool GetEmpEffectOrderInfo(string Hno)
        {
            try
            {
                var newSysOrderRes = iEmployee.GetEmpEffectOrderInfo(new NewEmpEffectOrderInfoRequestModel()
                {
                    uniqNo = Hno,
                    orderSta = "3",
                });
                if (newSysOrderRes.code == "0" && newSysOrderRes.successResult.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                _logger.Error("【培训课程学习情况导出-获取雇员派出统计信息】过程发生错误", ex);
                return false;
            }
            return false;
        }
        //获取雇员劳动合同信息列表，查询是否有有效合同
        private bool GetEmpLconInfos(string Hno)
        {
            try
            {
                var newSysLconRes = iEmployee.GetEmpLconInfos(new NewEmpLconInfosRequestModel()
                {
                    uniqNo = Hno,
                });
                if (newSysLconRes.code == "0" && newSysLconRes.successResult != null && newSysLconRes.successResult.totalCount > 0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                _logger.Error("【培训课程学习情况导出-获取雇员派出统计信息】过程发生错误", ex);
                return false;
            }
            return false;
        }
        /// <summary>
        /// 获取雇员派出统计信息（判断是否在职）员工派出状态（1：预派、2：在职（已委派，已办撤离但撤离日期大于当前日期），3：撤离（已办撤离但撤离日期小于当前日期））
        /// </summary>
        private bool getEmpSendStatistics(string uniqNo)
        {
            try
            {
                EmpSendStatisticsRequestModelHttps model = new EmpSendStatisticsRequestModelHttps();
                model.uniqNo = uniqNo;
                model.type = "2";
                EmpSendStatisticsResponseModelHttps ngeri = iEmployee.GetEmpSendStatistics(model);
                if (ngeri.successResult.empStatus == 2)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                _logger.Error("【培训课程学习情况导出-获取雇员派出统计信息】过程发生错误", ex);
                return false;
            }
            return false;
        }
 
    }
}

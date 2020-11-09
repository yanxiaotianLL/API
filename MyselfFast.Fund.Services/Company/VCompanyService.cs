using myselfFast.ZFBZ.Data.ViewEntity;
using System;
using System.Linq;
using myselfFast.Fund.Services;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core;
namespace myselfFast.ZFBZ.Services.Company
{
    public class VCompanyService : BaseService<V_Company>, IVCompanyService
    {
        public VCompanyService(IRepository<V_Company> tEntityResponsity,
           IDataProvider _dataProvider,
           IDbContext _dbContext)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
        }
        /// <summary>
        /// 显示企业信息
        /// </summary>
        /// <param name="companyname"></param>
        /// <param name="starttime"></param>
        /// <param name="endtime"></param>
        /// <param name="state"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public JqGridResult<V_Company> getCompanyList(string companyname, string starttime, string endtime, string state, int pageIndex, int pageSize)
        {
            _dbContext.Set<V_Company>().Where(t => t.AppointId == 1);
            var stime = string.IsNullOrEmpty(starttime) ? DateTime.Now : Convert.ToDateTime(starttime);
            var dtime = string.IsNullOrEmpty(endtime) ? DateTime.Now : Convert.ToDateTime(endtime);
            var query = _dbContext.Set<V_Company>().Where(t => t.IsDelete == false)
                .WhereIf(t => t.CompanyName.Contains(companyname), !string.IsNullOrEmpty(companyname))
                .WhereIf(t => t.AppointTime >= stime, !string.IsNullOrEmpty(starttime))
                .WhereIf(t => t.AppointTime < dtime, !string.IsNullOrEmpty(endtime));
            PagedList<V_Company> page = new PagedList<V_Company>(query, pageIndex, pageSize);
            var jqlist = JqGridResult<V_Company>.Build(page);
            return jqlist;

        }
    }
}

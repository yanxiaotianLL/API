using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services;
using myselfFast.ZFBZ.Core.Domain.Company;
using System.Collections.Generic;
using System.Linq;

namespace myselfFast.ZFBZ.Services.Company
{
    public class CompanySubsidiesService : BaseService<T_Company_Subsidies>, ICompanySubsidiesService
    {
        public CompanySubsidiesService(IRepository<T_Company_Subsidies> tEntityResponsity,
           IDataProvider _dataProvider,
           IDbContext _dbContext)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
        }
        /// <summary>
        /// 根据预约类型id和企业id查询详情
        /// </summary>
        /// <param name="appointid"></param>
        /// <param name="companyid"></param>
        /// <returns></returns>
        public List<T_Company_Subsidies> getDetail(string appointids, int companyid,string sign)
        {
            var ids=appointids.Split(',').Where(t=>!string.IsNullOrWhiteSpace(t)).Select(t=>int.Parse(t)).ToList();
            var query = this._tEntityResponsity.Table.Where(t => t.AppointSign==sign&&t.IsDelete == false && t.CompanyId == companyid && ids.Contains(t.SubsidyTypes)).ToList();
            return query;
        }
        public List<T_Company_Subsidies> getList(List<string> appoingSign)
        {
            var query = this._tEntityResponsity.Table.Where(t => appoingSign.Contains(t.AppointSign)).ToList();
            return query;
        }

    }
}

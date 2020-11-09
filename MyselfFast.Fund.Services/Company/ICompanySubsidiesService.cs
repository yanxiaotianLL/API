using myselfFast.Fund.Services;
using myselfFast.ZFBZ.Core.Domain.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.ZFBZ.Services.Company
{
    public interface ICompanySubsidiesService : IBaseService<T_Company_Subsidies>
    {
        /// <summary>
        /// 根据预约类型id和企业id查询详情
        /// </summary>
        /// <param name="appointid"></param>
        /// <param name="companyid"></param>
        /// <returns></returns>
        List<T_Company_Subsidies> getDetail(string appointids, int companyid, string sign);
        List<T_Company_Subsidies> getList(List<string> appoingSign);
    }
}

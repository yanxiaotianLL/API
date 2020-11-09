using myselfFast.Fund.Services;
using myselfFast.Fund.Services.domain;
using myselfFast.ZFBZ.Core;
using myselfFast.ZFBZ.Core.Domain.Company;
using myselfFast.ZFBZ.Data.ViewEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.ZFBZ.Services.Company
{
    public interface ICompanyService : IBaseService<T_Company>
    {
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
        JqGridResult<V_Company> getCompanyList(string companyname, string starttime, string endtime, string state, int pageIndex, int pageSize);
            /// <summary>
        /// 
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        T_Company InsertCompany(T_Company company, out string msg);
             /// <summary>
        /// 总访问数
        /// </summary>
        /// <returns></returns>
       int allCount();
    }
}

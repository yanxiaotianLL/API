using myselfFast.Fund.Services;
using myselfFast.Fund.Services.domain;
using myselfFast.ZFBZ.Core;
using myselfFast.ZFBZ.Data.ViewEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.ZFBZ.Services.Company
{
    public interface IVCompanyService : IBaseService<V_Company>
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
    }
}

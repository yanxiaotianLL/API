using myselfFast.Fund.Core.Domain.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    public interface IAdminAcountRoleService : IBaseService<T_Admin_AcountRole>
    {
        void insertAcountRole(T_Admin_AcountRole acountRole);

        /// <summary>
        /// 获取用户权限
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        List<string> GetAccountAuth(int accountId);

        void deleteAccountAuth(int accountId);
    }
}

using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Services.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    public interface IAdminRoleService : IBaseService<T_Admin_Role>
    {
        string AddRole(T_Admin_Role role, T_Admin_Account account, List<int> roleDataIds);
        string DeleteRoleById(int id);
        T_Admin_Role GetRoleById(int id);
        string EditRole(T_Admin_Role role, T_Admin_Account account, List<int> roleDataIds);
        JqGridResult<T_Admin_Role> GetRoleList(string roleName, int page, int rows);
        string Auth(List<int> menuIds, int roleId, List<int> menuDataIds, T_Admin_Account account);
    }
}

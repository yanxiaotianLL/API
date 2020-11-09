using myselfFast.Fund.Core.Domain.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    public interface IAdminRolePrivilegeService : IBaseService<T_Admin_RolePrivilege>
    {
        List<T_Admin_RolePrivilege> GetAdminRolePrivilege(int roleId);

        List<T_Admin_RolePrivilege> GetAdminRolePrivilege(int roleId, int menuId);
    }
}

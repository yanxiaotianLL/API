using myselfFast.Fund.Core.Domain.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    public interface IAdminRoleDataRolePrivilegeService : IBaseService<T_Admin_RoleData_RolePrivilege>
    {
        void addRoleDataRolePrivilege(T_Admin_RoleData_RolePrivilege rolePrivilege);

        List<T_Admin_RoleData_RolePrivilege> getRolePrivilege(T_Admin_RoleData_RolePrivilege rolePrivilege);

        List<T_Admin_RoleData> getRoleData(int roleId);
    }
}

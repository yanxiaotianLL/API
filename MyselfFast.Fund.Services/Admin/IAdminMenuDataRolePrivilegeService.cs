using myselfFast.Fund.Core.Domain.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    public interface IAdminMenuDataRolePrivilegeService : IBaseService<T_Admin_MenuData_RolePrivilege>
    {
        List<T_Admin_MenuData_RolePrivilege> GetMenuDataRolePrivilegeByIds(List<int> ids);
        List<T_Admin_MenuData_RolePrivilege> GetMenuDataRolePrivilege(int roleRrivelegeId, int menuDataId);

        List<T_Admin_MenuData> GetMenuDataByMenuId(int[] roleIds,int menuId);
        
    }
}

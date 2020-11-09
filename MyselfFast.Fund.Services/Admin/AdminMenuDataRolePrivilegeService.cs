using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core;
using myselfFast.Fund.Services.domain;

namespace myselfFast.Fund.Services.Admin
{
    public class AdminMenuDataRolePrivilegeService : BaseService<T_Admin_MenuData_RolePrivilege>, IAdminMenuDataRolePrivilegeService
    {
        public AdminMenuDataRolePrivilegeService(IRepository<T_Admin_MenuData_RolePrivilege> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {

        }

        public List<T_Admin_MenuData_RolePrivilege> GetMenuDataRolePrivilegeByIds(List<int> ids)
        {
            if (ids == null || ids.Count == 0) return null;
            return this._tEntityResponsity.Table.Where(p => ids.Contains(p.RolePrivilegeID)).Where(p => p.IsDelete == false).ToList();
        }


        public List<T_Admin_MenuData_RolePrivilege> GetMenuDataRolePrivilege(int roleRrivelegeId, int menuDataId)
        {
            return this._tEntityResponsity.Table.WhereIf(p => p.RolePrivilegeID == roleRrivelegeId, roleRrivelegeId > 0)
                .WhereIf(p => p.MenuDataID == menuDataId, menuDataId > 0).Where(p => p.IsDelete == false).ToList();
        }


        public List<T_Admin_MenuData> GetMenuDataByMenuId(int[] roleIds, int menuId)
        {
            var rolePrivileges = _dbContext.Set<T_Admin_RolePrivilege>().Where(w=>roleIds.Contains(w.RoleID) && w.MenuID == menuId && w.IsDelete == false).ToList();
            if(rolePrivileges == null || rolePrivileges.Count <= 0){
                return null;
            }
            var  rolePrivilegeIds = rolePrivileges.Select(s=>s.Id).ToArray();
            var admin_MenuData_RolePrivileges = _tEntityResponsity.Table.Where(w => rolePrivilegeIds.Contains(w.RolePrivilegeID) && w.IsDelete ==false).ToList();
            if (admin_MenuData_RolePrivileges == null || admin_MenuData_RolePrivileges.Count <= 0)
            {
                return null;
            }
            var menuDataIds = admin_MenuData_RolePrivileges.Select(s => s.MenuDataID).ToArray();
            return _dbContext.Set<T_Admin_MenuData>().Where(w => menuDataIds.Contains(w.Id) && w.IsDelete == false).ToList();
        }
    }
}

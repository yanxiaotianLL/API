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
    public class AdminRoleDataRolePrivilegeService : BaseService<T_Admin_RoleData_RolePrivilege>, IAdminRoleDataRolePrivilegeService
    {
        public AdminRoleDataRolePrivilegeService(IRepository<T_Admin_RoleData_RolePrivilege> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {

        }

        public void addRoleDataRolePrivilege(T_Admin_RoleData_RolePrivilege rolePrivilege)
        {
            this.AddEntity(rolePrivilege);
        }


        public List<T_Admin_RoleData_RolePrivilege> getRolePrivilege(T_Admin_RoleData_RolePrivilege rolePrivilege)
        {
            List<T_Admin_RoleData_RolePrivilege> result = this._tEntityResponsity.Table.WhereIf(p => p.RoleDataID == rolePrivilege.RoleDataID, rolePrivilege.RoleDataID > 0)
                .WhereIf(p => p.RoleID == rolePrivilege.RoleID, rolePrivilege.RoleID > 0).Where(p => p.IsDelete == false).ToList();
            return result;
        }


        public List<T_Admin_RoleData> getRoleData(int roleId)
        {
            var rolePrivileges = this._tEntityResponsity.Table.Where(w => w.RoleID == roleId && w.IsDelete == false).ToList();
            if (rolePrivileges != null && rolePrivileges.Count >0) {
                var roleDataIds = rolePrivileges.Select(s=>s.RoleDataID).ToArray();
                return _dbContext.Set<T_Admin_RoleData>().Where(w => roleDataIds.Contains(w.Id) && w.IsDelete == false).ToList();
            }
            return null;
        }
    }
}

using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    public class AdminRolePrivilegeService : BaseService<T_Admin_RolePrivilege>, IAdminRolePrivilegeService
    {
        public AdminRolePrivilegeService(IRepository<T_Admin_RolePrivilege> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {

        }

        public List<T_Admin_RolePrivilege> GetAdminRolePrivilege(int roleId)
        {
            if (roleId <= 0)
            {
                return null;
            }
            return this._tEntityResponsity.Table.Where(p => p.RoleID == roleId).Where(p => p.IsDelete == false).ToList();
        }


        public List<T_Admin_RolePrivilege> GetAdminRolePrivilege(int roleId, int menuId)
        {
            if (roleId <= 0 || menuId <= 0)
            {
                return null;
            }
            return this._tEntityResponsity.Table.Where(p => p.RoleID == roleId).Where(p=>p.MenuID == menuId).Where(p => p.IsDelete == false).ToList();
        }
    }
}

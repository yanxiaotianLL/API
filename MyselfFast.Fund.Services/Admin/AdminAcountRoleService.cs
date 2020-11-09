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
    public class AdminAcountRoleService : BaseService<T_Admin_AcountRole>, IAdminAcountRoleService
    {
        private IAdminRoleService iAdminRoleService;
        public AdminAcountRoleService(IRepository<T_Admin_AcountRole> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext,
            IAdminRoleService iAdminRoleService)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.iAdminRoleService = iAdminRoleService;
        }

        public void insertAcountRole(T_Admin_AcountRole acountRole)
        {
            this.AddEntity(acountRole);
        }

        /// <summary>
        /// 获取用户权限
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public List<string> GetAccountAuth(int accountId)
        {
            List<string> result = new List<string>();
            if (accountId <= 0)
            {
                return result;
            }
            List<T_Admin_AcountRole> acountRoleList = this._tEntityResponsity.Table.Where(p => p.AccountID == accountId && p.IsDelete == false).ToList();
            if (acountRoleList == null || acountRoleList.Count <= 0)
            {
                return result;
            }
            foreach (T_Admin_AcountRole acountRole in acountRoleList)
            {
                T_Admin_Role role = iAdminRoleService.GetRoleById(acountRole.RoleID);
                result.Add(role.RoleName);
            }
            return result;
        }

        public void deleteAccountAuth(int accountId)
        {
            if (accountId <= 0)
            {
                return;
            }
            List<T_Admin_AcountRole> acountRoleList = this._tEntityResponsity.Table.Where(p => p.AccountID == accountId && p.IsDelete == false).ToList();
            if (acountRoleList == null || acountRoleList.Count <= 0)
            {
                return;
            }
            foreach (T_Admin_AcountRole accountRole in acountRoleList)
            {
                accountRole.IsDelete = true;
                this.UpdateEntity(accountRole);
            }
        }
    }
}

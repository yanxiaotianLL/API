using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Services.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    public interface IAdminRoleDataService : IBaseService<T_Admin_RoleData>
    {
        JqGridResult<T_Admin_RoleData> GetRoleDataList(int page, int rows);

        string AddRoleData(T_Admin_RoleData roleData, T_Admin_Account account);

        string EditRoleData(T_Admin_RoleData roleData, T_Admin_Account account);

        string DeleteRoleData(int id);

        T_Admin_RoleData GetRoleDataById(int id);
    }
}

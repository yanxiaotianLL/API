using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Services.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    public interface IAdminMenuDataService : IBaseService<T_Admin_MenuData>
    {
        JqGridResult<T_Admin_MenuData> GetMenuDataList(int page, int rows, string MenuName);

        List<T_Admin_MenuData> GetMenuDataList(int page, int rows, int menuId);

        string AddMenuData(T_Admin_MenuData menuData, T_Admin_Account account);

        string DeleteMenuDataById(int id);

        
    }
}

using myselfFast.Fund.Core.Domain.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    public interface IAdminMenuService : IBaseService<T_Admin_Menu>
    {
        List<T_Admin_Menu> GetParentMenuList();
        List<T_Admin_Menu> GetChildMenuList(int accountId = 0);
        List<T_Admin_Menu> GetAllMenuList();
        string AddMenu(T_Admin_Menu menu, T_Admin_Account account);
        string DeleteMenu(int menuId);
        T_Admin_Menu GetMenuInfoById(int menuId);
        string EditMenu(T_Admin_Menu menu);
        List<T_Admin_Menu> GetMenuInfoByName(String menuName);
    }
}

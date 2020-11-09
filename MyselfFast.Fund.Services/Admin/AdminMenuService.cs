using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Fund.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    public class AdminMenuService : BaseService<T_Admin_Menu>, IAdminMenuService
    {
        //private  adminAccountService;
        public AdminMenuService(IRepository<T_Admin_Menu> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            //this.adminAccountService = adminAccountService;
        }

        //获取顶层菜单节点
        public List<T_Admin_Menu> GetParentMenuList()
        {
            List<T_Admin_Menu> menuList = null;
            menuList = this._tEntityResponsity.Table.Where(p => p.IsDelete == false && p.ParentID == 0).ToList();
            return menuList;
        }

        //获取非顶层菜单节点
        public List<T_Admin_Menu> GetChildMenuList(int accountId = 0)
        {
            List<T_Admin_Menu> menuList = null;
            if (accountId == 0)
            {
                menuList = this._tEntityResponsity.Table.Where(p => p.IsDelete == false && p.ParentID != 0).ToList();
                return menuList;
            }

            return GetMenus(accountId);
        }

        //获取所有菜单节点
        public List<T_Admin_Menu> GetAllMenuList()
        {
            List<T_Admin_Menu> menuList = this._tEntityResponsity.Table.Where(p => p.IsDelete == false).ToList();
            return menuList;
        }

        //添加菜单
        public string AddMenu(T_Admin_Menu menu, T_Admin_Account account)
        {
            try
            {
                List<T_Admin_Menu> menuList = GetAllMenuList();
                int? parentId = menu.ParentID;
                menu.CreateAdmin = account.UserName;
                menu.UpdateAdmin = account.UserName;
                menu.CreateTime = DateTime.Now;
                //menu.UpdateTime = DateTime.Now;
                menu.SortValue = menuList.Count + 1;
                menu.IsDelete = false;
                menu.IsLeaf = true;
                menu.Icon = string.IsNullOrWhiteSpace(menu.Icon) ? "fa fa-home" : menu.Icon;
                if (parentId == 0)
                {
                    List<T_Admin_Menu> parentMenuList = menuList.Where(p => p.ParentID == 0).ToList();
                    int count = parentMenuList.Count() + 1;
                    menu.MenuCode = count + "" + count + count + count;
                }
                else
                {
                    T_Admin_Menu tempMenu = menuList.Where(p => p.Id == parentId).FirstOrDefault();
                    List<T_Admin_Menu> parentTempMenuList = menuList.Where(p => p.ParentID == parentId).ToList();
                    string menuCode = (parentTempMenuList.Count() + 1).ToString().PadLeft(4, '0');
                    menu.MenuCode = tempMenu.MenuCode + "-" + menuCode;
                    //更新父节点为目录节点
                    T_Admin_Menu parentMenu = this.GetById((int)parentId);
                    parentMenu.IsLeaf = false;
                    this.UpdateEntity(parentMenu);
                }
                this.AddEntity(menu);

                return string.Empty;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        //删除菜单
        public string DeleteMenu(int menuId)
        {
            try
            {
                if (menuId <= 0) return "菜单id不能为空!";

                T_Admin_Menu menu = this.GetById(menuId);

                if (menu == null) return "该菜单不存在!";

                if (menu.IsLeaf == true)
                {
                    this.DeleteEntity(menu);
                }
                else
                {
                    List<T_Admin_Menu> menuList = this.GetAllMenuList();
                    if (menuList == null || menuList.Count == 0) return "未获取到菜单列表!";

                    List<T_Admin_Menu> menuChildList = menuList.Where(p => p.MenuCode.Contains(menu.MenuCode)).ToList();
                    if (menuChildList != null && menuChildList.Count > 0)
                    {
                        //获取删除的id列表
                        List<int> menuIdList = menuChildList.Select(p => p.Id).ToList();
                        this.DeleteEntitysByIds(menuIdList.ToArray());
                    }
                    this.DeleteEntity(menu);
                }
                //判断该父节点上是否还存在其他子节点
                int parentId = (int)menu.ParentID;
                List<T_Admin_Menu> list = this.GetAllMenuList();
                if (list != null && list.Count > 0)
                {
                    List<T_Admin_Menu> childlist = list.Where(p => p.ParentID == parentId).ToList();
                    if (childlist == null || childlist.Count == 0)
                    {
                        T_Admin_Menu parentMenu = this.GetById(parentId);
                        if (parentMenu != null)
                        {
                            parentMenu.IsLeaf = true;
                            this.UpdateEntity(parentMenu);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Empty;
        }

        //根据菜单id获取菜单信息
        public T_Admin_Menu GetMenuInfoById(int menuId)
        {
            if (menuId <= 0)
            {
                return null;
            }
            return this.GetById(menuId);
        }

        //修改菜单
        public string EditMenu(T_Admin_Menu menu)
        {
            try
            {
                if (menu == null) return "参数不正确！";
                T_Admin_Menu dbMenu = this.GetById(menu.Id);
                dbMenu.MenuName = menu.MenuName;
                dbMenu.Url = menu.Url;
                dbMenu.Icon = menu.Icon;
                dbMenu.ControllerName = menu.ControllerName;
                dbMenu.ActionName = menu.ActionName;
                dbMenu.MenuDescription = menu.MenuDescription;
                this.UpdateEntity(dbMenu);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Empty;
        }

        //根据菜单名称获取菜单信息
        public List<T_Admin_Menu> GetMenuInfoByName(String menuName)
        {
            return _tEntityResponsity.Table.Where(p => p.MenuName.Contains(menuName) && p.IsDelete == false).ToList();
        }


        /// <summary>
        /// 获取用户菜单
        /// </summary>
        /// <returns></returns>
        private List<T_Admin_Menu> GetMenus(int accountId)
        {
            if (accountId == 0)
            {
                throw new ArgumentNullException("id不能为0");
            }
            var roleIds = _dbContext.Set<T_Admin_AcountRole>().Where(w => w.AccountID == accountId && w.IsDelete == false).Select(s => s.RoleID);
            var menuIds = _dbContext.Set<T_Admin_RolePrivilege>().Where(w => roleIds.Contains(w.RoleID) && w.IsDelete == false).Select(s => s.MenuID);

            var menus = _dbContext.Set<T_Admin_Menu>().Where(w => menuIds.Contains(w.Id) && w.IsDelete == false);
            return menus.ToList();
        }
    }
}

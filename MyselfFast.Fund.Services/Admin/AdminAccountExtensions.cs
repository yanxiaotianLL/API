using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Services.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace myselfFast.Fund.Services.Admin
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Web.Framework.Permission
     *项目描述  ：
     *类名称    ：AdminAccountHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : AdminAccountHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-29 10:48:31
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 后台管理员
    /// </summary>
    public static class AdminAccountExtensions
    {
        ///// <summary>
        ///// 当前用户会话存储标识
        ///// </summary>
        //public readonly static string CURRENT_USER_IDENTITY;
        //#region HttpContextBase 扩展
        ///// <summary>
        ///// 判断用户是否已经登录
        ///// </summary>
        ///// <returns></returns>
        //public static bool IsAuthorize(this HttpContextBase request)
        //{
        //    var Session = HttpContext.Current.Session;
        //    if (Session != null || Session["CURRENT_USER_IDENTITY"] == null)
        //    {
        //        return false;
        //    }
        //    T_Admin_Account account = (T_Admin_Account)Session["CURRENT_USER_IDENTITY"];

        //    return true;
        //}
        ///// <summary>
        ///// 获取当前登录用户
        ///// </summary>
        ///// <param name="request"></param>
        ///// <returns></returns>
        //public static T_Admin_Account GetCurrentAdminAccount(this HttpContextBase request)
        //{
        //    var Session = HttpContext.Current.Session;
        //    if (Session == null || Session["CURRENT_USER_IDENTITY"] == null)
        //    {
        //        return null;
        //    }
        //    T_Admin_Account account = (T_Admin_Account)Session["CURRENT_USER_IDENTITY"];
        //    return account;
        //} 
        //#endregion

        #region T_Admin_Account扩展
        /// <summary>
        /// 判断当前用户是否是管理员
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static bool IsAdmin(this T_Admin_Account account)
        {
            if (account.UserName == "administrator")
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 判断当前用户是否拥有该控制器下的该action的权限
        /// </summary>
        /// <returns></returns>
        public static bool IsAuthorization(this T_Admin_Account account, string controllerName, string actionName)
        {
            var menus = AdminAccountHelper.GetMenus(account.Id);
            if (menus == null || menus.Count <= 0)
            {
                return false;
            }
            var mm = menus.Where(w => w.ControllerName == controllerName && w.ActionName == actionName).Select(s => s);
            if (mm != null && mm.Count() > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 判断当前用户是否拥有该菜单项(MenuCode)的权限
        /// </summary>
        /// <returns></returns>
        public static bool IsAuthorization(this T_Admin_Account account, string menuCode)
        {
            var menus = AdminAccountHelper.GetMenus(account.Id);
            if (menus == null || menus.Count <= 0)
            {
                return false;
            }
            var mm = menus.Where(w =>w.MenuCode == menuCode).Select(s => s);
            if (mm != null && mm.Count() > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 判断当前用户是否具有菜单数据权限，例如按钮等
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static bool IsAuthorizationMenuDataKey(this T_Admin_Account account,string menuCode,string dataKey)
        {
            return account.CheckMenuDataKey(new MenuDataKeyAttribute(menuCode,dataKey));
        }
        /// <summary>
        /// 判断当前用户是否具有菜单数据权限，例如按钮等
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static bool IsAuthorizationMenuDataKey(this T_Admin_Account account, string controllerName,string actionName, string dataKey)
        {
            return account.CheckMenuDataKey(new MenuDataKeyAttribute(controllerName,actionName,dataKey));
        }
        /// <summary>
        /// 判断当前用户是否具有某个角色权限
        /// </summary>
        /// <param name="account"></param>
        /// <param name="roleCode">角色编码</param>
        /// <returns></returns>
        public static bool IsAuthorizationRole(this T_Admin_Account account,string[] roleCodes)
        {
            bool flag = false;
            var roles = AdminAccountHelper.GetRoles(account.Id);
            if (roles != null && roles.Count > 0)
            {
                return roles.Where(w => roleCodes.Contains(w.RoleCode)).Any();
            }
            return flag;
        }
        /// <summary>
        /// 判断当前用户是否具有某个角色数据权限
        /// </summary>
        /// <param name="account"></param>
        /// <param name="roleCode">角色</param>
        /// <param name="dataKey">数据权限字典</param>
        /// <returns></returns>
        public static bool IsAuthorizationRoleDataKey(this T_Admin_Account account, string roleCode, string dataKey)
        {
            return account.CheckRoleDataKey(new RoleDataKeyAttribute(roleCode,dataKey));
            
        }          

      
        #endregion

        #region T_Admin_Role扩展
        public static bool CheckRoleHasDataKey(this T_Admin_Role role, string dataKey)
        {
            var roleDatas = AdminAccountHelper.GetRoleData(role.Id);
            if (roleDatas == null || roleDatas.Count <= 0)
            {
                return false;
            }
            return roleDatas.Select(s => s.DataKey == dataKey).Any();
        } 
        #endregion

        #region T_Admin_Menu扩展
        public static bool CheckMenuHasDataKey(this T_Admin_Menu menu, int accountId, string dataKey)
        {
            var menuDatas = AdminAccountHelper.GetMenuData(menu.Id, accountId);
            if (menuDatas == null || menuDatas.Count <= 0)
            {
                return false;
            }
            return menuDatas.Where(w => w.DataKey == dataKey).Any();

        } 
        #endregion

        #region 其它辅助扩展
        public static bool CheckRole(this T_Admin_Account account, string[] roleCodes)
        {
            bool flag = false;
            var roles = AdminAccountHelper.GetRoles(account.Id);
            if (roles != null && roles.Count > 0)
            {
                return roles.Where(w => roleCodes.Contains(w.RoleCode)).Any();
            }
            return flag;
        }
        public static bool CheckRoleDataKey(this T_Admin_Account account, RoleDataKeyAttribute dataKey)
        {

            //验证该用户下是否具有该角色
            var roles = AdminAccountHelper.GetRoles(account.Id);

            T_Admin_Role adminRole = null;
            if (roles != null && roles.Count > 0)
            {
                adminRole = roles.Where(w => w.RoleCode == dataKey.RoleCode).FirstOrDefault();
            }
            if (adminRole == null)
            {
                return false;
            }
            //验证该用户角色下是否具有该数据权限
            return adminRole.CheckRoleHasDataKey(dataKey.DataKey);


        }
        public static bool CheckMenuDataKey(this T_Admin_Account account, MenuDataKeyAttribute dataKey)
        {

            //验证该用户下是否具有该菜单权限
            var menus = AdminAccountHelper.GetMenus(account.Id);
            T_Admin_Menu menu = null;
            if (menus != null && menus.Count > 0)
            {
                if (dataKey.MenuCode != null && dataKey.MenuCode.Trim() != "")
                {
                    menu = menus.Where(w => w.MenuCode == dataKey.MenuCode).SingleOrDefault();
                }
                else
                {
                    menu = menus.Where(w => w.ActionName == dataKey.ActionName && w.ControllerName == dataKey.ControllerName).FirstOrDefault();
                }

            }
            if (menu == null)
            {
                return false;
            }
            //验证该用户菜单权限下是否具有该数据权限
            return menu.CheckMenuHasDataKey(account.Id, dataKey.DataKey);


        }  
        #endregion


    }

   
}

using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services.Admin;
using myselfFast.Component.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Web.Framework.Permission
     *项目描述  ：
     *类名称    ：AdminAccountManger
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : AdminAccountManger
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-29 16:19:39
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 帐号管理类
    /// </summary>
    public  class AdminAccountHelper
    {
        private static readonly string KEY_PREX = "ADMINACCOUNTPERMISSION";
        #region 角色相关
        /// <summary>
        /// 获取用户角色数据
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static List<T_Admin_Role> GetRoles(int accountId)
        {
            if (accountId == 0)
            {
                throw new ArgumentNullException("accountId不能为空");
            }
            string key = string.Format("{0}_Roles_{1}", KEY_PREX, accountId);
            //如果缓存中存在则直接返回
            ICacheStorage cacheStorage = EngineContext.Current.Resolve<ICacheStorage>();
            if (cacheStorage.Exists(key))
            {
                var value = cacheStorage.Get<List<T_Admin_Role>>(key);
                return value.HasValue ? cacheStorage.Get<List<T_Admin_Role>>(key).Value : null;
            }
            //缓存中不存在，从数据库获取
            var adminAccountService = EngineContext.Current.Resolve<IAdminAccountService>();
            var roles = adminAccountService.GetRoles(accountId);
            CacheValue<List<T_Admin_Role>> cacheRoles;
            if (roles != null && roles.Count > 0)
            {
                cacheRoles = new CacheValue<List<T_Admin_Role>>(roles, true);
                return roles;
            }
            cacheRoles = new CacheValue<List<T_Admin_Role>>(null, true);
            return null;
        }
        /// <summary>
        /// 更具角色ID获取对应数据权限项
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public static List<T_Admin_RoleData> GetRoleData(int roleId)
        {
            var  adminRolePrivilegeService = EngineContext.Current.Resolve<IAdminRoleDataRolePrivilegeService>();
            //缓存处理

            return adminRolePrivilegeService.getRoleData(roleId);

        } 
        #endregion
        #region 菜单相关
        /// <summary>
        /// 获取用户菜单数据
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static List<T_Admin_Menu> GetMenus(int accountId)
        {
            if (accountId == 0)
            {
                throw new ArgumentNullException("accountId不能为空");
            }
            string key = string.Format("{0}_Menus_{1}", KEY_PREX, accountId);
            //如果缓存中存在则直接返回
            ICacheStorage cacheStorage = EngineContext.Current.Resolve<ICacheStorage>();
            if (cacheStorage.Exists(key))
            {
                var value = cacheStorage.Get<List<T_Admin_Menu>>(key);
                return value.HasValue ? cacheStorage.Get<List<T_Admin_Menu>>(key).Value : null;
            }
            //缓存中不存在，从数据库获取
            var adminAccountService = EngineContext.Current.Resolve<IAdminAccountService>();
            var menus = adminAccountService.GetMenus(accountId);
            CacheValue<List<T_Admin_Menu>> cacheMenus;
            if (menus != null && menus.Count > 0)
            {
                cacheMenus = new CacheValue<List<T_Admin_Menu>>(menus, true);
                return menus;
            }
            cacheMenus = new CacheValue<List<T_Admin_Menu>>(null, true);
            return null;
        }
        /// <summary>
        /// 更具菜单ID获取对应数据权限项
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public static List<T_Admin_MenuData> GetMenuData(int menuId, int accountId)
        {
            var adminMenuDataPrivilegeService = EngineContext.Current.Resolve<IAdminMenuDataRolePrivilegeService>();
            //缓存处理

            //获取用户的所有角色Id
            var roles = AdminAccountHelper.GetRoles(accountId);
            if (roles == null || roles.Count <=0)
            {
                return null;
            }
            //根据角色和菜单获取菜单数据项
            var roleIds = roles.Select(s=>s.Id).ToArray();
            return adminMenuDataPrivilegeService.GetMenuDataByMenuId(roleIds, menuId);
        } 

        #endregion
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Web.Framework.Permission
     *项目描述  ：
     *类名称    ：AdminMenuAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : AdminMenuAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-29 10:08:23
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 菜单标识
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public  class AdminMenuAttribute:Attribute
    {
        public AdminMenuAttribute(string menuName, string menuCode)
        {
            this.MenuName = menuName;
            this.MenuCode = menuCode;
            IsLoginWithPermission = false;
        }
        public AdminMenuAttribute(string controllerName, string actionName, string menuName)
        {
            
            this.MenuName = menuName;
            this.ControllerName = controllerName;
            this.ActionName = actionName;
            IsLoginWithPermission = false;
        }
        public AdminMenuAttribute(string menuName, string  menuCode, string controllerName, string actionName)
        {
            this.MenuName = menuName;
            this.MenuCode = menuCode;
            this.ControllerName = controllerName;
            this.ActionName = actionName;
            IsLoginWithPermission = false;
        }
        public AdminMenuAttribute(string menuName,string menuCode, string menuDescription, string controllerName, string actionName,bool isLoginWithPermission)
        {
            this.MenuName = menuName;
            this.MenuDescription = menuDescription;
            this.ControllerName = controllerName;
            this.ActionName = actionName;
            this.IsLoginWithPermission = isLoginWithPermission;
            this.MenuCode = menuCode;
        }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }
        /// <summary>
        /// 菜单编码
        /// </summary>
        public string MenuCode { get; set; }
        /// <summary>
        /// 菜单描述
        /// </summary>
        public string MenuDescription { get; set; }
        /// <summary>
        /// 登录即可拥有此权限
        /// </summary>
        public bool IsLoginWithPermission { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
             
    }
    /// <summary>
    /// 角色标识
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class RoleAttribute : Attribute
    {
        public RoleAttribute(string roleCode)
        {
            this.RoleCode = new string[] { roleCode };
            this.RoleOnly = true;
        }
        public RoleAttribute(string roleName,string[] roleCode)
        {
            this.RoleOnly = true;
            this.RoleCode = roleCode;
            this.RoleName = roleName;

        }
        public RoleAttribute(string roleName, string[] roleCode,bool roleOnly)
        {
            this.RoleOnly = roleOnly;
            this.RoleCode = roleCode;
            this.RoleName = roleName;
            

        }
        public string RoleName { get; set; }

        public string[] RoleCode { get; set; }

        public bool RoleOnly { get; set; }
    }

    /// <summary>
    /// 基于角色按钮等数据标签
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class RoleDataKeyAttribute : Attribute
    {
        public RoleDataKeyAttribute(string roleCode,string dataKey)
        {
            this.DataKey = dataKey;
            this.RoleCode = roleCode;
        }
        public RoleDataKeyAttribute(string roleCode,string roleName,string dataKey,string dataValue)
        {
            this.DataKey = dataKey;
            this.RoleCode = roleCode;
            this.DataValue = dataValue;
            this.RoleName = roleName;
        }
        public string DataKey { get; set; }
        public string DataValue { get; set; }      

        public string RoleName { get; set; }
        public string RoleCode { get; set; } 
    }
    /// <summary>
    /// 基于菜单的数据权限标签
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class MenuDataKeyAttribute : Attribute
    {
        public MenuDataKeyAttribute(string menuCode,string dataKey)
        {
            this.MenuCode = menuCode;
            this.DataKey = dataKey;
        }
        public MenuDataKeyAttribute(string controllerName,string actionName, string dataKey)
        {
            this.ControllerName = controllerName;
            this.ActionName = actionName;
            this.DataKey = dataKey;
        }
        public MenuDataKeyAttribute(string menuCode,string menuName, string dataKey,string dataValue)
        {
            this.MenuCode = menuCode;
            this.DataKey = dataKey;
            this.MenuName = menuName;
            this.DataValue = dataValue;
        }
        public string DataKey { get; set; }
        public string DataValue { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }
        public string MenuCode { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; } 
    }
    /*

    /// <summary>
    /// 按钮等数据标签
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class DataKeyAttribute : Attribute
    {
        public DataKeyAttribute(string roleCode, string roleName, string dataKey, string dataValue)
        {
            this.RoleCode = roleCode;
            this.RoleName = roleName;
            this.DataKey = dataKey;
            this.DataValue = dataValue;
            this.Scope = DataScope.Role;
        }
        public DataKeyAttribute(string roleCode, string dataKey,DataScope scope)
        {
            this.RoleCode = roleCode;           
            this.DataKey = dataKey;
            this.Scope = DataScope.Role;
        }

        public DataKeyAttribute(string menuCode, string dataKey)
        {

            this.DataKey = dataKey;
            this.MenuCode = menuCode;
            this.Scope = DataScope.Menu;
        }
        public DataKeyAttribute(string menuCode, string menuName, string dataKey, string dataValue, DataScope scop = DataScope.Menu)
        {
            this.DataValue = dataValue;
            this.DataKey = dataKey;
            this.MenuCode = menuCode;
            this.Scope = DataScope.Menu;
        }
        public DataKeyAttribute(string controllerName, string actionName, string dataKey, DataScope scop = DataScope.Menu)
        {
            this.ControllerName = controllerName;
            this.ActionName = actionName;
            this.DataKey = dataKey;
            this.Scope = DataScope.Menu;
        }
        public DataKeyAttribute(string controllerName, string actionName, string menuName, string menuCode, string dataKey, DataScope scop = DataScope.Menu)
        {
            this.ControllerName = controllerName;
            this.ActionName = actionName;
            this.MenuName = menuName;
            this.MenuCode = menuCode;
            this.Scope = DataScope.Menu;
        }
        //public DataKeyAttribute(string controllerName, string actionName,string dataKey,string dataValue)
        //{
        //    this.ControllerName = controllerName;
        //    this.ActionName = actionName;
           
        //    this.DataKey = dataKey;
        //    this.DataValue = DataValue;
        //    this.Scope = DataScope.Menu;
        //}     
       
     
        public DataScope Scope;
        public string DataKey { get; set; }

        public string DataValue { get; set; }
        #region DataScope=Role时候使用，其它可以不配置

        public string RoleName { get; set; }
        public string RoleCode { get; set; } 
        #endregion
        #region DataScope=Menu的时候使用，其它可以不配置
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }
        public string MenuCode { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; } 
        #endregion

    }
     * public enum DataScope{
        Role,//角色范围
        Menu //菜单范围
    }
     * */
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class AdminAllowAttribute : Attribute
    {

    }
    
}

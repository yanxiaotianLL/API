using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDebugTool.Configs
{
    /**********************************************************************************
     *项目名称	：WebApiDebugTool.Config
     *项目描述  ：
     *类名称    ：ServiceAccountConfiguration
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ServiceAccountConfiguration
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/20 14:48:52
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 服务帐号配置
    /// </summary>
    public class ServiceAccountConfiguration
    {
        public List<ServiceAccount> ServiceAccounts { get; set; }
    }
    /// <summary>
    /// 服务帐号
    /// </summary>
    public class ServiceAccount
    {
        public const string AppAccount = "AppServiceAcount";
        /// <summary>
        /// AppID
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// AppSecret
        /// </summary>
        public string Appsecret { get; set; }
        /// <summary>
        /// 权限类型  0：所有接口  1：可以访问那些接口  2：不可以访问那些接口
        /// </summary>
        public RightType RightType { get; set; }
        /// <summary>
        /// 允许用户类型，空表示所有
        /// </summary>
        public List<string> FesidInsType { get; set; }
        /// <summary>
        /// 权限列表
        /// </summary>
        public List<Right> RightList { get; set; }
        /// <summary>
        /// 账户信息描述
        /// </summary>
        public string Remark { get; set; }


    }
    /// <summary>
    /// 权限类型
    /// </summary>
    public enum RightType
    {
        All = 0,
        Contain = 1,
        Exclude = 2
    }
    /// <summary>
    /// 接口权限控制列表
    /// </summary>
    public class Right
    {
        /// <summary>
        /// 控制器名称
        /// </summary>
        public string Controller { get; set; }
        /// <summary>
        /// 方法名称
        /// </summary>
        public List<string> Actions { get; set; }
    }
}

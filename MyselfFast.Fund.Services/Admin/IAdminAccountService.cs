using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Services.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Services.Admin
     *项目描述  ：
     *接口名称  ：IAdminAccountService
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : IAdminAccountService
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-15 14:53:19
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public interface IAdminAccountService : IBaseService<T_Admin_Account>
    {
        /// <summary>
        /// 根据用户名获取帐号
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        T_Admin_Account GetAccountByUserName(string userName);
        /// <summary>
        /// 获取用户角色
        /// </summary>
        /// <returns></returns>
        List<T_Admin_Role> GetRoles(int accountId);
        /// <summary>
        /// 获取用户菜单
        /// </summary>
        /// <returns></returns>
        List<T_Admin_Menu> GetMenus(int accountId);
        /// <summary>
        /// 获取员工列表
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="departName"></param>
        /// <param name="rows"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        JqGridResult<T_Admin_Account> GetAccountList(string userName, string departName, int rows, int page);
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="account"></param>
        /// <param name="adminAccount"></param>
        /// <returns></returns>
        string AddAccount(T_Admin_Account account, T_Admin_Account adminAccount);
        /// <summary>
        /// 根据员工Id获取员工信息
        /// </summary>
        /// <param name="account"></param>
        /// <param name="adminAccount"></param>
        /// <returns></returns>
        T_Admin_Account GetAccountById(int id);
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        string EditAccount(T_Admin_Account account, T_Admin_Account adminAccount);
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        string DeleteAccountById(int id);
        /// <summary>
        /// 用户授权
        /// </summary>
        /// <param name="authRoles"></param>
        /// <param name="accountId"></param>
        /// <param name="adminName"></param>
        /// <returns></returns>
        string AccountAuth(List<String> authRoles, int accountId, string adminName);
       
        /// <summary>
        /// 发送忘记密码激活邮件
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        bool SendRepairPasswordEmail(T_Admin_Account account, string host, ref string message);
        /// <summary>
        /// 忘记密码签名校验
        /// </summary>
        /// <param name="sign"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        bool CheckRepairPasswordSign(string sign, ref string message);
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        bool RepairPassword(string password, string username,string sign, ref string message);
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        bool RepairPassword(string sourcePassword, string password, int accountId,ref string message);
        /// <summary>
        /// 根据openid获取帐号信息
        /// </summary>
        /// <param name="openId"></param>
        /// <returns></returns>
        T_Admin_Account GetAdminByOpenId(string openId);
        /// <summary>
        /// 根据用户名和密码获取用户
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        T_Admin_Account GetAdminByNameAndPass(string userName, string password);
        
    }
}

using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Core.Common;
using System.Data.SqlClient;
using myselfFast.Component.Email;


namespace myselfFast.Fund.Services.Admin
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Services.Admin
     *项目描述  ：
     *类名称    ：AdminAccountService
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : AdminAccountService
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-15 14:53:28
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class AdminAccountService : BaseService<T_Admin_Account>, IAdminAccountService
    {
        private IAdminRoleService iAdminRoleService;
        private IAdminAcountRoleService iAdminAcountRoleService;
        private IRepository<T_Admin_Role> tRoleEntityResponsity;
        private IRepository<T_Admin_Account> tEntityResponsity;
        private IAdminPasswordSignHistoryService passwordSignHistoryService;
        private IRepository<T_Admin_PasswordSignHistory> tEntityAdminPasswordSignHistoryResponsity;
        private IEmail emailService;
        public AdminAccountService(IRepository<T_Admin_Account> tEntityResponsity,
            IDataProvider _dataProvider,
            IDbContext _dbContext,
            IAdminRoleService iAdminRoleService,
            IAdminAcountRoleService iAdminAcountRoleService,
            IRepository<T_Admin_Role> tRoleEntityResponsity,
            IEmail emailService,
            IAdminPasswordSignHistoryService passwordSignHistoryService,
            IRepository<T_Admin_PasswordSignHistory> tEntityAdminPasswordSignHistoryResponsity)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.iAdminRoleService = iAdminRoleService;
            this.iAdminAcountRoleService = iAdminAcountRoleService;
            this.tRoleEntityResponsity = tRoleEntityResponsity;
            this.tEntityResponsity = tEntityResponsity;
            this.emailService = emailService;
            this.passwordSignHistoryService = passwordSignHistoryService;
            this.tEntityAdminPasswordSignHistoryResponsity = tEntityAdminPasswordSignHistoryResponsity;
        }
        /// <summary>
        /// 根据用户名获取用户信息
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public T_Admin_Account GetAccountByUserName(string userName)
        {
            if (userName.IsNullOrWhiteSpace())
            {
                throw new myselfFastException("userName不能为空");
            }
            var dbSet = _dbContext.Set<T_Admin_Account>();
            return dbSet.Where(w => w.UserName == userName && w.IsDelete == false).FirstOrDefault();
        }
        /// <summary>
        /// 获取用户角色
        /// </summary>
        /// <returns></returns>
        public List<T_Admin_Role> GetRoles(int accountId)
        {
            if (accountId == 0)
            {
                throw new ArgumentNullException("id不能为0");
            }

            var roleIds = _dbContext.Set<T_Admin_AcountRole>().Where(w => w.AccountID == accountId && w.IsDelete == false).Select(s => s.RoleID);
            return _dbContext.Set<T_Admin_Role>().Where(w => roleIds.Contains(w.Id) && w.IsDelete == false).Select(s => s).ToList();
        }
        /// <summary>
        /// 获取用户菜单
        /// </summary>
        /// <returns></returns>
        public List<T_Admin_Menu> GetMenus(int accountId)
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

        /// <summary>
        /// 获取员工列表
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="departName"></param>
        /// <param name="rows"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public JqGridResult<T_Admin_Account> GetAccountList(string userName, string departName, int rows, int page)
        {
            PagedList<T_Admin_Account> pageList = new PagedList<T_Admin_Account>(
                _tEntityResponsity.Table.WhereIf(p => p.UserName.Contains(userName), !string.IsNullOrWhiteSpace(userName))
                .WhereIf(p => p.DepartName.Contains(departName), !string.IsNullOrWhiteSpace(departName)).Where(p => p.IsDelete == false),
                page, rows);
            return JqGridResult<T_Admin_Account>.Build(pageList);
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="account"></param>
        /// <param name="adminAccount"></param>
        /// <returns></returns>
        public string AddAccount(T_Admin_Account account, T_Admin_Account adminAccount)
        {
            try
            {
                if (account == null)
                {
                    return "参数不正确！";
                }

                T_Admin_Account temAccount = this._tEntityResponsity.Table.Where(p => p.UserName == account.UserName && p.IsDelete == false).FirstOrDefault();
                if (temAccount != null && temAccount.Id > 0)
                {
                    return "该用户名已存在！";
                }

                account.CreateAdmin = adminAccount.UserName;
                account.UpdateAdmin = adminAccount.UserName;
                //account.UpdateTime = DateTime.Now;
                account.CreateTime = DateTime.Now;
                account.IsDelete = false;
                //account.State = 0;
                this.AddEntity(account);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Empty;
        }

        /// <summary>
        /// 根据员工Id获取员工信息
        /// </summary>
        /// <param name="account"></param>
        /// <param name="adminAccount"></param>
        /// <returns></returns>
        public T_Admin_Account GetAccountById(int id)
        {
            return this.GetById(id);
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public string EditAccount(T_Admin_Account account, T_Admin_Account adminAccount)
        {
            try
            {
                if (account == null || account.Id <= 0)
                {
                    return "参数不正确！";
                }

                T_Admin_Account dbAccount = GetAccountById(account.Id);
                dbAccount.UserName = account.UserName;
                dbAccount.RealName = account.RealName;
                dbAccount.Password = EncryptHelperTwo.MD5One(account.UserName + account.Password);
                dbAccount.Email = account.Email;
                dbAccount.Telephone = account.Telephone;
                //dbAccount.UpdateTime = DateTime.Now;
                dbAccount.UpdateAdmin = adminAccount.UserName;
                this.UpdateEntity(dbAccount);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Empty;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string DeleteAccountById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return "参数不正确！";
                }
                T_Admin_Account dbAccount = GetAccountById(id);
                if (dbAccount == null || dbAccount.Id <= 0)
                {
                    return "参数不正确！";
                }
                dbAccount.IsDelete = true;
                this.UpdateEntity(dbAccount);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Empty;
        }

        /// <summary>
        /// 用户授权
        /// </summary>
        /// <param name="authRoles"></param>
        /// <returns></returns>
        public string AccountAuth(List<string> authRoles, int accountId, string adminName)
        {
            if (authRoles == null || authRoles.Count <= 0 || accountId <= 0)
            {
                return "参数不正确";
            }
            //用户已存在的权限
            iAdminAcountRoleService.deleteAccountAuth(accountId);
            foreach (string roleName in authRoles)
            {
                JqGridResult<T_Admin_Role> roleList = iAdminRoleService.GetRoleList(roleName, 1, 10);
                if (roleList == null || roleList.rows == null || roleList.rows.Count <= 0)
                {
                    continue;
                }
                T_Admin_Role role = roleList.rows.FirstOrDefault();
                T_Admin_AcountRole acountRole = new T_Admin_AcountRole()
                {
                    AccountID = accountId,
                    CreateAdmin = adminName,
                    CreateTime = DateTime.Now,
                    IsDelete = false,
                    RoleID = role.Id
                };
                iAdminAcountRoleService.insertAcountRole(acountRole);
            }
            return string.Empty;
        }

        /// <summary>
        /// 发送忘记密码激活邮件
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>

        public bool SendRepairPasswordEmail(T_Admin_Account account, string host, ref string message)
        {
            //如果24小时内发送过5次，不再发送
            DateTime dt = DateTime.Now.AddDays(-1);
            int count = tEntityAdminPasswordSignHistoryResponsity.TableNoTracking.Where(w => w.CreateTime >= dt && w.IsDelete == false).Count();
            if (count >= 5)
            {
                message = "24小时内连续5次提起忘记密码申请，请查看邮箱，如有疑问，请联系管理员。";
                return false;
            }
            //生成sign，并组装忘记密码url
            string sign = Guid.NewGuid().ToString();
            //拼接url参数
            string url = host + sign;

            //将其它未标记为删除状态的发送记录标识为删除
            var historyList = _dbContext.Set<T_Admin_PasswordSignHistory>().Where(w => w.IsDelete == false && w.UserName == account.UserName).ToList();
            if (historyList != null && historyList.Count() > 0)
            {
                for (int i = 0; i < historyList.Count(); i++)
                {
                    historyList[i].IsDelete = true;
                }
            }
            _dbContext.SaveChanges();

            //发送邮件到用户邮箱
            T_Admin_PasswordSignHistory history = new T_Admin_PasswordSignHistory();
            history.CreateTime = DateTime.Now;
            history.Email = account.Email;
            history.UserName = account.UserName;
            history.IsDelete = false;
            history.Sign = sign;
            history.Url = url;
            history.AdminUserId = account.Id;
            passwordSignHistoryService.Add(history);

            emailService.SendEmail(account.Email, "myself集体户口后台用户密码修改", url);
            return true;

        }
        /// <summary>
        /// 忘记密码签名校验
        /// </summary>
        /// <param name="sign"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool CheckRepairPasswordSign(string sign, ref string message)
        {
            var history = passwordSignHistoryService.GetHistory(sign);
            if (history == null)
            {
                message = "链接无效，如有问题，请联系管理员!";
                return false;
            }

            return true;
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool RepairPassword(string password, string username, string sign, ref string message)
        {
            var history = passwordSignHistoryService.GetHistory(sign);
            if (history == null)
            {
                message = "链接无效，如有问题，请联系管理员!";
                return false;
            }
            if (history.UserName != username)
            {
                message = "签名用户信息失败，如有问题，请联系管理员!";
                return false;

            }
            var account = this.GetAccountById(history.AdminUserId);
            account.Password = EncryptHelperTwo.MD5One(username + password);// EncryptHelper.MD5(password);
            //account.State = 1;
            this.UpdateEntity(account);
            return true;
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="password"></param>
        /// <param name="accountId"></param>

        public bool RepairPassword(string sourcePassword, string password, int accountId, ref string message)
        {

            var account = this.GetAccountById(accountId);
            if (sourcePassword != "")
            {
                if (account.Password != EncryptHelperTwo.MD5One(account.UserName + sourcePassword))//EncryptHelper.MD5(sourcePassword)
                {
                    message = "原密码不正确！";
                    return false;
                }
            }

            //account.State = 1;
            account.Password = EncryptHelperTwo.MD5One(account.UserName + password);
            this.UpdateEntity(account);
            return true;

        }
        /// <summary>
        /// 根据openid获取帐号信息
        /// </summary>
        /// <param name="openId"></param>
        /// <returns></returns>
        public T_Admin_Account GetAdminByOpenId(string openId)
        {
            //return  tEntityResponsity.Table.SingleOrDefault(s => s.OpenId == openId);
            return null;
        }
        /// <summary>
        /// 根据用户名和密码获取用户
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public T_Admin_Account GetAdminByNameAndPass(string userName, string password)
        {

            return tEntityResponsity.Table.SingleOrDefault(s => s.UserName == userName && s.Password == password && s.IsDelete == false);
        }
    }
}

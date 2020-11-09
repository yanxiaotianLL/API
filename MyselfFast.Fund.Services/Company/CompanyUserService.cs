using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services;
using myselfFast.ZFBZ.Core.Domain.Company;
using myselfFast.ZFBZ.Services.ModelExt;
using System.Linq;

namespace myselfFast.ZFBZ.Services.Company
{
    public class CompanyUserService : BaseService<T_Company_User>, ICompanyUserService
    {
        private myselfFast.Component.Email.IEmail iemail;
        public CompanyUserService(IRepository<T_Company_User> tEntityResponsity,
           IDataProvider _dataProvider,
           IDbContext _dbContext, myselfFast.Component.Email.IEmail iemail)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.iemail = iemail;
        }
        /// <summary>
        /// 插入用户名
        /// </summary>
        /// <param name="user"></param>
        public void InsertUser(T_Company_User user,out string msg)
        {
            msg = "";
            user.Pwd = myselfFast.Fund.Core.Common.EncryptHelper.DESEncrypt("myself" + user.Pwd);
            var query = _tEntityResponsity.Table.Where(t => t.IsDelete == false && t.LoginName == user.LoginName);
            if (query != null && query.Count() > 0)
            {
               msg="用户名已存在！";
            }
            else
            {
                AddEntity(user);
                //SaveEntity(user);
            }
        }
        /// <summary>
        /// 判断用户登录
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public T_Company_User Login(LoginRequestModel login,out string msg)
        {
             msg = "";
            var pwd = myselfFast.Fund.Core.Common.EncryptHelper.DESEncrypt("myself" + login.Pwd);
            var selmodel = _tEntityResponsity.Table.FirstOrDefault(t => t.IsDelete == false && t.LoginName == login.UserName);
            if (selmodel == null)
            {
                msg="用户名不存在！";
            }
            else
            {
                if (selmodel.Pwd == pwd)
                {
                    return selmodel;
                }
                else
                {
                     msg="密码错误！";
                }
            }
            return null;

        }
        /// <summary>
        /// 密码发邮箱
        /// </summary>
        /// <param name="email"></param>
        public void SendMail(string email,out string msg)
        {
            msg = "";
            var query = _dbContext.Set<T_Company>().Where(t => t.ContactEmail == email && t.IsDelete == false).FirstOrDefault();
            if (query != null)
            {
                var user = _tEntityResponsity.Table.Where(t => t.CompanyId == query.Id && t.IsDelete == false).FirstOrDefault();
                if (user == null)
                {
                   msg="用户已删除！";
                }
                else
                {
                    var pwd = myselfFast.Fund.Core.Common.EncryptHelper.DESDecrypt(user.Pwd);
                    iemail.SendEmail(query.ContactEmail, "密码找回", "您的密码为：" + pwd.Substring(5, pwd.Length - 5));
                }
            }
            else
            {
                msg=("输入的邮箱不存在，请输入正确的邮箱！");
            }
        }

    }
}

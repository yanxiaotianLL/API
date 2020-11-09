using myselfFast.Fund.Services;
using myselfFast.ZFBZ.Core.Domain.Company;
using myselfFast.ZFBZ.Services.ModelExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.ZFBZ.Services.Company
{
    public interface ICompanyUserService : IBaseService<T_Company_User>
    {
              /// <summary>
        /// 插入用户名
        /// </summary>
        /// <param name="user"></param>
        void InsertUser(T_Company_User user, out string msg);
                /// <summary>
        /// 判断用户登录
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        T_Company_User Login(LoginRequestModel login, out string msg);
                /// <summary>
        /// 密码发邮箱
        /// </summary>
        /// <param name="email"></param>
        void SendMail(string email, out string msg);
    }
}

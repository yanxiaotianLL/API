using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using FS.Component.Infrastructure;
using NewSystem.SDK.Token;

namespace FS.ServiceHost.Config.NewSytemSDKConfig
{
    /**********************************************************************************
     *项目名称	：DependencyRegister.NewSytemSDKConfig
     *项目描述  ：
     *类名称    ：TokenProvider
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : TokenProvider
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/18 11:55:34
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class TokenProvider : ITokenProvider
    {
        //private FS.IBLL.IT_Int_TokenuserBLL tokenUserBll =
        //    EngineContext.Current.Resolve<FS.IBLL.IT_Int_TokenuserBLL>();
        //FS.Component.Logging.ILogger logger = EngineContext.Current.Resolve<FS.Component.Logging.ILogger>();
        private FS.IBLL.IT_Int_TokenuserBLL tokenUserBll =
            EngineContext.Current.Resolve<FS.IBLL.IT_Int_TokenuserBLL>();
        FS.Component.Logging.ILogger logger = EngineContext.Current.Resolve<FS.Component.Logging.ILogger>();
        public UserTokenModel GetTokenUser(string hno)
        {
            UserTokenModel model = null;
            try
            {
                int iHno = Convert.ToInt32(hno);
                var tokenUser =  tokenUserBll.FindTheFirst(w => w.Hno == iHno);
                if (tokenUser != null)
                {
                    model = new UserTokenModel
                    {
                        Hno = tokenUser.Hno,
                        Newtokenwords = tokenUser.Newtokenwords
                    };
                }
            }
            catch (Exception ex)
            {
                logger.Error(this, "获取新系统token对应用户密码信息报错", ex);
            }
            return model;
        }

        public bool SetTokenUser(UserTokenModel model)
        {
            bool flag = false;
            try
            {
                int iHno = Convert.ToInt32(model.Hno);
                var tokenUser = tokenUserBll.FindTheFirst(w => w.Hno == iHno);
                tokenUser.Hno = model.Hno;
                tokenUser.Newtokenwords = model.Newtokenwords;
                tokenUser.Tokenwords = model.Tokenwords;
                tokenUserBll.AddOrUpdate(tokenUser);
                flag = true;
            }
            catch (Exception ex)
            {
                logger.Error(this, "过去新系统token对应用户密码信息报错", ex);
            }
            return flag;

        }
    }
}

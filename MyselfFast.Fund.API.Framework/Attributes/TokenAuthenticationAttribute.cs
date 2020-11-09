using myselfFast.Fund.API.Framework.MessageHandler;
using myselfFast.Fund.API.Framework.Models;
using myselfFast.Fund.API.Framework.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using myselfFast.Fund.API.Framework.Extensions;
using myselfFast.Fund.API.Framework.Extensition;

namespace myselfFast.Fund.API.Framework.Attributes
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Attributes
     *项目描述  ：token认证过滤器
     *类名称    ：TokenAuthenticationAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : TokenAuthenticationAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/17 12:19:36
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/

    public class TokenAuthenticationAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if (actionContext.Request.GetAuthorizationMode() != AuthorizationMode.USERACCOUNT)
            {
                return true;
            }

            string token = actionContext.Request.Properties["TOKEN"].ToString();
            //判断是否拥有匿名权限
            Type m = actionContext.ControllerContext.Controller.GetType();
            MethodInfo info = m.GetMethod(actionContext.ActionDescriptor.ActionName);
            if (info.IsDefined(typeof(AllowAnonymousAttribute)))
            {
                //判断token的有效性
                ITokenContainer tokenContainer = TokenContainerFactory.GetTokenContainer();
                var tokenModel = tokenContainer.GetTokenByValue(token);
                if (tokenModel != null)
                {
                    actionContext.Request.Properties["tokenmodel"] = tokenModel;
                }
               
                return true;
            }
            if (info.IsDefined(typeof(WxAttribute)) || actionContext.ControllerContext.ControllerDescriptor.GetCustomAttributes<WxAttribute>().Any())
            {
                if (string.IsNullOrWhiteSpace(token))
                {
                    return false;
                }
                //判断token的有效性
                ITokenContainer tokenContainer = TokenContainerFactory.GetTokenContainer();
                var tokenModel = tokenContainer.GetTokenByValue(token);
                if (tokenModel == null)
                {
                    return false;
                }
                actionContext.Request.Properties["tokenmodel"] = tokenModel;
                return true;
            }

            if (actionContext.ControllerContext.ControllerDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any())
            {
                return true;
            }
            return false;
        }

        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if(!this.IsAuthorized(actionContext)){
                actionContext.CreateResponseResult("权限验证失败", false, "405");
            }
            //base.OnAuthorization(actionContext);
        }
        
    }
}

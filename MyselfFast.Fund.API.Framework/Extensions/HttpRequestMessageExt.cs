using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.API.Framework.Extensition;
using myselfFast.Fund.API.Framework.MessageHandler;
using myselfFast.Fund.Core.Configuration;
using myselfFast.Fund.API.Framework.Token;
using myselfFast.Component.Cache;
using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Services.Admin;
using myselfFast.Fund.Core.Component.Logging;

namespace myselfFast.Fund.API.Framework.Extensions
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Extensions
     *项目描述  ：
     *类名称    ：HttpRequestMessageExt
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : HttpRequestMessageExt
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017-04-03 18:54:55
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static class HttpRequestMessageExt
    {
        /// <summary>
        /// 获取当前请求的企业账号
        /// </summary>
        /// <param name="httpRequest"></param>
        /// <returns></returns>
        public static string GetAppAccount(this HttpRequestMessage httpRequest)
        {
            try
            {
                ServiceAccount serviceAccount = (ServiceAccount)httpRequest.Properties[SignParamter.AppAccount];

                if (serviceAccount == null)
                {
                    return "";
                }
                return serviceAccount.AppId;
            }
            catch
            {
                return "";
            } 
        }
        /// <summary>
        /// token登录用户获取当前登录用户信息
        /// </summary>
        /// <param name="httpRequest"></param>
        /// <returns></returns>
        public static T_Admin_Account GetTokenAccount(this HttpRequestMessage httpRequest)
        {
            T_Admin_Account account = null;
           
            ICacheStorage cacheStorage = EngineContext.Current.Resolve<ICacheStorage>();
            IAdminAccountService accountService = EngineContext.Current.Resolve<IAdminAccountService>();
            ILoggerProviderFactory logFactory = EngineContext.Current.Resolve<ILoggerProviderFactory>();
            string key_prex = "admin_api_account_";
            try
            {
                 var tokenModel = (TokenModel)httpRequest.Properties["tokenmodel"];
                 if (tokenModel != null && tokenModel.AdminId != 0)
                 {
                     string key = key_prex + tokenModel.AdminId;

                     if (cacheStorage.Exists(key))
                     {
                         return cacheStorage.Get<T_Admin_Account>(key).Value;
                     }

                     account = accountService.GetAccountById(tokenModel.AdminId);
                     if (account != null)
                     {
                         cacheStorage.Set<T_Admin_Account>(key, new CacheValue<T_Admin_Account>(account, true));
                     }
                     return account;
                 }
                 
            }catch(Exception ex){
                logFactory.CreateDefaultLogger().Error(null, "GetTokenAccount", ex);
            }
            return account;
        }
        /// <summary>
        /// 获取本次请求的签名
        /// </summary>
        /// <param name="httpRequest"></param>
        /// <returns></returns>
        public static string GetSign(this HttpRequestMessage httpRequest)
        {
            
            try
            {
                var values = httpRequest.Properties[SignParamter.Signature];
                if (values == null)
                {
                    return "";
                }
                return values.ToString();
            }
            catch
            {
                return "";
            } 
        }
        /// <summary>
        /// 判断请求action是否需要验证授权
        /// </summary>
        /// <param name="httpRequest"></param>
        /// <returns></returns>
        public static bool SkipAuthorization(this HttpRequestMessage httpRequest)
        {
            var values = httpRequest.GetRouteData().Values;
            bool flag = httpRequest.GetActionDescriptor().GetCustomAttributes<AllowAnonymousAttribute>().Any<AllowAnonymousAttribute>() || httpRequest.GetActionDescriptor().ControllerDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any<AllowAnonymousAttribute>();
            return flag;            
        }
        /// <summary>
        /// 判断请求格式
        /// </summary>
        /// <param name="httpRequest"></param>
        /// <returns></returns>
        public static bool IsJsonp(this HttpRequestMessage httpRequest)
        {
            if (httpRequest.RequestUri.PathAndQuery.Contains("format"))
            {
                string format = httpRequest.GetQueryNameValuePairs().GetParamter("TOKEN").Value.EncodingToUtf8();
                if (format == "jsonp")
                {
                    return true;
                }
            }
            return false; 
        }
        /// <summary>
        /// 获取请求认证方式
        /// </summary>
        /// <returns></returns>
        public static AuthorizationMode GetAuthorizationMode(this HttpRequestMessage httpRequest)
        {
            if (httpRequest.GetQueryNameValuePairs().Any(a => a.Key == "WXTICKET"))
            {

                return AuthorizationMode.USERACCOUNT;
            }
           
            
            return AuthorizationMode.APPACCOUNT;           
        }
        /// <summary>
        /// 获取url请求参数
        /// </summary>
        /// <param name="httpRequest"></param>
        /// <param name="paramKey"></param>
        /// <returns></returns>
        public static string GetParam(this HttpRequestMessage httpRequest,string paramKey)
        {
            return httpRequest.GetQueryNameValuePairs().Where(w => w.Key == paramKey).First().Value;
        }

    }


}

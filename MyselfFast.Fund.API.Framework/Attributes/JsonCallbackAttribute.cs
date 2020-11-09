using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using myselfFast.Fund.API.Framework.Extensition;
using myselfFast.Fund.Core.Common.Extensions;

namespace myselfFast.Fund.API.Framework.Attributes
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Attributes
     *项目描述  ：
     *类名称    ：JsonCallbackAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : JsonCallbackAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017-04-07 14:36:29
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class JsonCallbackAttribute : ActionFilterAttribute
    {
        private const string CallbackQueryParameter = "callback";
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var callback = string.Empty;
            if (IsJosnp(actionExecutedContext,out callback))
            {
                var jsonBuilder = new StringBuilder(callback);
                jsonBuilder.AppendFormat("({0})", actionExecutedContext.Response.Content.ReadAsStringAsync().Result);
                actionExecutedContext.Response.Content = new StringContent("C(\"a\")");
            }
            base.OnActionExecuted(actionExecutedContext);
        }
        private bool IsJosnp(HttpActionExecutedContext actionExecutedContext, out string callback)
        {
            callback = actionExecutedContext.Request.GetQueryNameValuePairs().GetParamter(CallbackQueryParameter).Value.EncodingToUtf8();
            return !string.IsNullOrEmpty(callback);
        }
    }
}

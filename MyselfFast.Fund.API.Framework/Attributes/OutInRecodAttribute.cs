using myselfFast.Component.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace myselfFast.Fund.API.Framework.Attributes
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Attributes
     *项目描述  ：接口输出输入记录
     *类名称    ：OutInRecodAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : OutInRecodAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/12/27 20:59:27
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/

    public class OutInRecodAttribute : System.Web.Http.Filters.ActionFilterAttribute
    {
        private const string LogIdentityUnique = "LogIdentityUnique";
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            //输入记录
            string str = actionContext.Request.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            string guid = Guid.NewGuid().ToString();
            actionContext.Request.Properties.Add(new KeyValuePair<string, object>(LogIdentityUnique, guid));
            string strIn = string.Format("\r\n============{3}:InPut-Begin==============\r\n请求地址：{0}\r\n输入：{1}\r\n请求发起时间{2}\r\n=============InPut-End=============\r\n", actionContext.Request.RequestUri.OriginalString,
                str, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"),guid);
            Task t = new Task(() => LoggerProviderFactory.CreateLogger().Info(actionContext.GetType(),strIn));
            t.Start();
            base.OnActionExecuting(actionContext);
        }

        public override void OnActionExecuted(System.Web.Http.Filters.HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception == null)
            {
                object guid;
                actionExecutedContext.Request.Properties.TryGetValue(LogIdentityUnique, out guid);
                //输出记录
                string str = actionExecutedContext.Response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                string strOut = string.Format("\r\n============{3}:OutPut-Begin==============\r\n请求地址：{0}\r\n输出：{1}\r\n请求发起时间{2}\r\n==============OutPut-End=============\r\n", actionExecutedContext.Request.RequestUri.OriginalString,
                   str, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), guid.ToString());
                Task t = new Task(() => LoggerProviderFactory.CreateLogger().Info(actionExecutedContext.GetType(), strOut));
                t.Start();
            }
            base.OnActionExecuted(actionExecutedContext);
        }

    }
}

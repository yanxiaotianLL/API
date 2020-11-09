using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using System.Web.Http.ModelBinding;

namespace myselfFast.Fund.API.Framework.Attributes
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Attributes
     *项目描述  ：跨域支持过滤器
     *类名称    ：CrossDomainAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : CrossDomainAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/16 21:35:25
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
     [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class CrossDomainAttribute : ActionFilterAttribute
    {
          
           
            public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
            {
                //actionExecutedContext.ActionContext.ModelState.IsValid()
                actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:12124");
                actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type");
                actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
            }
       
    }
}

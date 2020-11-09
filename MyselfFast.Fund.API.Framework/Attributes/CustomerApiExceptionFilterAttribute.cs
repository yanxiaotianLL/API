using myselfFast.Fund.API.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using myselfFast.Fund.API.Framework.Extensition;
using myselfFast.Component.Logging;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.API.Framework.MessageHandler.IpAndDomanFilter;
using myselfFast.Fund.API.Framework.Extensions;
namespace myselfFast.Fund.API.Framework.Attributes
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Attributes
     *项目描述  ：API全局异常处理
     *类名称    ：CustomerApiExceptionFilterAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : CustomerApiExceptionFilterAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/16 21:40:02
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class CustomerApiExceptionFilterAttribute : ExceptionFilterAttribute
    {
       
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            //获取日志记录组件
            ILoggerProviderFactory loggerProviderFactory = EngineContext.Current.Resolve<ILoggerProviderFactory>();
            var logger = loggerProviderFactory.CreateLogger(LoggerType.ApiInputLogEntity);
            myselfFast.Fund.Core.Component.Logging.ApiInputLogEntity logEntity = new Core.Component.Logging.ApiInputLogEntity()
            {
                AccountType = "Enterprise",              
                Region = "myselfFast.Fund.Api"
            };

            string errorMessage = string.Empty;
            if (actionExecutedContext == null)
            {
                errorMessage = string.Format("actionExecutedContext为空！");
                throw new ArgumentNullException(errorMessage);
            }
            else
            {
                string actionname = actionExecutedContext.ActionContext.ActionDescriptor.ActionName;
                string controlername = actionExecutedContext.ActionContext.ControllerContext.ControllerDescriptor.ControllerName;
                            
                
                //定义日志记录对象
                logEntity.AccountName = actionname;
                logEntity.Controller = controlername;
                logEntity.HttpMethod = actionExecutedContext.Request.Method.Method;
                logEntity.Ip = actionExecutedContext.Request.GetClientIpAddress();
                logEntity.OriginalString = actionExecutedContext.Request.RequestUri.OriginalString;
                logEntity.RequestTime = DateTime.Now;
                logEntity.AccountName = actionExecutedContext.Request.GetAppAccount();
                logEntity.Sign = actionExecutedContext.Request.GetSign();
            }
            logger.Error(this, logEntity, actionExecutedContext.Exception);
            actionExecutedContext.ActionContext.CreateResponseResult("系统异常，请联系管理员", false);
            base.OnException(actionExecutedContext);
        }
    }
}

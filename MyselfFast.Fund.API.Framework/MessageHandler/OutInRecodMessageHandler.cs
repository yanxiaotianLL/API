using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using myselfFast.Fund.API.Framework.Extensions;
using myselfFast.Fund.API.Framework.MessageHandler.IpAndDomanFilter;
using myselfFast.Fund.API.Framework.Models;
using myselfFast.Component.Logging;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Infrastructure;
using System.Diagnostics;
using myselfFast.Fund.Core.Configuration;

namespace myselfFast.Fund.API.Framework.MessageHandler
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.MessageHandler
     *项目描述  ：
     *类名称    ：OutInRecodMessageHandler
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : OutInRecodMessageHandler
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/7 17:23:17
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 用于日志记录
    /// </summary>
    public class OutInRecodMessageHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            //计算接口所消耗的时间
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //获取日志记录组件
            ILoggerProviderFactory loggerProviderFactory = EngineContext.Current.Resolve<ILoggerProviderFactory>();
            var logger = loggerProviderFactory.CreateLogger(LoggerType.ApiInputLogEntity);
            //定义日志记录对象
            string controller = null;
            string action = null;
            foreach(var item in request.GetRequestContext().RouteData.Values){
                if(item.Key == "controller"){
                    controller = item.Value.ToString();
                }
                if(item.Key == "action"){
                    action = item.Value.ToString();
                }
            }
            
            
            myselfFast.Fund.Core.Component.Logging.ApiInputLogEntity logEntity = new Core.Component.Logging.ApiInputLogEntity()
            {
                AccountType = "Enterprise",
                Action = action,
                Controller = controller,
                Region = "myselfFast.Fund.Api"      
               
                   
            };

            
            logEntity.HttpMethod = request.Method.Method;
            logEntity.Ip = request.GetClientIpAddress();
            logEntity.OriginalString = request.RequestUri.OriginalString;
            logEntity.RequestTime = DateTime.Now;
           
            if (request.Content != null)
            {               
                logEntity.RequestContent = request.Content.ReadAsStringAsync().Result;               
            }
           
            return base.SendAsync(request, cancellationToken).ContinueWith<HttpResponseMessage>(task =>
            {
                
                try
                {
                    //获取响应内容
                    string strContent = task.Result.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    logEntity.ResponseContent = strContent;
                    stopwatch.Stop();
                    logEntity.Expire = (int)stopwatch.ElapsedMilliseconds;
                    logEntity.AccountName = request.GetAppAccount();
                    logEntity.Sign = request.GetSign();
                    logger.Info(this, logEntity);
                   
                }
                catch (Exception ex)
                {
                    
                    stopwatch.Stop();
                    logEntity.Expire = (int)stopwatch.ElapsedMilliseconds;
                    logger.Error(this, logEntity,ex);
                }
               
                return task.Result;
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.API.Framework.Extensions;
using myselfFast.Fund.API.Framework.Models;

namespace myselfFast.Fund.API.Framework.MessageHandler.IpAndDomanFilter
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.MessageHandler
     *项目描述  ：IP和域名过滤
     *类名称    ：IPAndDominFilterMessageHandler
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : IPAndDominFilterMessageHandler
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/14 23:38:37
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class IPAndDominFilterMessageHandler : DelegatingHandler
    {

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
           
                bool isIp = myselfFast.Fund.API.Framework.MessageHandler.IpAndDomanFilter.GlobalConfiguration.Configuration.IsIpSwitch
                    ? request.IsIpAllowed()
                    : true;

                if (isIp)
                {

                    return base.SendAsync(request, cancellationToken);
                }
                else
                {
                    var message = request.CreateResponse(new ResponseBase<object>()
                    {
                        Code = "5",
                        Data = null,
                        Message = string.Format("[IP:{0}]地址不在请求允许的范围内！", request.GetClientIpAddress()),
                        Success = false
                    });
                    message.StatusCode = HttpStatusCode.OK;
                    return Task.FromResult<HttpResponseMessage>(message);
                   
                }         

            
        }
    }
}

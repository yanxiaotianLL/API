using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.MessageHandler.IpAndDomanFilter
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.MessageHandler.IpAndDomanFilter
     *项目描述  ：
     *类名称    ：HttpRequestMessageExtensions
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : HttpRequestMessageExtensions
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/15 0:34:02
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static  class HttpRequestMessageExtensions
    {
        private const string HttpContext = "MS_HttpContext";
        private const string RemoteEndpointMessage = "System.ServiceModel.Channels.RemoteEndpointMessageProperty";
        private const string OwinContext = "MS_OwinContext";

        public static string GetClientIpAddress(this HttpRequestMessage request)
        {
            //Web-hosting
            if (request.Properties.ContainsKey(HttpContext))
            {
                dynamic ctx = request.Properties[HttpContext];
                if (ctx != null)
                {
                    return ctx.Request.UserHostAddress;
                }
            }
            //Self-hosting
            if (request.Properties.ContainsKey(RemoteEndpointMessage))
            {
                dynamic remoteEndpoint = request.Properties[RemoteEndpointMessage];
                if (remoteEndpoint != null)
                {
                    return remoteEndpoint.Address;
                }
            }
            //Owin-hosting
            if (request.Properties.ContainsKey(OwinContext))
            {
                dynamic ctx = request.Properties[OwinContext];
                if (ctx != null)
                {
                    return ctx.Request.RemoteIpAddress;
                }
            }
            return null;
        }

        public static bool IsIpAllowed(this HttpRequestMessage request)
        {
            if (!request.GetRequestContext().IsLocal)
            //if (true)
            {
                string ipAddress = request.GetClientIpAddress();
                var ipFilters =
                    myselfFast.Fund.API.Framework.MessageHandler.IpAndDomanFilter.GlobalConfiguration.Configuration.IpFilterings;
                if (ipFilters != null)
                {
                    if (ipFilters.Any(w => w.FilterType == FilterType.Allowed))
                    {
                        return ipFilters.Any(w => w.IpAddress == ipAddress && w.FilterType == FilterType.Allowed);
                    }
                    else
                    {
                        return !ipFilters.Any(w => w.IpAddress == ipAddress && w.FilterType == FilterType.Denied);
                    }
                   
                }
                return false;
            }
            return true;
        }
        


    }
}

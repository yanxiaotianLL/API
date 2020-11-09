using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.API.Framework.Extensions;
using myselfFast.Fund.API.Framework.Extensition;
using myselfFast.Fund.API.Framework.Models;
using myselfFast.Fund.API.Framework.Token;
using LitJson2;
using myselfFast.Component.Cache;
using myselfFast.Fund.Core.Common.Extensions;

namespace myselfFast.Fund.API.Framework.MessageHandler
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.MessageHandler
     *项目描述  ：
     *类名称    ：TokenCheckMessageHandler
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : TokenCheckMessageHandler
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017-04-03 18:48:58
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class TokenCheckMessageHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
           
            //判断验证方式
            if (request.GetAuthorizationMode() != AuthorizationMode.USERACCOUNT)
            {
                return base.SendAsync(request, cancellationToken);
            }

            string token = request.GetQueryNameValuePairs().GetParamter("WXTICKET").Value.EncodingToUtf8(); ;
            request.Properties["TOKEN"] = token;

            string　content　;
            if (request.Method == HttpMethod.Post)
                {
                    content = request.Content.ReadAsStringAsync().GetAwaiter().GetResult();             
                    if(!string.IsNullOrEmpty(content)){
                         request.Properties["Model_Paramters"] = content;
                    }               


                }
                      

         

            return base.SendAsync(request, cancellationToken);
        }


     
    }

    
}

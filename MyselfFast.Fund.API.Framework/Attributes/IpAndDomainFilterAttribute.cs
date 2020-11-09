using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using myselfFast.Fund.API.Framework.MessageHandler.IpAndDomanFilter;

namespace myselfFast.Fund.API.Framework.Attributes
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Attributes
     *项目描述  ：
     *类名称    ：IpAndDomainFilterAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : IpAndDomainFilterAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/15 1:03:01
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class IpAndDomainFilterAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            bool isIp = myselfFast.Fund.API.Framework.MessageHandler.IpAndDomanFilter.GlobalConfiguration.Configuration.IsIpSwitch
                ? actionContext.Request.IsIpAllowed()
                : true;
            return isIp;

        }
    }
}

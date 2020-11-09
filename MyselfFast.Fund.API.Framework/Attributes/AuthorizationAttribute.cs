using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using myselfFast.Fund.API.Framework.Extensions;
using myselfFast.Fund.API.Framework.Extensition;
using myselfFast.Fund.API.Framework.MessageHandler;
using myselfFast.Fund.Core.Configuration;

namespace myselfFast.Fund.API.Framework.Attributes
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Attributes
     *项目描述  ：
     *类名称    ：AuthorizationAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : AuthorizationAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/19 22:24:51
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public   class AuthorizationAttribute:System.Web.Http.AuthorizeAttribute
    {
        protected override bool IsAuthorized(System.Web.Http.Controllers.HttpActionContext actionContext)
        {

            if (actionContext.Request.GetAuthorizationMode() != AuthorizationMode.APPACCOUNT)
            {
                return true;
            }

            //判断验证方式
            #region 企业账户验证方式
           
                //获取appcacount对象
                ServiceAccount serviceAccount = null;
                if (actionContext.Request.Properties.Keys.Any(a => a == SignParamter.AppAccount))
                {
                    serviceAccount = (ServiceAccount)actionContext.Request.Properties[SignParamter.AppAccount];
                }
                else
                {
                    return false;
                }
                //获取ControllerName
                string controllerName = actionContext.ControllerContext.ControllerDescriptor.ControllerName;
                //获取ActionName
                string actionName = actionContext.ActionDescriptor.ActionName;

                //判断授权类型
                if (serviceAccount.RightType == RightType.All)
                {
                    return true;
                }
                else if (serviceAccount.RightType == RightType.Contain)//包含
                {
                    //controller权限验证通过
                    if (serviceAccount.RightList != null && serviceAccount.RightList.Any(s => s.Controller == controllerName))
                    {
                        if (serviceAccount.RightList.Where(s=>s.Controller == controllerName).Single().Actions == null ||
                            serviceAccount.RightList.Where(s=>s.Controller == controllerName).Single().Actions.Count == 0)
                        {
                            return true;
                        }
                        if (serviceAccount.RightList.Where(s=>s.Controller == controllerName).Single().Actions.Contains(actionName))
                        {
                            return true;
                        }
                        actionContext.CreateResponseResult("你没有该资源的访问权限，如有必要请联系管理员。", false);
                        return false;
                    }
                }
                else if (serviceAccount.RightType == RightType.Exclude)//排除
                {
                    if (serviceAccount.RightList != null &&
                        serviceAccount.RightList.Any(s => s.Controller == controllerName))
                    {
                        if (serviceAccount.RightList.Where(s=>s.Controller == controllerName).Single().Actions == null ||
                            serviceAccount.RightList.Where(s=>s.Controller == controllerName).Single().Actions.Contains(actionName))
                        {
                            actionContext.CreateResponseResult("你没有该资源的访问权限，如有必要请联系管理员。", false);
                            return false;
                        }
                        return true;
                    }
                    return true;
                }
           
            #endregion    

            return false;
        }

        public override void OnAuthorization(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if (!this.IsAuthorized(actionContext))
            {
                 actionContext.CreateResponseResult("权限验证失败",false,"405");
            }
            
        }
       
    }
}

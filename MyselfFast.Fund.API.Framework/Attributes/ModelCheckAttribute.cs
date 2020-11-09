using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.ModelBinding;
using myselfFast.Fund.API.Framework.Extensition;
using LitJson2;

namespace myselfFast.Fund.API.Framework.Attributes
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Attributes
     *项目描述  ：
     *类名称    ：ModelCheckAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ModelCheckAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/12/27 14:30:45
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class ModelCheckAttribute:System.Web.Http.Filters.ActionFilterAttribute
    {

        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            //验证modelstate
            if (!actionContext.ModelState.IsValid)
            {

                actionContext.CreateResponseResult(GetAllErrorMessage(actionContext), false);
            }
            else
            {
                //dynamic
                if (actionContext.Request.GetActionDescriptor()
                    .GetCustomAttributes<DynamicRequestAttribute>()
                    .Any<DynamicRequestAttribute>() ||
                    actionContext.Request.GetActionDescriptor()
                        .ControllerDescriptor.GetCustomAttributes<DynamicRequestAttribute>()
                        .Any<DynamicRequestAttribute>())
                {

                }
                else
                {
                    if (actionContext.ActionDescriptor.GetParameters().Any() && !actionContext.ActionArguments.Any())
                    {
                        actionContext.CreateResponseResult("请求参数不能为空！", false);
                    }
                }
            }
           

            base.OnActionExecuting(actionContext);
        }
      
        #region model校验
        private string GetAllErrorMessage(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in actionContext.ModelState)
            {
                sb.Append(string.Format("{0}:{1};", item.Key, GetErrorMessage(item.Value.Errors)));
            }
            return sb.ToString();
        }

        private string GetErrorMessage(IList<ModelError> errors)
        {
            StringBuilder sb = new StringBuilder();
            if (errors != null && errors.Count > 0)
            {
                foreach (var item in errors)
                {
                    sb.Append(item.ErrorMessage + ",");
                }
            }
            return sb.ToString();
        } 
        #endregion

        

    }

    

}

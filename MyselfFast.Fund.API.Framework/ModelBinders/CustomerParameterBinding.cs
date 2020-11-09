using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Controllers;

using myselfFast.Fund.API.Framework.Attributes;
using myselfFast.Fund.API.Framework.Extensition;
using myselfFast.Fund.API.Framework.Models;
using myselfFast.Fund.Core.Common;

namespace myselfFast.Fund.API.Framework.ModelBinders
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.ModelBinders
     *项目描述  ：
     *类名称    ：CustomerParameterBinding
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : CustomerParameterBinding
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/7 20:17:33
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class CustomerParameterBinding : HttpParameterBinding
    {
        public CustomerParameterBinding(HttpParameterDescriptor descripter) :
            base(descripter)
        {

        }
        public override System.Threading.Tasks.Task ExecuteBindingAsync(System.Web.Http.Metadata.ModelMetadataProvider metadataProvider, HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken)
        {
            bool flag = true;
            //参数匹配
            var jsonParmters = string.Empty;
            if (actionContext.Request.Properties.Keys.Contains("Model_Paramters") && actionContext.Request.Properties["Model_Paramters"] != null)
            {
                jsonParmters = actionContext.Request.Properties["Model_Paramters"].ToString();
            }
            //actionContext.ActionDescriptor.GetParameters()
            //获取action参数
            if (!string.IsNullOrEmpty(jsonParmters))
            {

                try
                {

                    Type m = actionContext.ControllerContext.Controller.GetType();
                    MethodInfo info = m.GetMethod(actionContext.ActionDescriptor.ActionName);
                    ParameterInfo[] paramterInfos = info.GetParameters();
                    ParameterInfo paramterInfo = paramterInfos.Single();
                    Type infoType = paramterInfo.ParameterType;

                    //dynamic
                    if (
                        actionContext.Request.GetActionDescriptor()
                            .GetCustomAttributes<DynamicRequestAttribute>()
                            .Any<DynamicRequestAttribute>() ||
                        actionContext.Request.GetActionDescriptor()
                            .ControllerDescriptor.GetCustomAttributes<DynamicRequestAttribute>()
                            .Any<DynamicRequestAttribute>())
                    {
                        var model = JsonHelper.DeserializeJsonToObject<dynamic>(jsonParmters.ToString());
                        SetValue(actionContext, model);
                        var tscs = new TaskCompletionSource<HttpResponseMessage>();
                        tscs.SetResult(null);
                        return tscs.Task;
                    }
                    var infoModel = Activator.CreateInstance(infoType);
                    JsonHelper.DeserializeJsonToObject(jsonParmters.ToString(), ref infoModel);
                    SetValue(actionContext, infoModel);

                    var modelStateResult = new List<ValidationResult>();
                    Validator.TryValidateObject(infoModel, new ValidationContext(infoModel),
                        modelStateResult, true);

                    if (modelStateResult.Any())
                    {

                        foreach (var r in modelStateResult)
                        {
                            if (r.MemberNames != null && r.MemberNames.Any())
                            {
                                actionContext.ModelState.AddModelError(r.MemberNames.Single(), r.ErrorMessage);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else
            {
                //dynamic
                if (actionContext.Request.GetActionDescriptor().GetCustomAttributes<DynamicRequestAttribute>().Any<DynamicRequestAttribute>() || actionContext.Request.GetActionDescriptor().ControllerDescriptor.GetCustomAttributes<DynamicRequestAttribute>().Any<DynamicRequestAttribute>())
                {
                    var model = JsonHelper.DeserializeJsonToObject<dynamic>("{}");
                    SetValue(actionContext, model);
                    var tscs = new TaskCompletionSource<HttpResponseMessage>();
                    tscs.SetResult(null);
                    return tscs.Task;
                }
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(null);
            return tsc.Task;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.API.Framework.Models;
using myselfFast.Fund.API.Framework.Token;

namespace myselfFast.Fund.API.Framework.Extensition
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Extensition
     *项目描述  ：
     *类名称    ：HttpActionExtensition
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : HttpActionExtensition
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/17 14:48:15
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  static class HttpActionExtensition
    {
       /// <summary>
        /// 构造返回结果
       /// </summary>
       /// <param name="actionContext"></param>
       /// <param name="message"></param>
       /// <param name="success"></param>
        public static  void  CreateResponseResult<T>(this System.Web.Http.Controllers.HttpActionContext actionContext,string message,bool success)
            where T :new()
        {
            actionContext.Response = actionContext.ActionDescriptor.ResultConverter.Convert
            (actionContext.ControllerContext, (new ResponseBase<T> { Data = default(T), Message = message, Success = success }));
        }

        /// <summary>
        /// 构造返回结果
        /// </summary>
        /// <param name="actionContext"></param>
        /// <param name="message"></param>
        /// <param name="success"></param>
        public static void CreateResponseResult(this System.Web.Http.Controllers.HttpActionContext actionContext, string message, bool success)
        {
            Type returnType = actionContext.ActionDescriptor.ReturnType;
            var result = Activator.CreateInstance(returnType);
            PropertyInfo[] propertyInfos = returnType.GetProperties();
            if (propertyInfos != null && propertyInfos.Count() > 0)
            {
                foreach (var p in propertyInfos)
                {
                    if (p.Name == "Data")
                    {
                        p.SetValue(result, null);
                    }
                    if (p.Name == "Message")
                    {
                        p.SetValue(result, message);
                    }
                    if (p.Name == "Success")
                    {
                        p.SetValue(result, false);
                    }
                    if (p.Name == "Code")
                    {
                        p.SetValue(result, "3");
                    }
                }
            }
            actionContext.Response = actionContext.ActionDescriptor.ResultConverter.Convert
            (actionContext.ControllerContext, result);
        }
        /// <summary>
        /// 构造返回结果
        /// </summary>
        /// <param name="actionContext"></param>
        /// <param name="message"></param>
        /// <param name="success"></param>
        public static void CreateResponseResult(this System.Web.Http.Controllers.HttpActionContext actionContext, string message, bool success,string code)
        {
            Type returnType = actionContext.ActionDescriptor.ReturnType;
            var result = Activator.CreateInstance(returnType);
            PropertyInfo[] propertyInfos = returnType.GetProperties();
            if (propertyInfos != null && propertyInfos.Count() > 0)
            {
                foreach (var p in propertyInfos)
                {
                    if (p.Name == "Data")
                    {
                        p.SetValue(result, null);
                    }
                    if (p.Name == "Message")
                    {
                        p.SetValue(result, message);
                    }
                    if (p.Name == "Success")
                    {
                        p.SetValue(result, success);
                    }
                    if (p.Name == "Code")
                    {
                        p.SetValue(result, code);
                    }
                }
            }
            actionContext.Response = actionContext.ActionDescriptor.ResultConverter.Convert
            (actionContext.ControllerContext, result);
        }
        /// <summary>
        /// 用于缓存接口输出
        /// </summary>
        /// <param name="actionContext"></param>
        /// <param name="message"></param>
        /// <param name="success"></param>
        public static void CreateResponseResultForCache(this System.Web.Http.Controllers.HttpActionContext actionContext, string message, bool success,object cacheResult)
        {
            Type returnType = actionContext.ActionDescriptor.ReturnType;
            var result = Activator.CreateInstance(returnType);
            PropertyInfo[] propertyInfos = returnType.GetProperties();
            if (propertyInfos != null && propertyInfos.Count() > 0)
            {
                foreach (var p in propertyInfos)
                {
                    if (p.Name == "Data")
                    {
                        p.SetValue(result, null);
                    }
                    if (p.Name == "Message")
                    {
                        p.SetValue(result, message);
                    }
                    if (p.Name == "Success")
                    {
                        p.SetValue(result, false);
                    }
                    if (p.Name == "Code")
                    {
                        p.SetValue(result, "3");
                    }
                }
            }
            actionContext.Response = actionContext.ActionDescriptor.ResultConverter.Convert
            (actionContext.ControllerContext, result);
        }
    }
}

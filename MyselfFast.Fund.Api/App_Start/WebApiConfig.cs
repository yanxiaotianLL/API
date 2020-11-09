using myselfFast.Fund.API.Framework.Attributes;
using myselfFast.Fund.API.Framework.MessageHandler;
using myselfFast.Fund.API.Framework.ModelBinders;
using System.Web.Http;

namespace myselfFast.Fund.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //全局异常日志记录
            config.Filters.Add(new CustomerApiExceptionFilterAttribute());
            //权限校验
            config.Filters.Add(new AuthorizationAttribute());
            config.Filters.Add(new TokenAuthenticationAttribute());
            //模型验证
            config.Filters.Add(new ModelCheckAttribute());
            //日志记录组件
            config.MessageHandlers.Add(new OutInRecodMessageHandler());
            //ip权限验证
            //config.MessageHandlers.Add(new IPAndDominFilterMessageHandler());
            //企业账号签名校验
            config.MessageHandlers.Add(new SignCheckMessageHandler());
            config.MessageHandlers.Add(new TokenCheckMessageHandler());
            System.Web.Http.GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            //序列化工具注入
            //config.Formatters.Remove(config.Formatters.JsonFormatter);
            //config.Formatters.Insert(0, new JilFormatter());
            //模型绑定
            config.ParameterBindingRules.Insert(0, (decriptor) =>
            {
                if (decriptor.ParameterType.IsClass)
                {
                    return new CustomerParameterBinding(decriptor);
                }
                return null;
            });



            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}"
                //,defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

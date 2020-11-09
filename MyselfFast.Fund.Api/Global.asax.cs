using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Component.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace myselfFast.Fund.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            LoggerProviderFactory.LogInit();
            
            var logger = new LoggerProviderFactory().CreateDefaultLogger();
            logger.Info(this, "\r\n============myselfFast.Fund.Api-Application_Start:Call-Start==============\r\n");
            //initialize engine context
            EngineContext.Initialize(true);
            logger.Info(this, "\r\n============myselfFast.Fund.Api-Application_Start:Call-End==============\r\n");

        }
    }
}

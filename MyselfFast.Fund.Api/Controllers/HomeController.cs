using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Component.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myselfFast.Fund.Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var  logger = EngineContext.Current.Resolve<ILoggerProviderFactory>().CreateLogger(LoggerType.ApiOutputLogEntity);

            //for (int i = 0; i < 10;i++ )
            //{
            //    ApiOutputLogEntity logEntity = new ApiOutputLogEntity()
            //    {
            //        AccountName = "",
            //        Expire = 23,
            //        RequestContent = "entity.OutIn",
            //        ResponseContent = "entity.OutPut",
            //        RequestTime = DateTime.Now

            //    };
            //    logger.Info(logEntity, "entity.OutIn");
            //}
            //ViewBag.Title = "Home Page";

            return View();
        }
    }
}

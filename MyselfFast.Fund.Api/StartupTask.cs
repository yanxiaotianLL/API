using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Fund.Services.Task;
using NewSystem.SDK.Entities.Request.FileService;
using NewSystem.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace myselfFast.Fund.Api
{
    /**********************************************************************************
	 *项目名称	：myselfFast.Fund.Admin
	 *项目描述  ：
	 *类名称    ：StartupTask
	 *版本号    ：v1.0.0
	 *机器名称  ：LIUYONG-PC
	 *项目名称  : StartupTask
	 *CLR版本   : 4.0.30319.42000
	 *作者      ：liu.yong
	 *创建时间  : 2018-01-23 17:34:12
	 *------------------------------------变更记录--------------------------------------
	 *变更描述  :
	 *变更作者  :
	 *变更时间  :
	***********************************************************************************/

    public class StartupTask : IStartupTask
    {
        public void Execute()
        {
            //定时任务开启

            var logger =  EngineContext.Current.Resolve<ILoggerProviderFactory>().CreateDefaultLogger();
            logger.Info(this, "定时任务初始化开始");
            SchedulerManger.StartSchudlerForApi();
            NewSystem.SDK.Config.GlobalConfiguration.Configuration.RegisterLoggerFactory(new myselfFast.Fund.Api.Infrastructure.NewSdk.SDKLoggerFactory());
            //var jiCaiTaskService = EngineContext.Current.Resolve<IJiCaiTaskService>();
            //jiCaiTaskService.TaskInit();

            //FileDown();
        
        }

        public int Order
        {
            get { return 150; }
        }

        
    }
}
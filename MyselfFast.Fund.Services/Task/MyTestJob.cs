using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Component.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Task
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Services.Task
     *项目描述  ：
     *类名称    ：MyTestJob
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : MyTestJob
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-23 16:45:14
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class MyTestJob:IJob
    {
        ILoggerProviderFactory loggerFactory = EngineContext.Current.Resolve<ILoggerProviderFactory>();
        
        public void Execute(IJobExecutionContext context)
        {
            var logger = loggerFactory.CreateDefaultLogger();
            logger.Error(this,"MyTestJob已经执行");
        }
    }
}

using myselfFast.Component.Logging;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Task
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Services.Task
     *项目描述  ：
     *类名称    ：MySchedulerPlugin
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : MySchedulerPlugin
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-23 11:12:53
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// SchedulerPlugin插件
    /// </summary>
    public class MySchedulerPlugin : ISchedulerPlugin
    {
        ILogger logger = LoggerProviderFactory.CreateLogger();
        public void Initialize(string pluginName, Quartz.IScheduler sched)
        {
            logger.Info(null,"定时任务调度中心初始化");
        }

        public void Shutdown()
        {
            logger.Info(null, "定时任务调度中心关闭");
        }

        public void Start()
        {
            logger.Info(null, "定时任务调度中心开启");
        }
    }
}

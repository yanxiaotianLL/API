using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Component.Task;
using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Fund.Core.Common;
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
     *类名称    ：SchedulerManger
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : SchedulerManger
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-23 13:43:24
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 定时任务管理器
    /// </summary>
    public  class SchedulerManger
    {
        /// <summary>
        /// 用于myselfFast.Fund.Api 项目
        /// </summary>
        public static void StartSchudlerForApi()
        {

            //var logger = EngineContext.Current.Resolve<ILoggerProviderFactory>().CreateDefaultLogger();
           
            //var scheduler = QuartzHelper.GetScheduler();

            //#region 每天 01:00 开始执行数据解析任务

            //var job = JobBuilder.Create<TaskDataInitJob>()
            //           .WithIdentity("mytrigger", "TaskDataInit")
            //           .Build();
            ////字段名	允许的值	允许的特殊字符
            ////Seconds	0-59	, - * /
            ////Minutes	0-59	, - * /
            ////Hours	0-23	, - * /
            ////Day of month	1-31	, - * ? / L W
            ////Month	1-12 or JAN-DEC	, - * /
            ////Day of week	1-7 or SUN-SAT	, - * ? / L #
            ////Year	空, 1970-2099	, - * /

            //var withCronSchedule = XMLConfigHelper.GetValue("cronschedule");
            //logger.Info(scheduler, string.Format("\r\n=============定时任务时间=====【{0}】\r\n", withCronSchedule));
            //var trigger = TriggerBuilder.Create()
            //                    .WithIdentity("mytrigger", "TaskDataInit")
            //                    //.WithCronSchedule("0 0 1 * * ?")
            //                    .WithCronSchedule("0 0 0/1 * * ? *")
            //                    .WithCronSchedule(withCronSchedule).StartNow()
            //                    .Build();
            ////var trigger = TriggerBuilder.Create()
            ////                    .WithIdentity("mytrigger", "TaskDataInit")
            ////                    .WithSimpleSchedule((a) => { a.WithIntervalInMinutes(2); a.RepeatForever();}).StartNow().Build();

            //scheduler.ScheduleJob(job, trigger);

            //scheduler.Start();
            
            //#endregion
            

        }
        /// <summary>
        /// myselfFast.Fund.Admin项目
        /// </summary>
        public static void StartSchudlerForAdmin()
        {
            /*
            var scheduler = QuartzHelper.GetScheduler();

            #region MyTestJob
            var job = JobBuilder.Create<MyTestJob>()
                    .WithIdentity("mytrigger", "group1")
                    .Build();
            //字段名	允许的值	允许的特殊字符
            //Seconds	0-59	, - * /
            //Minutes	0-59	, - * /
            //Hours	0-23	, - * /
            //Day of month	1-31	, - * ? / L W
            //Month	1-12 or JAN-DEC	, - * /
            //Day of week	1-7 or SUN-SAT	, - * ? / L #
            //Year	空, 1970-2099	, - * /


            var trigger = TriggerBuilder.Create()
                                .WithIdentity("mytrigger", "group1")
                                .WithCronSchedule("/2 * * ? * *")
                                .Build();

            scheduler.ScheduleJob(job, trigger); 
            #endregion

            scheduler.Start();
           */
        }
    }
}

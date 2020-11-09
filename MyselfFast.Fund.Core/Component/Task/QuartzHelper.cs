using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Component.Task
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Component.Task
     *项目描述  ：
     *类名称    ：QuartzHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : QuartzHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-23 11:20:42
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static  class QuartzHelper
    {
        private static object _lock = new object();
        private static IScheduler scheduler;
        /// <summary>
        /// IScheduler
        /// </summary>
        /// <returns></returns>
        public static IScheduler GetScheduler()
        {
            if (scheduler == null)
            {
                lock (_lock)
                {
                    if (scheduler == null)
                    {
                        // First we must get a reference to a scheduler
                        NameValueCollection properties = new NameValueCollection();
                        //调度实例名称
                        properties["quartz.scheduler.instanceName"] = "myselfFast.CollectScheduler";
                        // Set thread count to 1 to force Triggers scheduled for the same time to 
                        // to be ordered by priority.
                        //线程池数量
                        properties["quartz.threadPool.threadCount"] = "1";
                        properties["quartz.threadPool.type"] = "Quartz.Simpl.SimpleThreadPool, Quartz";
                        //优先级
                        properties["quartz.threadPool.threadPriority"] = "Normal";
                        //持久化类型
                        properties["quartz.jobStore.type"] = "Quartz.Simpl.RAMJobStore, Quartz";


                        var schedulerFactory = new StdSchedulerFactory(properties);

                        scheduler = schedulerFactory.GetScheduler();
                        //scheduler = StdSchedulerFactory.GetDefaultScheduler();
                        
                        MyTriggerListener myTriggerListener = new Task.MyTriggerListener();
                        MyJobListener myJobListener = new Task.MyJobListener();
                        //添加监听器到指定的trigger myselfFast.Fund.Admin
                        //scheduler.ListenerManager.AddTriggerListener(myTriggerListener, KeyMatcher<TriggerKey>.KeyEquals(new TriggerKey("mytrigger", "group1")));
                        //scheduler.ListenerManager.AddJobListener(myJobListener, KeyMatcher<JobKey>.KeyEquals(new JobKey("mytrigger", "group1")));
                        //scheduler.ListenerManager.AddTriggerListener(myTriggerListener);
                        //scheduler.ListenerManager.AddJobListener(myJobListener);
                        
                    }
                }          
           
            }
            
            return scheduler;
        }


    }
}

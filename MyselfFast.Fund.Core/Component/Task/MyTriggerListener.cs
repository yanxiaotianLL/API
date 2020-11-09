using myselfFast.Component.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Component.Task
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Component.Task
     *项目描述  ：
     *类名称    ：MyTriggerListener
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : MyTriggerListener
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-23 11:18:17
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 触发器监听
    /// </summary>
    public  class MyTriggerListener : ITriggerListener
    {
      
        ILogger logger = LoggerProviderFactory.CreateLogger();
        private string triggerIdentity = string.Empty;
        public string Name
        {
            get { return "MyTriggerListener"; }
        }
        /**
        * (4) 任务完成时触发
        * Called by the Scheduler when a Trigger has fired, it's associated JobDetail has been executed
        * and it's triggered(xx) method has been called.
        */
        public void TriggerComplete(ITrigger trigger, IJobExecutionContext context, SchedulerInstruction triggerInstructionCode)
        {

            var jobTriggerData = trigger.JobDataMap.Get("MyTestJob");
            var jobData = context.JobDetail.JobDataMap.Get("MyTestJob");
            string data = string.Format("触发器标识:{0}\r\n,工作标识:{1}\r\n,时间:{2}执行完成={TriggerComplete}。", triggerIdentity, jobData, DateTime.Now);
            logger.Info(this, data);
            
        }
        /**
         * (1)
         * Trigger被激发 它关联的job即将被运行
         * Called by the Scheduler when a Trigger has fired, and it's associated JobDetail is about to be executed.
         */

        public void TriggerFired(ITrigger trigger, IJobExecutionContext context)
        {
            triggerIdentity = Guid.NewGuid().ToString();
            trigger.JobDataMap.Add("triggerIdentity", triggerIdentity);
            logger.Info(this, "TriggerFired:"+triggerIdentity);
        }
        /**
        * (3) 当Trigger错过被激发时执行,比如当前时间有很多触发器都需要执行，但是线程池中的有效线程都在工作，
        *  那么有的触发器就有可能超时，错过这一轮的触发。
        * Called by the Scheduler when a Trigger has misfired.
        */
        public void TriggerMisfired(ITrigger trigger)
        {


            string data = string.Format("触发器标识:{0}\r\n,时间:{1}- =TriggerMisfired。", triggerIdentity, DateTime.Now);
            logger.Info(this, data);
        }
        /**
         * (2)
         * Trigger被激发 它关联的job即将被运行,先执行(1)，在执行(2) 如果返回TRUE 那么任务job会被终止
         * Called by the Scheduler when a Trigger has fired, and it's associated JobDetail is about to be executed
         */
        public bool VetoJobExecution(ITrigger trigger, IJobExecutionContext context)
        {
            var data = "VetoJobExecution:" + triggerIdentity;
            logger.Info(this, data);
            return false;
        }
    }
}

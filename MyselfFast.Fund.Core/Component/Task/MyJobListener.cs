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
     *类名称    ：MyJobListener
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : MyJobListener
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-23 11:19:32
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 任务监听器
    /// </summary>
    public class MyJobListener : IJobListener
    {
        //private string identity;
        //public MyJobListener()
        //{
        //    identity = Guid.NewGuid().ToString();
        //}
        ILogger logger = LoggerProviderFactory.CreateLogger();
         
       
        /**
         * (1)
         * 任务执行之前执行
         * Called by the Scheduler when a JobDetail is about to be executed (an associated Trigger has occurred).
         */
        public void JobToBeExecuted(IJobExecutionContext context)
        {
            try
            {
                 //string identity = context.JobDetail.JobDataMap.Get("identityss").ToString();
            string identity = "ddd";
            var jobData = context.JobDetail.JobDataMap.Get("MyTestJob");
            string data = string.Format("【{2}】工作标识:{0}\r\n,时间:{1},JobToBeExecuted。", jobData, DateTime.Now, identity);
            logger.Info(this, data);
            }
            catch(Exception)
            {

            }
        }
       
         /**
          * (2)
          * 这个方法正常情况下不执行,但是如果当TriggerListener中的vetoJobExecution方法返回true时,那么执行这个方法.
          * 需要注意的是 如果方法(2)执行 那么(1),(3)这个俩个方法不会执行,因为任务被终止了嘛.
          * Called by the Scheduler when a JobDetail was about to be executed (an associated Trigger has occurred),
          * but a TriggerListener vetoed it's execution.
         */
        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            try
            {
                //string identity = context.JobDetail.JobDataMap.Get("identityss").ToString();
                string identity = "ddd";
                var jobData = context.JobDetail.JobDataMap.Get("MyTestJob");
                string data = string.Format("【{2}】工作标识:{0}\r\n,时间:{1},JobToBeExecuted。", jobData, DateTime.Now, identity);
                logger.Info(this, data);
            }
            catch (Exception)
            {

            }
        }
        
         /**
          * (3)
          * 任务执行完成后执行,jobException如果它不为空则说明任务在执行过程中出现了异常
          * Called by the Scheduler after a JobDetail has been executed, and be for the associated Trigger's triggered(xx) method has been called.
          */         
        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            try
            {
                //string identity = context.JobDetail.JobDataMap.Get("identityss").ToString();
                string identity = "ddd";
                var jobData = context.JobDetail.JobDataMap.Get("MyTestJob");
                string data = string.Format("【{2}】工作标识:{0}\r\n,时间:{1},JobWasExecuted。", jobData, DateTime.Now, identity);
                logger.Info(this, data);
            }
            catch (Exception)
            {

            }
        }

        public string Name
        {
            get { return "MyJobListener"; }
        }
    }
}

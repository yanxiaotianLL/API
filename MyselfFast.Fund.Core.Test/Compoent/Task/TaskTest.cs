using myselfFast.Fund.Core.Component.Task;
using log4net.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quartz;
using Quartz.Impl.Calendar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Test.Compoent.Task
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Test.Compoent.Task
     *项目描述  ：
     *类名称    ：TaskTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : TaskTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-25 12:11:00
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 定时任务测试
    /// </summary>
    [TestClass]
    public  class TaskTest
    {
        private IScheduler scheduler;
        [TestInitialize]
        public void Init()
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Config\Log4Net.config");
            if (!System.IO.File.Exists(logFilePath))
            {
                logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\Log4Net.config");
            }

            XmlConfigurator.ConfigureAndWatch(new FileInfo(logFilePath));
            scheduler = QuartzHelper.GetScheduler();
        }
        [TestMethod]
        public void TestSimpleTrigger()
        {
            IJobDetail jobDetail = JobBuilder.Create<MyTestJob>().WithIdentity("MyTestJobTrigger", "myselfFast.Fund.Admin").UsingJobData("MyTestJob", "MyTestJob")
                .Build();
            ITrigger trigger = TriggerBuilder.Create()
                .StartNow().WithIdentity("MyTestJobTrigger", "myselfFast.Fund.Admin").UsingJobData("MyTestJob", "MyTestJob")
                .WithSimpleSchedule(a=>a.WithInterval(TimeSpan.FromSeconds(1)).RepeatForever()
                    .WithMisfireHandlingInstructionFireNow().Build()).StartNow()
                .Build();
            
            scheduler.ScheduleJob(jobDetail, trigger);
            scheduler.Start();

            Thread.Sleep(TimeSpan.FromSeconds(10));
        }
        [TestMethod]
        public void TestCronTrigger()
        {
            IJobDetail jobDetail = JobBuilder.Create<MyTestJob>().WithIdentity("MyTestJobTrigger", "myselfFast.Fund.Admin").UsingJobData("MyTestJob", "MyTestJob")
              .Build();
            /*cron表达式
            字段名	允许的值	允许的特殊字符
            Seconds	0-59	, - * /
            Minutes	0-59	, - * /
            Hours	0-23	, - * /
            Day of month	1-31	, - * ? / L W
            Month	1-12 or JAN-DEC	, - * /
            Day of week	1-7 or SUN-SAT	, - * ? / L #
            Year	空, 1970-2099	, - * /  
 
            特殊字符	解释
            ,	或的意思。例：分钟位 5,10  即第5分钟或10分都触发。 
            /	a/b。 a：代表起始时间，b频率时间。 例； 分钟位  3/5，  从第三分钟开始，每5分钟执行一次。
            *	频率。 即每一次波动。    例；分钟位 *  即表示每分钟 
            -	区间。  例： 分钟位   5-10 即5到10分期间。 
            ?	任意值 。   即每一次波动。只能用在DayofMonth和DayofWeek，二者冲突。指定一个另一个一个要用?
            L	表示最后。 只能用在DayofMonth和DayofWeek，4L即最后一个星期三
            W	工作日。  表示最后。 只能用在DayofWeek
            #	4#2。 只能用DayofMonth。 某月的第二个星期三  
 
            实例介绍
            ”0 0 10,14,16 * * ?"    每天10点，14点，16点 触发。
            "0 0/5 14,18 * * ?"    每天14点或18点中，每5分钟触发 。
            "0 4/15 14-18 * * ?"       每天14点到18点期间,  从第四分钟触发，每15分钟一次。
            "0 15 10 ? * 6L"        每月的最后一个星期五上午10:15触发。

            */
            ITrigger trigger = TriggerBuilder.Create()
                .StartNow().WithIdentity("MyTestJobTrigger", "myselfFast.Fund.Admin").UsingJobData("MyTestJob", "MyTestJob")
                   .WithCronSchedule("5 * * * * ?", w => w.WithMisfireHandlingInstructionFireAndProceed().Build()).StartNow()
                .Build();

            scheduler.ScheduleJob(jobDetail, trigger);
            scheduler.Start();
            
            Thread.Sleep(TimeSpan.FromSeconds(240));
        }
        /*
            CronCalendar:使用表达式排除某些时间段不执行
            DailyCalendar：指定的时间范围内的每一天不执行
            HolidayCalendar：排除节假日
            MonthlyCalendar：排除月份中的数天
            WeeklyCalendar：排除星期中的一天或多天
                     */
        [TestMethod]
        public void TestCalendar()
        {
            // 定义日历
            AnnualCalendar holidays = new AnnualCalendar();

            // 排除7月4号
            DateTime fourthOfJuly = new DateTime(DateTime.UtcNow.Year, 7, 4);
            holidays.SetDayExcluded(fourthOfJuly, true);

            // 排除10月31号
            DateTime halloween = new DateTime(DateTime.UtcNow.Year, 10, 31);
            holidays.SetDayExcluded(halloween, true);

            // 排除12月25号
            DateTime christmas = new DateTime(DateTime.UtcNow.Year, 12, 25);
            holidays.SetDayExcluded(christmas, true);

            // 将日历加入调度中心
            scheduler.AddCalendar("holidays", holidays, false, false);

            
            // 10月31号0时0分10s开始执行
            DateTimeOffset runDate = DateBuilder.DateOf(0, 0, 10, 31, 10);

            IJobDetail job = JobBuilder.Create<MyTestJob>()
                .WithIdentity("MyTestJobTrigger", "myselfFast.Fund.Admin")
                .UsingJobData("MyTestJob", "MyTestJob")
                .Build();

            ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create()
                                                         .WithIdentity("MyTestJobTrigger", "myselfFast.Fund.Admin")
                                                         .UsingJobData("MyTestJob", "MyTestJob")
                                                          .StartAt(runDate)
                                                          .WithSimpleSchedule(x => x.WithIntervalInHours(1).RepeatForever())
                                                          //执行修饰日历
                                                          .ModifiedByCalendar("holidays")
                                                          .Build();

            //返回第一次执行的时间
            DateTimeOffset firstRunTime = scheduler.ScheduleJob(job, trigger);
            scheduler.Start();
        }
    }


}

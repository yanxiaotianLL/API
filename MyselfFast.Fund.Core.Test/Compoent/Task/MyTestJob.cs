using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Component.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Test.Compoent.Task
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
    [PersistJobDataAfterExecution]
    [DisallowConcurrentExecution]
    public class MyTestJob:IJob
    {
        public int count = 0;
        public void Execute(IJobExecutionContext context)
        {
            
            var log = LoggerProviderFactory.CreateLogger();
            count++;
            for (int i = 0; i < 12; i++)
            {
                log.Debug(this, string.Format("MyTestJob执行第几[{0}]次", count));
            }
        }
    }
}

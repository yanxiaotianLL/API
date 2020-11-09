using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Infrastructure
{
    /**********************************************************************************
     *项目名称	：FS.Component.Infrastructure
     *项目描述  ：
     *接口名称  ：IStartupTask
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : IStartupTask
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017-04-10 15:39:21
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// Interface which should be implemented by tasks run on startup
    /// </summary>
    public interface IStartupTask
    {
        /// <summary>
        /// Executes a task
        /// </summary>
        void Execute();

        /// <summary>
        /// Order
        /// </summary>
        int Order { get; }
    }
}

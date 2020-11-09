using myselfFast.Component.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Component.Logging
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Component.Logging
     *项目描述  ：
     *接口名称  ：ILoggerProviderFactory
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ILoggerProviderFactory
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-25 10:43:56
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public interface ILoggerProviderFactory
    {
        ILogger CreateDefaultLogger();
        ILogger CreateLogger(LoggerType type);
    }
}

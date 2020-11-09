using myselfFast.Fund.Core.Component.Logging;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.Logging
{
    /**********************************************************************************
     *项目名称	：FS.Component.Logging
     *项目描述  ：
     *类名称    ：LoggerProviderFactory
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : LoggerProviderFactory
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/16 23:15:11
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class LoggerProviderFactory : ILoggerProviderFactory
    {
        public static ILogger CreateLogger()
        {
            ILogger logger = new DefaultLogger("LogEntityLogger");       
            return logger;
        }
        public ILogger CreateDefaultLogger()
        {
            ILogger logger = new DefaultLogger("LogEntityLogger");
            return logger;
        }
        public ILogger CreateLogger(LoggerType type)
        {
            ILogger logger = null;
            switch (type)
            {
                case LoggerType.ApiInputLogEntity:
                    {
                        
                        logger = new DefaultLogger("ApiInputLogEntityLogger");
                        break;
                    }
                case LoggerType.ApiOutputLogEntity:
                    {
                        logger = new DefaultLogger("ApiOutputLogEntityLogger");
                        break;
                    }
                case LoggerType.LogEntity:
                    {
                        logger = new DefaultLogger("LogEntityLogger");
                        break;
                    }
                default:
                    {
                        logger = new DefaultLogger("LogEntityLogger");
                        break;
                    }

            }
            //logger = new DefaultLogger();
            return logger;
        }

        /// <summary>
        /// log4日志组件初始化
        /// </summary>
        public static void LogInit()
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"App_Data\Config\Log4Net.config");
            if (!System.IO.File.Exists(logFilePath))
            {
                logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\Log4Net.config");
            }
            if (!System.IO.File.Exists(logFilePath))
            {
                throw new FileNotFoundException(logFilePath + "文件不存在");
            }

            XmlConfigurator.ConfigureAndWatch(new FileInfo(logFilePath));
        }
    }
    public enum LoggerType
    {
        LogEntity = 0,
        ApiInputLogEntity = 1,
        ApiOutputLogEntity = 2
    }
}

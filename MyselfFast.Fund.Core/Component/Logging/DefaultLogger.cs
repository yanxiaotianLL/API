using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.Logging
{
    public class DefaultLogger : ILogger
    {
        private static Dictionary<string, ILog> _loggers = new Dictionary<string, ILog>();
        private object _lock = new object();
        #region 日志对象初始化
        private string loggerName;
        public DefaultLogger()
        {

        }
        public DefaultLogger(string loggerName)
        {
            this.loggerName = loggerName;
        }
        private ILog getLogger(Type source)
        {
            string key =source == null?loggerName: source.FullName + loggerName;
            lock (_lock)
            {
                if (_loggers.ContainsKey(key))
                {
                    return _loggers[key];
                }
                else
                {
                    ILog logger = null;
                    if (!string.IsNullOrEmpty(loggerName))
                    {
                       logger =  LogManager.GetLogger(loggerName);
                    }
                    else
                    {
                       logger = LogManager.GetLogger(source);
                    }
                    _loggers.Add(key, logger);
                    return logger;
                }
            }
        }
        #endregion
       
        #region 异常信息记录
        /* Log a message object */

        public void Debug(object source, object message)
        {
            ILog log = getLogger(source.GetType());
            if (log.IsDebugEnabled)
            {
                log.Debug(message);
            }
        }

        public void Debug(Type source, object message)
        {
            ILog log = getLogger(source);
            if (log.IsDebugEnabled)
            {
                log.Debug(message);
            }
        }

        public void Info(object source, object message)
        {
            ILog log = getLogger(source.GetType());
            if (log.IsInfoEnabled)
            {
                log.Info(message);
            }
        }

        public void Info(Type source, object message)
        {
            ILog log = getLogger(source);
            if (log.IsInfoEnabled)
            {
                log.Info(message);
            }
        }

        public void Warn(object source, object message)
        {
            ILog log = getLogger(source.GetType());
            if (log.IsWarnEnabled)
            {
                log.Warn(message);
            }
        }

        public void Warn(Type source, object message)
        {
            ILog log = getLogger(source);
            if (log.IsWarnEnabled)
            {
                log.Warn(message);
            }
        }

        public void Error(object source, object message)
        {
            ILog log = getLogger(source.GetType());
            if (log.IsErrorEnabled)
            {
                log.Error(message);
            }
        }

        public void Error(Type source, object message)
        {
            ILog log = getLogger(source);
            if (log.IsErrorEnabled)
            {
                log.Error(message);
            }
        }

        public void Fatal(object source, object message)
        {
            ILog log = getLogger(source.GetType());
            if (log.IsFatalEnabled)
            {
                log.Fatal(message);
            }
        }

        public void Fatal(Type source, object message)
        {
            ILog log = getLogger(source);
            if (log.IsFatalEnabled)
            {
                log.Fatal(message);
            }
        }

        /* Log a message object and exception */

        public void Debug(object source, object message, Exception exception)
        {
            ILog log = getLogger(source.GetType());
            if (log.IsDebugEnabled)
            {
                log.Debug(message, exception);
            }
        }

        public void Debug(Type source, object message, Exception exception)
        {
            ILog log = getLogger(source);
            if (log.IsDebugEnabled)
            {
                log.Debug(message, exception);
            }
        }

        public void Info(object source, object message, Exception exception)
        {
            ILog log = getLogger(source.GetType());
            if (log.IsInfoEnabled)
            {
                log.Info(message, exception);
            }
        }

        public void Info(Type source, object message, Exception exception)
        {
            ILog log = getLogger(source);
            if (log.IsInfoEnabled)
            {
                log.Info(message, exception);
            }
        }

        public void Warn(object source, object message, Exception exception)
        {
            ILog log = getLogger(source.GetType());
            if (log.IsWarnEnabled)
            {
                log.Warn(message, exception);
            }
        }

        public void Warn(Type source, object message, Exception exception)
        {
            ILog log = getLogger(source);
            if (log.IsWarnEnabled)
            {
                log.Warn(message, exception);
            }
        }

        public void Error(object source, object message, Exception exception)
        {
            ILog log = getLogger(source.GetType());
            if (log.IsErrorEnabled)
            {
                log.Error(message, exception);
            }
        }

        public void Error(Type source, object message, Exception exception)
        {
            ILog log = getLogger(source);
            if (log.IsErrorEnabled)
            {
                log.Error(message, exception);
            }
        }

        public void Fatal(object source, object message, Exception exception)
        {
            ILog log = getLogger(source.GetType());
            if (log.IsFatalEnabled)
            {
                log.Fatal(message, exception);
            }
        }

        public void Fatal(Type source, object message, Exception exception)
        {
            ILog log = getLogger(source);
            if (log.IsFatalEnabled)
            {
                log.Fatal(message);
            }
        }

        #endregion

       
    }
}

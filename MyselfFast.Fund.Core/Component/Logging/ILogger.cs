using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.Logging
{
    public interface ILogger
    {
        void Debug(object source, object message);
        void Debug(object source, object message, Exception exception);
        void Debug(Type source, object message);
        void Debug(Type source, object message, Exception exception);

        void Error(object source, object message);
        void Error(object source, object message, Exception exception);
        void Error(Type source, object message);
        void Error(Type source, object message, Exception exception);
        
        void Fatal(object source, object message);
        void Fatal(object source, object message, Exception exception);
        void Fatal(Type source, object message);
        void Fatal(Type source, object message, Exception exception);
       
        void Info(object source, object message);
        void Info(object source, object message, Exception exception);
        void Info(Type source, object message);
        void Info(Type source, object message, Exception exception);       
       
        void Warn(object source, object message);
        void Warn(object source, object message, Exception exception);
        void Warn(Type source, object message);
        void Warn(Type source, object message, Exception exception);
        
    }
}

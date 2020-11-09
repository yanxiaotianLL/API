using log4net.Layout;
using log4net.Layout.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Component.Logging
{
    /**********************************************************************************
     *项目名称	：Log4ForSqlServer
     *项目描述  ：
     *类名称    ：MyLayout
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : MyLayout
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-24 15:27:23
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/

    public class MyLayout : PatternLayout
    {
        public MyLayout()
        {
            this.AddConverter("property", typeof(MyMessagePatternConverter));
        }
    }

    public class MyMessagePatternConverter : PatternLayoutConverter
    {
        protected override void Convert(System.IO.TextWriter writer, log4net.Core.LoggingEvent loggingEvent)
        {
            if (Option != null)
            {
                // Write the value for the specified key
                WriteObject(writer, loggingEvent.Repository, LookupProperty(Option, loggingEvent));
            }
            else
            {
                // Write all the key value pairs
                WriteDictionary(writer, loggingEvent.Repository, loggingEvent.GetProperties());
            }
        }
        /// <summary>
        /// 通过反射获取传入的日志对象的某个属性的值
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        private object LookupProperty(string property, log4net.Core.LoggingEvent loggingEvent)
        {
            object propertyValue = string.Empty;
            PropertyInfo propertyInfo = loggingEvent.MessageObject.GetType().GetProperty(property);
            if (propertyInfo != null)
                propertyValue = propertyInfo.GetValue(loggingEvent.MessageObject, null);
            return propertyValue;
        }
    }
}



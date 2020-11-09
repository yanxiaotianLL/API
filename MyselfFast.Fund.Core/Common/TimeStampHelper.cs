using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Common
{
    /**********************************************************************************
     *项目名称	：FS.Common
     *项目描述  ：
     *类名称    ：DateTimeHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : DateTimeHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/3 15:05:56
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class TimeStampHelper
    {
        // 时间戳转为C#格式时间
        public static DateTime StampToDateTime(string timeStamp)
        {
            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);

            return dateTimeStart.Add(toNow);
        }

        // DateTime时间格式转换为Unix时间戳格式
        public static long DateTimeToStamp(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (long)(time - startTime).TotalSeconds;
        } 
    }
   /// <summary>
   /// 时间格式
   /// </summary>
   public class DateTimeFormatDic
   {
       /// <summary>
       /// 日期格式
       /// </summary>
       public static string DateFormat
       {
           get
           {
               return "yyyy-MM-dd";
           }
       }

       /// <summary>
       /// 日期时间格式
       /// </summary>
       public static string DateTimeFormat
       {
           get
           {
               return "yyyy-MM-dd HH:mm";
           }
       }

       /// <summary>
       /// 日期时间格式(带秒)
       /// </summary>
       public static string DateTimeFormatS
       {
           get
           {
               return "yyyy-MM-dd HH:mm:ss";
           }
       }

       /// <summary>
       /// 日期时间格式中文
       /// </summary>
       public static string DateTimeFormatCh
       {
           get
           {
               return "yyyy年MM月dd日 HH时mm分ss秒";
           }
       }
   }
}

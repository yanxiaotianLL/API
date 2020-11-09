using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace myselfFast.Fund.Core.Common
{
    /// <summary>
    /// URL帮助类
    /// </summary>
    public static class UrlHelper
    {
        /// <summary>
        /// URL解码
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string UrlDecode(string url)
        {
            return System.Web.HttpUtility.UrlDecode(url);
        }
        /// <summary>
        /// 按照指定编码类型对URL进行解码
        /// </summary>
        /// <param name="url"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string UrlDecode(string url, System.Text.Encoding encoding)
        {
            return System.Web.HttpUtility.UrlDecode(url, encoding);
        }
        /// <summary>
        /// URL编码
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string UrlEncode(string url)
        {
            return System.Web.HttpUtility.HtmlEncode(url);
        }
        /// <summary>
        /// 按照指定编码类型对URL进行编码
        /// </summary>
        /// <param name="url"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string UrlEncode(string url, System.Text.Encoding encoding)
        {
            return System.Web.HttpUtility.UrlEncode(url,encoding);
        }
        /// <summary>
        /// 获取url参数
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static NameValueCollection GetQueryString(string key)
        {
            //获取URL参数  
            NameValueCollection query = HttpUtility.ParseQueryString(key);
            return query;
        }

    }
}

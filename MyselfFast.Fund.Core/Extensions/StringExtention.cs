using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace myselfFast.Fund.Core.Common.Extensions
{
    /// <summary>
    /// 字符串扩展类
    /// </summary>
   public static  class StringExtention
    {
        #region 半角全角切换
        /// <summary>
        /// 转全角(SBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>全角字符串</returns>
        public static string ToSBC(this string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 32)
                {
                    c[i] = (char)12288;
                    continue;
                }
                if (c[i] < 127)
                    c[i] = (char)(c[i] + 65248);
            }
            return new string(c);
        }
        /// <summary>
        /// 转半角(DBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>半角字符串</returns>
        public static string ToDBC(this string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        } 
        #endregion
        #region 将string的常用静态方法转换为扩展方法
        /// <summary>
        /// IsNullOrEmpty转换为扩展方法
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        } 
       
        /// <summary>
        /// 将Format转换成扩展方法
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string FormatWith(this string format, params object[] args)
        {
            return string.Format(format, args);
        }
        #endregion
        #region 正则表达式的扩展方法，简化使用过程
        public static bool IsMatch(this string s, string pattern)
        {
            if (s == null) return false;
            else return Regex.IsMatch(s, pattern);
        }

        public static string Match(this string s, string pattern)
        {
            if (s == null) return "";
            return Regex.Match(s, pattern).Value;
        } 
        #endregion
        #region string转int类型方法扩展
        public static bool IsInt(this string s)
        {
            int i;
            return int.TryParse(s, out i);
        }

        public static int ToInt(this string s)
        {
            return int.Parse(s);
        } 
        #endregion
        #region 将字符串转换成常用的命名规范格式
        /// <summary>
        /// Camel命名转换
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToCamel(this string s)
        {
            if (s.IsNullOrEmpty()) return s;
            return s[0].ToString().ToLower() + s.Substring(1);
        }
        /// <summary>
        /// Pascal转换
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

        public static string ToPascal(this string s)
        {
            if (s.IsNullOrEmpty()) return s;
            return s[0].ToString().ToUpper() + s.Substring(1);
        } 
        #endregion
        /// <summary>
        /// 字符串安全转换为bool
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SafeBoolParse(this string value)
        {
            bool result = false;
            if (!value.IsNullOrEmpty())
            {
                bool.TryParse(value, out result);
            }
            return result;
        }
        /// <summary>
        /// 字符串按utf-8编码 gb2312
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
         public static string EncodingToUtf8(this string str)
        {
             byte[] bytes = Encoding.UTF8.GetBytes(str);
             string result = Encoding.UTF8.GetString(bytes);
             return result;
        }
         /// <summary>
         /// 字符串按utf-8编码 gb2312
         /// </summary>
         /// <param name="str"></param>
         /// <returns></returns>
         public static string EncodingToGB2312(this string str)
         {
             byte[] bytes = Encoding.GetEncoding("gb2312").GetBytes(str);
             string result = Encoding.GetEncoding("gb2312").GetString(bytes);
             return result;
         }
         /// <summary>
         /// 判断是否包含字符串
         /// </summary>
         /// <param name="text"></param>
         /// <param name="value"></param>
         /// <returns></returns>
         public static bool ContainsEx(this string text, string value)
         {
             return text.IndexOf(value, StringComparison.CurrentCultureIgnoreCase) >= 0;
         }

         /// <summary>
         /// 判断是否以指定字符串开头
         /// </summary>
         /// <param name="text"></param>
         /// <param name="value"></param>
         /// <returns></returns>
         public static bool StartWithEx(this string text, string value)
         {
             return text.StartsWith(value, StringComparison.CurrentCultureIgnoreCase);
         }

         /// <summary>
         /// 判断是否以指定字符串结尾
         /// </summary>
         /// <param name="text"></param>
         /// <param name="value"></param>
         /// <returns></returns>
         public static bool EndWithEx(this string text, string value)
         {
             return text.EndsWith(value, StringComparison.CurrentCultureIgnoreCase);
         }

        

         /// <summary>
         /// 指示指定的字符串是 null、空还是仅由空白字符组成。
         /// </summary>
         public static bool IsNullOrWhiteSpace(this string value)
         {
             return string.IsNullOrWhiteSpace(value);
         }

         /// <summary>
         /// 以指定字符串作为分隔符将指定字符串分隔成数组
         /// </summary>
         /// <param name="value">要分割的字符串</param>
         /// <param name="strSplit">字符串类型的分隔符</param>
         /// <param name="removeEmptyEntries">是否移除数据中元素为空字符串的项</param>
         /// <returns>分割后的数据</returns>
         public static string[] Split(this string value, string strSplit, bool removeEmptyEntries = false)
         {
             return value.Split(new[] { strSplit },
                 removeEmptyEntries ? StringSplitOptions.RemoveEmptyEntries : StringSplitOptions.None);
         }

         /// <summary>
         /// 替换Html标签
         /// </summary>
         /// <param name="value"></param>
         /// <param name="length"></param>
         /// <returns>替换后的字符串</returns>
         public static string ReplaceHtmlTag(this string value, int length = 0)
         {
             if (value.IsNullOrEmpty()) return value;
             string strText = Regex.Replace(value, "<[^>]+>", "");
             strText = Regex.Replace(strText, "&[^;]+;", "");
             if (length > 0 && strText.Length > length)
                 return strText.Substring(0, length);
             return strText;
         }

         /// <summary>
         /// 首字母小写
         /// </summary>
         /// <param name="value"></param>
         /// <returns></returns>
         public static string ReplaceFistLower(this string value)
         {
             return value.Substring(0, 1).ToLower() + value.Substring(1);
         }

         /// <summary>
         /// 过滤Sql
         /// </summary>
         /// <param name="s"></param>
         /// <returns></returns>
         public static string FilterSql(this string s)
         {
             if (string.IsNullOrEmpty(s)) return string.Empty;
             s = s.Trim().ToLower();
             s = s.Replace("=", "");
             s = s.Replace("'", "");
             s = s.Replace(";", "");
             s = s.Replace(" or ", "");
             s = s.Replace("select", "");
             s = s.Replace("update", "");
             s = s.Replace("insert", "");
             s = s.Replace("delete", "");
             s = s.Replace("declare", "");
             s = s.Replace("exec", "");
             s = s.Replace("drop", "");
             s = s.Replace("create", "");
             s = s.Replace("%", "");
             s = s.Replace("--", "");
             s = s.Replace("master", "");
             s = s.Replace("truncate", "");
             s = s.Replace("xp_", "no");
             return s;
         }
         /// <summary>
         /// 下载文件名编码
         /// </summary>
         /// <param name="filename"></param>
         /// <returns></returns>
         public static string EncodingDownloadFileName(this string filename)
         {
             if (filename == null)
             {
                 throw new NullReferenceException("filename不能为空");
             }
             string agent = HttpContext.Current.Request.Headers["User-Agent"];
             //如果不是火狐浏览器都进行编码
             if (agent != null && agent.ToLower().IndexOf("firefox", StringComparison.Ordinal) < 0)
             {
                 return HttpContext.Current.Server.UrlEncode(filename);
             }
             return filename;
         }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace myselfFast.Fund.Core.Common
{
    /// <summary>
    /// 字符串工具类
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// 获取客户端IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetClientIp()
        {
            if (HttpContext.Current == null)
            {
                return string.Empty;
            }
            //可以透过代理服务器
            string userIP = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            //判断是否有代理服务器
            if (string.IsNullOrEmpty(userIP))
            {
                //没有代理服务器,如果有代理服务器获取的是代理服务器的IP
                userIP = HttpContext.Current.Request.UserHostAddress;
            }
            return userIP;
        }


        /// <summary>
        /// 获取字符串 不返回null值
        /// </summary>
        public static string[] SplitArr(object value, char[] split = null,
                    StringSplitOptions option = StringSplitOptions.RemoveEmptyEntries)
        {
            var strValue = ToString(value);
            if (split == null) split = new char[] { ',' };

            return strValue.Split(split, option);
        }

        /// <summary>
        /// 获取字符串 不返回null值
        /// </summary>
        public static string ToString(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return string.Empty;
            }
            return value.ToString();
        }

        /// <summary>
        /// 过滤Sql查询关键词中的敏感词汇
        /// </summary>
        public static string SqlFilter(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }
            Regex regsql = new Regex(@"0x([0-9a-fA-F]{4})+|(%[0-9a-fA-F]{2})+|--|@@|count|asc|mid|char|chr|sysobjects|sys.|select|insert|delete|update|drop|truncate|xp_cmdshell|netlocalgroup|administrator|net user|exec|master|declare|localgroup|remove|create|extended_properties|objects|columns|types|extended|comments|table|cast", RegexOptions.IgnoreCase);

            value = value.Replace("'", "''").Trim();
            //捕获的字符转换为""
            return regsql.Replace(value, delegate(Match m)
            {
                return string.Empty;
            });
        }

        /// <summary>
        /// 根据时间返回几个月前,几天前,几小时前,几分钟前,几秒前
        /// </summary>
        /// <returns></returns>
        public static string DateBeforeNow(DateTime date)
        {
            TimeSpan span = DateTime.Now - date;
            if (span.TotalDays > 60)
            {
                return date.ToShortDateString();
            }
            else if (span.TotalDays > 30)
            {
                return "1个月前";
            }
            else if (span.TotalDays > 14)
            {
                return "2周前";
            }
            else if (span.TotalDays > 7)
            {
                return "1周前";
            }
            else if (span.TotalDays > 1)
            {
                return string.Format("{0}天前", (int)Math.Floor(span.TotalDays));
            }
            else if (span.TotalHours > 1)
            {
                return string.Format("{0}小时前", (int)Math.Floor(span.TotalHours));
            }
            else if (span.TotalMinutes > 1)
            {
                return string.Format("{0}分钟前", (int)Math.Floor(span.TotalMinutes));
            }
            else if (span.TotalSeconds >= 1)
            {
                return string.Format("{0}秒前", (int)Math.Floor(span.TotalSeconds));
            }
            else
            {
                return "1秒前";
            }
        }
        /// <summary>
        /// 根据出生年月进行生日提醒
        /// </summary>
        /// <returns></returns>
        public static string BirthdayMessage(DateTime date)
        {
            DateTime now = DateTime.Now;
            //TimeSpan span = DateTime.Now - birthday;
            int nowMonth = now.Month;
            int birtMonth = date.Month;
            if (nowMonth == 12 && birtMonth == 1)
                return string.Format("下月{0}号", date.Day);
            if (nowMonth == 1 && birtMonth == 12)
                return string.Format("上月{0}号", date.Day);
            int months = now.Month - date.Month;
            //int days = now.Day - birthday.Day;
            if (months == 1)
                return string.Format("上月{0}号", date.Day);
            else if (months == -1)
                return string.Format("下月{0}号", date.Day);
            else if (months == 0)
            {
                if (now.Day == date.Day)
                    return "今天";
                return string.Format("本月{0}号", date.Day);
            }
            else if (months > 1)
                return string.Format("已过{0}月", months);
            else
                return string.Format("{0}月{1}日", date.Month, date.Day);
        }


        /// <summary>
        /// 获取字符串的拆分结果
        /// </summary>
        public static string[] Split(string value, string split)
        {
            return value.Split(split.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }
        /// <summary>
        /// 获取字符串的拆分结果
        /// </summary>
        public static string[] Split(string value, params string[] split)
        {
            return value.Split(split, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// 获取左边指定位数的字符串
        /// </summary>
        public static string SplitLeft(string value, int length)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }
            if (value.Length <= length)
            {
                return value;
            }

            return value.Substring(0, length);
        }
        /// <summary>
        /// 获取左边指定位数的字符串
        /// </summary>
        public static string SplitRight(string value, int length)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }
            if (value.Length <= length)
            {
                return value;
            }

            return value.Substring(value.Length - length);
        }

        /// <summary>
        /// 获取拆分符左边的字符串
        /// </summary>
        public static string SplitLeft(string value, string split)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }
            int index = value.IndexOf(split);
            if (index > 0)
            {
                return value.Substring(0, index);
            }
            else
            {
                return value;
            }
        }
        /// <summary>
        /// 获取拆分符右边的字符串
        /// </summary>
        public static string SplitRight(string value, string split)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }
            int index = value.IndexOf(split);
            if (index > 0)
            {
                return value.Substring(index + split.Length);
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// 删除不可见字符
        /// </summary>
        public static string RemoveEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }
            Regex reg = new Regex(@"[\f\n\r\t\v]*", RegexOptions.IgnoreCase);
            value = reg.Replace(value, "");
            reg = new Regex(@"[ ]+");//合并多个空格为一个
            return reg.Replace(value, " ");
        }

        /// <summary>
        /// 过滤文本中的空行
        /// </summary>
        public static string RemoveEmptyRow(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }
            Regex reg = new Regex(@"\n[\t|\s| ]*\r", RegexOptions.IgnoreCase);
            return reg.Replace(value, "");
        }

        /// <summary>
        ///    获取字符串在数组中累计出现的次数
        /// </summary>
        public static int GetStringCount(string[] stringArray, string findString)
        {
            string totalString = string.Join("", stringArray);
            return GetStringCount(totalString, findString);
        }

        /// <summary>
        /// 获取字符串在字符串累计出现的次数
        /// </summary>
        public static int GetStringCount(string value, string findString)
        {
            if (string.IsNullOrEmpty(value))
            {
                return 0;
            }
            int count = 0;
            int findStringLength = findString.Length;
            string subString = value;

            while (subString.IndexOf(findString) >= 0)
            {
                subString = subString.Substring(subString.IndexOf(findString) + findStringLength);
                count += 1;
            }
            return count;
        }

        /// <summary>
        /// 截取从startString开始到结尾的字符   
        /// </summary>
        public static string GetSubString(string value, string startString)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }
            int index = value.IndexOf(startString);
            if (index == -1) return "";
            index += startString.Length;
            if (index > 0)
            {
                return value.Substring(index);
            }
            else
            {
                return "";
            }
        }
        /// <summary>
        /// 截取从startString开始到endString的字符   
        /// </summary>
        public static string GetSubString(string value, string startString, string endString)
        {
            value = GetSubString(value, startString);
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }

            int length = value.IndexOf(endString);
            if (length > 0)
            {
                return value.Substring(0, length);
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 按日期时间生成新文件名
        /// </summary>
        public static string BuildFileNameByDate(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return "";
            }
            return DateTime.Now.ToString("yyyyMMdd-") + DateTime.Now.Ticks
                + System.IO.Path.GetExtension(fileName); ;
        }

        /// <summary>
        /// 将字符串按指定长度截断
        /// </summary>
        public static string CutString(string value, int len, string endWith)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }
            if (len >= value.Length)
            {
                return value;
            }
            return value.Substring(0, len) + endWith;
        }

        /// <summary>
        /// 将字符串按指定长度截断
        /// </summary>
        public static string CutString(string value, int len)
        {
            return CutString(value, len, "");
        }

        /// <summary>
        /// 数制转换
        /// </summary>
        //public static string ConvertNumeric(string numeric, int fromBase, int toBase)
        //{
        //    if (string.IsNullOrEmpty(numeric) || long.TryParse(numeric))
        //    {
        //        return "0";
        //    }
        //    long newvalue = Convert.ToInt64(numeric, fromBase);
        //    return Convert.ToString(newvalue, toBase);
        //}

        /// <summary>
        /// 浮点数字格式化
        /// </summary>
        //public static string FormatFloat(string numeric)
        //{
        //    return FormatFloat(numeric, 2);
        //}
        /// <summary>
        /// 浮点数字格式化
        /// </summary>
        //public static string FormatFloat(string numeric, int decLen)
        //{
        //    return FormatFloat(numeric, decLen, false);
        //}
        /// <summary>
        /// 浮点数字格式化,alwaysCarry为true时指定decLen之后有数即进位
        /// 例:decLen=2 1.023结果为1.03
        /// </summary>
        //public static string FormatFloat(string numeric, int decLen, bool alwaysCarry)
        //{
        //    if (string.IsNullOrEmpty(numeric) || !StringValidate.IsDecimalSign(numeric))
        //    {
        //        return "0";
        //    }
        //    double d = double.Parse(numeric);
        //    string temp = "";

        //    if (alwaysCarry)
        //    {
        //        string zero = "";
        //        for (int i = 0; i < decLen; i++) zero += "0";
        //        temp = string.Format("{0:F" + decLen + "}",
        //            Math.Round(d + double.Parse(string.Format("0.{0}5", zero)),
        //            decLen, MidpointRounding.AwayFromZero));
        //    }
        //    else
        //    {
        //        temp = string.Format("{0:F" + decLen + "}", d);
        //    }
        //    return temp;
        //}

        /// <summary>
        /// 查找两个字符串最长的公共子串(LongestCommonSequence)
        /// </summary>
        public static string LCS(string value1, string value2)
        {
            if (string.IsNullOrEmpty(value1)
                || string.IsNullOrEmpty(value2))
            {
                return "";
            }
            int[,] d = new int[value1.Length, value2.Length];
            int index = 0;
            int length = 0;

            for (int i = 0; i < value1.Length; i++)
            {
                for (int j = 0; j < value2.Length; j++)
                {
                    // 左上角值
                    int n = i - 1 >= 0 && j - 1 >= 0 ? d[i - 1, j - 1] : 0;
                    // 当前节点值 = "1 + 左上角值" : "0"
                    d[i, j] = value1[i] == value2[j] ? 1 + n : 0;
                    // 如果是最大值，则记录该值和行号
                    if (d[i, j] > length)
                    {
                        length = d[i, j];
                        index = i;
                    }
                }
            }
            return value1.Substring(index - length + 1, length);
        }

        /// <summary>
        /// 两字符串相似度计算方法(编辑距离算法LevenshteinDistance又称EditDistance)
        /// </summary>
        public static string LD(string value1, string value2)
        {
            if (string.IsNullOrEmpty(value1)
                || string.IsNullOrEmpty(value2))
            {
                return "0";
            }


            int n = value1.Length;
            int m = value2.Length;
            int[,] d = new int[n + 1, m + 1];

            int temp = 0;
            char ch1, ch2;
            int i = 0, j = 0;

            for (i = 0; i <= n; i++)
            {
                //初始化第一列
                d[i, 0] = i;
            }
            for (j = 0; j <= m; j++)
            {
                //初始化第一行
                d[0, j] = j;
            }

            for (i = 1; i <= n; i++)
            {
                ch1 = value1[i - 1];
                for (j = 1; j <= m; j++)
                {
                    ch2 = value2[j - 1];
                    if (ch1 == ch2)
                    {
                        temp = 0;
                    }
                    else
                    {
                        temp = 1;
                    }
                    //对比获取最小值
                    int min = 0, first = d[i - 1, j] + 1, second = d[i, j - 1] + 1, third = d[i - 1, j - 1] + temp;
                    min = first < second ? first : second;
                    min = min < third ? min : third;

                    d[i, j] = min;
                }
            }

            //输出百分比 保留两位小数
            int maxLenth = value1.Length > value2.Length ? value1.Length : value2.Length;
            decimal percent = (1 - (decimal)d[n, m] / maxLenth) * 100;
            return string.Format("{0:F2}%", percent).Replace(".00", "");
        }


        /// <summary>
        /// 中文繁体转中文简体
        /// </summary>
        //public static string TradToSimp(string value)
        //{
        //    if (string.IsNullOrEmpty(value))
        //    {
        //        return "";
        //    }
        //    string temp = Microsoft.VisualBasic.Strings.StrConv(value, Microsoft.VisualBasic.VbStrConv.TraditionalChinese, 0);
        //    return temp;
        //}
        /// <summary>
        /// 中文简体转中文繁体
        /// </summary>
        //public static string SimpToTrad(string value)
        //{
        //    if (string.IsNullOrEmpty(value))
        //    {
        //        return "";
        //    }
        //    string temp = Microsoft.VisualBasic.Strings.StrConv(value, Microsoft.VisualBasic.VbStrConv.SimplifiedChinese, 0);
        //    return temp;
        //}

        /// <summary>
        /// 对指定串进行正则替换
        /// </summary>
        /// <returns></returns>
        public static string Replace(string value, string pattern, string replace)
        {
            if (string.IsNullOrEmpty(value)) return "";
            return Regex.Replace(value, pattern, replace, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// 对指定字符串计算其长度
        /// </summary>
        /// <returns></returns>
        public static int Length(string value, bool isDistinguishFull)
        {
            int len = 0;
            if (string.IsNullOrEmpty(value)) return len;
            //除去两侧无效空格符
            value = Replace(value, @"(^\s*)|(\s*$)", "");
            if (isDistinguishFull == true)
            {
                ASCIIEncoding ascii = new ASCIIEncoding();
                byte[] s = ascii.GetBytes(value);
                for (int i = 0; i < s.Length; i++)
                {
                    if ((int)s[i] == 63) len += 2;
                    else len += 1;
                }
            }
            else
            {
                len = value.Length;
            }
            return len;
        }

        /// <summary>
        /// 将指定字符串简单分拆为NameValueCollection
        /// </summary>
        /// <returns></returns>
        public static NameValueCollection TakeNameValueCollection(string value, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            var coll = HttpUtility.ParseQueryString(value, encoding);

            return coll;
        }

        /// <summary>
        /// 对比字符串是否相等,默认忽略大小写
        /// </summary>
        /// <returns></returns>
        public static bool IsEqualString(string value1, string value2, bool ignoreLower = true)
        {
            return string.Equals(value1, value2,
                ignoreLower ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
        }
       
    }
}

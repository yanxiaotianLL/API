using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using myselfFast.Fund.Core.Common.Extensions;
using Newtonsoft.Json;

namespace myselfFast.Fund.Core.Common
{
    /**********************************************************************************
     *项目名称	：FS.Common
     *项目描述  ：
     *类名称    ：Utils
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : Utils
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/6 12:54:31
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    ///Utils 的摘要说明
    /// </summary>
    public partial class Utils
    {
        public const double DoubleZero = 0;
        public const int IntZero = 0;
        public const long LongZero = 0;
        public const decimal DecimalZero = 0;
        public const string KdKey = "25c4fad1d8d398c7";//请把XXXXXX修改成您在快递100网站申请的APIKey


        private static Random m_rnd = null;
        public static Random Rnd
        {
            get
            {
                if (m_rnd == null) m_rnd = new Random();
                return m_rnd;
            }
        }

        public static string RootPath
        {
            get
            {
                return System.AppDomain.CurrentDomain.BaseDirectory;
            }
        }

        public static string MD5(string str, Encoding code = null)
        {
            if (code == null) code = Encoding.Default;
            byte[] buffer1 = code.GetBytes(str);
            buffer1 = new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(buffer1);
            string text1 = "";
            for (int num1 = 0; num1 < buffer1.Length; num1++)
            {
                text1 = text1 + buffer1[num1].ToString("x").PadLeft(2, '0');
            }
            return text1;
        }

        /// <summary>
        /// 是否数字
        /// </summary>
        public static bool IsNumber(string nums)
        {
            if (nums.Length == 0) return true;
            System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^\d+$");
            return rex.IsMatch(nums);
        }

        /// <summary>
        /// 将单个数字转为字符串
        /// </summary>
        /// <param name="i">数字</param>
        /// <param name="trsType">0 自己 1汉字 2 大写 3全角</param>
        /// <returns></returns>
        public static string TrsNumber(int i, int trsType = 0)
        {
            string[,] ts ={{"0","1","2","3","4","5","6","7","8","9"},
                {"０","１","２","３","４","５","６","７","８","９"},
                {"Ｏ","一","二","三","四","五","六","七","八","九"},
                {"零","壹","貮","叁","肆","伍","陆","柒","捌","玖"}};
            if (i > 9 || i < 0) i = 0;
            if (trsType > 3 || trsType < 0) trsType = 0;
            return ts[trsType, i];
        }

        public static string ExtStr(string value, int length)
        {
            if (System.Text.Encoding.Default.GetByteCount(value) > length)
            {
                string tval = value;
                while (true)
                {
                    if (System.Text.Encoding.Default.GetByteCount(tval) > length - 2)
                    {
                        tval = tval.Remove(tval.Length - 1);
                    }
                    else
                    {
                        return tval + "…";
                    }
                }
            }
            else
            {
                return value;
            }
        }
        public static string showStr(string value, int length)
        {
            if (System.Text.Encoding.Default.GetByteCount(value) > length)
            {
                string tval = value;
                while (true)
                {
                    if (System.Text.Encoding.Default.GetByteCount(tval) > length - 2)
                    {
                        tval = tval.Remove(tval.Length - 1);
                    }
                    else
                    {
                        if (value.IndexOf("#") < 0)
                        { return tval + "…"; }
                        else
                        {
                            tval = "<font color=red>" + tval.Replace("#", "") + "...</font>";
                            return tval;
                        }
                    }
                }
            }
            else
            {
                if (value.IndexOf("#") < 0)
                {
                    return value;
                }
                else
                {

                    value = "<font color=red>" + value.Replace("#", "") + "</font>";
                    return value;
                }
            }
        }


        /// <summary>
        /// 截取字符串，保留前部与尾部字符串，中间用特定字符串代替
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="slength">前部字符串长度</param>
        /// <param name="elength">尾部字符串长度</param>
        /// <param name="replaceStr">用于替换的特定字符串</param>
        /// <returns>截取后的字符串</returns>
        public static string CutSEString(string str, int slength, int elength, string replaceStr)
        {
            if (str.Length > (slength + elength))
            {
                string str1 = CutString(str, slength, "");
                string str2 = CutString(str, str.Length - elength, elength);
                str = str1 + replaceStr + str2;
            }
            return str;
        }

        public static string CutString(string str, int length, string replaceStr = "")
        {
            if (str == null) return "";
            string tmp = CutString(str, 0, length);
            if (tmp.Length != str.Length && replaceStr != "")
            {
                tmp += replaceStr;
            }

            return tmp;
        }

        public static string CutString(string str, int startIndex, int length)
        {
            return Mid(str, startIndex, length);
        }

        /// <summary>
        /// 是否数字
        /// </summary>
        public static bool IsNumeric(string nums)
        {
            if (nums.Length == 0) return true;
            for (int i = 0; i < nums.Length; i++)
            {
                if ("+-1234567890.".IndexOf(nums[i]) < 0)
                {
                    return false;
                }
            }
            int k = nums.IndexOf('.');
            k = Math.Max(k, 0);
            k = nums.IndexOf('.', k + 1);
            if (k > 0) return false;
            if (nums.IndexOf('-', 1) > 0)
            {
                return false;
            }
            if (nums.IndexOf('+', 1) > 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 是否日期值
        /// </summary>
        public static bool IsDate(string date)
        {
            try
            {
                DateTime dt = Convert.ToDateTime(date);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool IsCid(string cid)
        {
            if (cid.Length == 15)
            {
                return CheckCard15(cid);
            }
            else if (cid.Length == 18)
            {
                return CheckCard18(cid);
            }
            else
            {
                return false;
            }
        }

        private static bool CheckCard18(string CardId)//CheckCard18用于检查18位身份证号码合性        
        {
            long n = 0;
            bool flag = false;
            if (long.TryParse(CardId.Remove(17), out n) == false || n < Math.Pow(10, 16) || long.TryParse(CardId.Replace('x', '0').Replace('X', '0'), out n) == false) return false;//数字验证            
            string[] Myaddress = new string[] { "11", "22", "35", "44", "53", "12", "23", "36", "45", "54", "13", "31", "37", "46", "61", "14", "32", "41", "50", "62", "15", "33", "42", "51", "63", "21", "34", "43", "52", "64", "65", "71", "81", "82", "91" };
            for (int kk = 0; kk < Myaddress.Length; kk++)
            {
                if (Myaddress[kk].ToString() == CardId.Remove(2))
                {
                    flag = true;
                }
            } if (flag)
            {
                return flag;
            }
            string Mybirth = CardId.Substring(6, 8).Insert(6, "-").Insert(4, "-");
            DateTime Mytime = new DateTime();
            if (DateTime.TryParse(Mybirth, out Mytime) == false)
                return false;//验证            
            string[] MyVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
            string[] wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            char[] ai = CardId.Remove(17).ToCharArray(); int sum = 0;
            for (int i = 0; i < 17; i++)
                sum += int.Parse(wi[i]) * int.Parse(ai[i].ToString());
            int y = -1;
            Math.DivRem(sum, 11, out y);
            if (MyVarifyCode[y] != CardId.Substring(17, 1).ToLower())
            {
                return false;//校验码验证            
            }
            return true;//符合GB11643-1999标准       
        }
        private static bool CheckCard15(string CardId)
        {
            long n = 0; bool flag = false;
            if (long.TryParse(CardId, out n) == false || n < Math.Pow(10, 14))
                return false;//数字验证            
            string[] Myaddress = new string[] { "11", "22", "35", "44", "53", "12", "23", "36", "45", "54", "13", "31", "37", "46", "61", "14", "32", "41", "50", "62", "15", "33", "42", "51", "63", "21", "34", "43", "52", "64", "65", "71", "81", "82", "91" };
            for (int kk = 0; kk < Myaddress.Length; kk++)
            {
                if (Myaddress[kk].ToString() == CardId.Remove(2))
                {
                    flag = true;
                }
            } if (flag)
            {
                return flag;
            }
            string Mybirth = CardId.Substring(6, 6).Insert(4, "-").Insert(2, "-");
            DateTime Mytime = new DateTime();
            if (DateTime.TryParse(Mybirth, out Mytime) == false)
            {
                return false;//验证            
            }
            return true;//符合15位身份证标准       
        }
        public static bool IsEmail(string email)
        {
            Regex reg = new Regex(@"/^[A-Za-z0-9]([A_Za-z0-9]*[-_.]?[A-Za-z0-9]+)*@([A-Za-z0-9]*[-_]?[A-Za-z0-9]+)+[\.][A-Za-z]{2,3}([\.][A-Za-z]{2})?$/i");
            return reg.IsMatch(email);
        }

        public static Guid ToGuid(object v)
        {
            if (Nvs(v)) return Guid.Empty;
            Guid g;
            if (Guid.TryParse(v as string, out g))
            {
                return g;
            }
            if (Guid.TryParseExact(v.ToString(), "D", out g))
            {
                return g;
            }
            if (Guid.TryParseExact(v.ToString(), "B", out g))
            {
                return g;
            }
            if (Guid.TryParseExact(v.ToString(), "P", out g))
            {
                return g;
            }
            if (Guid.TryParseExact(v.ToString(), "N", out g))
            {
                return g;
            }
            if (Guid.TryParseExact(v.ToString(), "X", out g))
            {
                return g;
            }

            return Guid.Empty;
        }


        public static bool AllIsInt(string idlist)
        {
            if (idlist == "") return true;
            string[] s = idlist.Trim(",;|".ToCharArray()).Split(",;|".ToCharArray());
            for (int i = 0; i < s.Length; i++)
            {
                if (!IsNumber(s[i].Trim()))
                {
                    return false;
                }
            }
            return true;
        }


        public static bool IsGuid(object v)
        {
            if (Nvs(v)) return false;
            Guid g;

            return Guid.TryParse(v as string, out g) || Guid.TryParseExact(v.ToString(), "D", out g)
                    || Guid.TryParseExact(v.ToString(), "B", out g) || Guid.TryParseExact(v.ToString(), "P", out g)
                    || Guid.TryParseExact(v.ToString(), "N", out g) || Guid.TryParseExact(v.ToString(), "X", out g);
        }


        /// <summary>
        /// 是否布尔值
        /// </summary>
        public static bool IsBool(string boolean)
        {
            if (boolean.Equals("有")) return true;
            if (boolean.Equals("无")) return true;
            if (boolean.Equals("0")) return true;
            if (boolean.Equals("1")) return true;
            if (boolean.Equals("-1")) return true;
            if (boolean.Equals("是")) return true;
            if (boolean.Equals("否")) return true;
            if (boolean.Equals("真")) return true;
            if (boolean.Equals("假")) return true;
            if (boolean.Equals("√")) return true;
            if (boolean.Equals("×")) return true;
            if (boolean.ToUpper().Equals("T")) return true;
            if (boolean.ToUpper().Equals("F")) return true;
            if (boolean.ToUpper().Equals("TRUE")) return true;
            if (boolean.ToUpper().Equals("FALSE")) return true;
            if (boolean.ToUpper().Equals("Y")) return true;
            if (boolean.ToUpper().Equals("N")) return true;
            if (boolean.ToUpper().Equals("YES")) return true;
            if (boolean.ToUpper().Equals("NO")) return true;

            try
            {
                bool bl = Convert.ToBoolean(boolean);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 取字符值
        /// </summary>
        public static string Nvl(object val)
        {
            if (Nvs(val))
            {
                return "";
            }
            return val.ToString();
        }

        /// <summary>
        /// 取字符值
        /// </summary>
        public static string Nvl(object val, string vDefault)
        {
            if (Nvs(val))
            {
                return vDefault;
            }
            return val.ToString();
        }

        /// <summary>
        /// 取长整值
        /// </summary>
        public static long Nvl(object val, long vDefault)
        {
            double rst = Nvl(val, Convert.ToDouble(vDefault));
            return Convert.ToInt64(rst);
        }
        /// <summary>
        /// 取整值
        /// </summary>
        public static int Nvl(object val, int vDefault)
        {
            double rst = Nvl(val, Convert.ToDouble(vDefault));
            if (rst > 128 * 255 * 255 * 255 || rst < -128 * 255 * 255 * 255)
            {
                return vDefault;
            }
            return Convert.ToInt32(rst);
        }
        /// <summary>
        /// 取短整值
        /// </summary>
        public static short Nvl(object val, short vDefault)
        {
            double rst = Nvl(val, Convert.ToDouble(vDefault));
            if (rst > 128 * 255 || rst < -128 * 255)
            {
                return vDefault;
            }
            return Convert.ToInt16(rst);
        }
        /// <summary>
        /// 取双精值
        /// </summary>
        public static double Nvl(object val, double vDefault)
        {
            if (Nvs(val))
            {
                return vDefault;
            }
            switch (val.GetType().Name)
            {
                case "Int":
                case "Int16":
                case "Int32":
                case "Int64":
                case "Double":
                case "Decimal":
                case "Single":
                    return Convert.ToDouble(val);
                case "String":
                    string s = val as string;
                    s = s.Replace(",", "").Replace(" ", "");
                    if (s.IsNumeric())
                    {
                        try
                        {
                            return Convert.ToDouble(s);
                        }
                        catch
                        {
                            return vDefault;
                        }
                    }
                    else
                    {
                        return vDefault;
                    }
                default:
                    try
                    {
                        return Convert.ToDouble(val);
                    }
                    catch
                    {
                        return vDefault;
                    }
            }
        }
        /// <summary>
        /// 限小数值
        /// </summary>
        public static decimal Nvl(object val, decimal vDefault)
        {
            double rst = Nvl(val, Convert.ToDouble(vDefault));
            return Convert.ToDecimal(rst);
        }
        /// <summary>
        /// 取日期值
        /// </summary>
        public static DateTime Nvl(object val, DateTime vDefault)
        {
            try
            {
                if (Nvs(val))
                {
                    return vDefault;
                }
                string sval = val.ToString();

                if (IsNumber(sval))
                {
                    switch (sval.Length)
                    {
                        case 8:
                            sval = Left(sval, 4) + "-" + Mid(sval, 4, 2) + "-" + Right(sval, 2);
                            return Convert.ToDateTime(sval);
                        case 6:
                            sval = Left(sval, 4) + "-" + Right(sval, 2) + "-01";
                            return Convert.ToDateTime(sval);
                        case 4:
                            sval += "-01-01";
                            return Convert.ToDateTime(sval);
                        default:
                            double d = Nvl(sval, DoubleZero);
                            DateTime t = DateTime.FromOADate(d);
                            if (t.Date.CompareTo(new DateTime(2099, 12, 31)) < 0)
                            {
                                return t;
                            }
                            else
                            {
                                return vDefault;
                            }
                    }
                }
                else if (IsNumeric(sval))
                {
                    double d = Nvl(sval, DoubleZero);
                    return DateTime.FromOADate(d);
                }
                else
                {
                    sval = sval.Replace('.', '-');
                    try
                    {
                        return Convert.ToDateTime(sval);
                    }
                    catch
                    {
                        sval = sval.Replace("年", "-").Replace("月", "-").Replace("日", "-").Replace("时", "-").Replace("分", "-").Replace("秒", "-");
                        sval = sval.Replace(":", "-").Replace(" ", "-");
                        sval += "-0-0-0-0-0-0-0-0-0-0-0-0";
                        string[] dts = sval.Split("-".ToCharArray());
                        if (dts[1].Equals("0")) dts[1] = "1";
                        if (dts[2].Equals("0")) dts[2] = "1";
                        string sDate = dts[0] + "-" + dts[1] + "-" + dts[2] + " " + dts[3] + ":" + dts[4] + ":" + dts[5];
                        return Convert.ToDateTime(sDate);
                    }
                }
            }
            catch
            {
                return vDefault;
            }
        }
        /// <summary>
        /// 取布尔值
        /// </summary>
        public static bool Nvl(object val, bool vDefault)
        {
            try
            {
                if (Nvs(val))
                {
                    return vDefault;
                }
                switch (val.ToString().ToLower())
                {
                    case "√":
                    case "-1":
                    case "1":
                    case "y":
                    case "yes":
                    case "on":
                    case "t":
                    case "true":
                    case "sure":
                    case "right":
                    case "真":
                    case "是":
                    case "有":
                    case "对":
                    case "成":
                    case "成功":
                    case "确定":
                    case "确认":
                        return true;
                    default:
                        return false;
                }
            }
            catch
            {
                return vDefault;
            }
        }

        /// <summary>
        /// 是否空
        /// </summary>
        public static bool Nvs(object val)
        {
            string text1;
            if (val == null)
            {
                return true;
            }
            if ((text1 = val.GetType().Name) != null)
            {
                text1 = string.IsInterned(text1);
                if (text1 == "DBNull")
                {
                    return true;
                }
            }
            return (val.ToString().Trim().Length == 0);
        }

        /// <summary>
        /// 取左边指定数目个字符
        /// </summary>
        /// <param name="Sour">原字符串</param>
        /// <param name="length">长度</param>
        public static string Left(string Sour, int length)
        {
            if (Sour == null) return "";
            if (Sour.Length <= length) return Sour;
            if (length < 1) return "";
            return Sour.Substring(0, length);
        }

        /// <summary>
        /// 取左边指定数目个字符
        /// </summary>
        /// <param name="Sour">原字符串</param>
        /// <param name="length">长度</param>
        public static string Right(string Sour, int length)
        {
            if (Sour == null) return "";
            if (Sour.Length < length) return Sour;
            if (length < 1) return "";
            return Sour.Substring(Sour.Length - length);
        }

        /// <summary>
        /// 取指定位置开始取指定数目个字符
        /// </summary>
        /// <param name="Sour">原字符串</param>
        /// <param name="start">起始位置</param>
        /// <param name="length">长度</param>
        public static string Mid(string Sour, int start, int length)
        {
            if (Sour == null) return "";
            if (Sour.Length < start) return "";
            int istart = start;
            if (istart <= 0) istart = 0;
            return Left(Sour.Substring(istart), length);
        }
        /// <summary>
        /// 取指定位置开始取剩余全部字符
        /// </summary>
        /// <param name="Sour">原字符串</param>
        /// <param name="start">起始位置</param>
        public static string Mid(string Sour, int start)
        {
            return Mid(Sour, start, Sour.Length);
        }

        public static string Img(object val)
        {
            return Img(val, "/image/myselfsh_picb.jpg");
        }

        public static string Img(object val, string _default)
        {
            if (Nvs(val))
            {
                return _default;
            }
            else
            {
                string sPth = HttpContext.Current.Server.MapPath(Nvl(val));
                if (System.IO.File.Exists(sPth))
                {
                    return Nvl(val);
                }
                else
                {
                    return _default;
                }
            }
        }

        /// <summary>
        /// 取文件名的名字部份
        /// </summary>
        /// <param name="filename">文件名</param>
        public static string NamePartOfFileName(string filename)
        {
            int i = filename.LastIndexOf("\\");
            if (i > 0)
            {
                return Mid(filename, i + 1);
            }
            else
            {
                return filename;
            }
        }

        /// <summary>
        /// 取文件名路径部份
        /// </summary>
        public static string PathPartOfFileName(string filename)
        {
            int i = filename.LastIndexOf("\\");
            if (i > 0)
            {
                return Left(filename, i);
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 取文件扩展名
        /// </summary>
        /// <param name="filename">文件名</param>
        /// <returns>扩展名</returns>
        public static string ExtOfFileName(string filename)
        {
            /*int i = filename.LastIndexOf(".");
            if (i > 0)
            {
                return Mid(filename, i + 1);
            }
            else
            {
                return "";
            }*/
            return System.IO.Path.GetExtension(filename);
        }

        public static Boolean IsImage(string path)
        {
            try
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(path);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static Boolean IsDoc(string path)
        {
            try
            {
                string ext = Utils.ExtOfFileName(path).ToLower().TrimStart('.');
                return (ext == "doc" || ext == "docx" || ext == "xls" || ext == "xlsx");
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 序列化，将对象转换为Json字符串输出
        /// </summary>
        /// <param name="item">传入对象名</param>
        /// <returns>Json字符串</returns>
        public static string ToJsJson(object item)
        {
            System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(item.GetType());
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                serializer.WriteObject(ms, item);
                StringBuilder sb = new StringBuilder();
                sb.Append(Encoding.UTF8.GetString(ms.ToArray()));
                return sb.ToString();
            }
        }



        /// <summary>
        /// 过滤特殊字符(例如：\b、\n、\r、\t等)
        /// </summary>
        private static string String2Json(String s)
        {
            string rst = s.Replace("\"", "&rioh;");
            rst = rst.Replace("\\", "\\\\");
            rst = rst.Replace("/", "\\/");
            rst = rst.Replace("\b", "\\b");
            rst = rst.Replace("\f", "\\f");
            rst = rst.Replace("\n", "\\n");
            rst = rst.Replace("\t", "\\t");
            rst = rst.Replace("\r", "\\r");
            return rst;
        }

        public static string TableToJson(System.Data.DataTable dt, dynamic fields, bool isSimple = false, bool isTolower = true)
        {
            string sfields = "";
            foreach (PropertyInfo p in fields.GetType().GetProperties())
            {
                string sf = p.GetValue(fields, null);
                if (sf != "")
                {
                    if (dt.Columns.Contains(sf))
                    {
                        dt.Columns[sf].ColumnName = p.Name;
                        sfields += "," + p.Name;
                    }
                }
            }
            return TableToJson(dt, isSimple, isTolower, sfields.Trim(',').Split(','));
        }

        /// <summary>
        /// 将表格中的数据转换成json 字符串格式
        /// </summary>
        /// <param name="dt">要转换的表</param>
        /// <returns>Json串</returns>
        public static string TableToJson(System.Data.DataTable dt, bool isSimple = false, bool isTolower = true, params string[] fields)
        {
            string rst = "";
            bool isFst = true;
            if (dt == null) return "";
            foreach (System.Data.DataRow r in dt.Rows)
            {
                if (!isFst) rst += ","; else isFst = false;
                bool isF = true;
                rst += "{";
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                    if (fields.Length > 0 && fields[0] != "")
                    {
                        if (fields.Count<string>(x => x.Equals(col.ColumnName, StringComparison.CurrentCultureIgnoreCase)) <= 0)
                        {
                            continue;
                        }
                    }
                    if (!isF) rst += ","; else isF = false;
                    if (isTolower)
                    {
                        rst += "\"" + col.ColumnName.ToLower() + "\":";
                    }
                    else
                    {
                        rst += "\"" + col.ColumnName + "\":";
                    }
                    switch (col.DataType.ToString().Replace("System.", ""))
                    {
                        case "int":
                        case "Int":
                        case "long":
                        case "Long":
                        case "Int32":
                        case "Int16":
                        case "Int64":
                        case "byte":
                            rst += Utils.ToInt(r[col]).ToString();
                            break;
                        case "Decimal":
                        case "decimal":
                        case "float":
                        case "real":
                        case "double":
                        case "Double":
                            rst += Utils.ToDecimal(r[col]).ToString();
                            break;
                        case "bool":
                        case "Boolean":
                            rst += Utils.ToBoolean(r[col]).ToString().ToLower();
                            break;
                        case "DateTime":
                            rst += "\"" + Utils.ToDateTime(r[col]).ToString("yyyy-MM-dd HH:mm:ss") + "\"";
                            break;
                        default:
                            string scol = Utils.ToString(r[col]);
                            if (isSimple && (scol.IndexOf("\"") >= 0 || scol.Length > 500))
                            {
                                scol = "";
                            }
                            rst += "\"" + System.Web.HttpContext.Current.Server.HtmlEncode(String2Json(scol)) + "\"";
                            break;
                    }
                }
                rst += "}";
            }
            if (rst != "")
            {
                rst = "[" + rst + "]";
            }
            return rst;
        }


        /// <summary>
        /// 反序列化，将传入的Json字符串转换为指定的对象输出
        /// </summary>
        /// <param name="jsonString">传的Json字符串</param>
        /// <returns>指定的对象</returns>
        public static T FromJsonTo<T>(string jsonString)
        {
            Newtonsoft.Json.JsonSerializerSettings s = new Newtonsoft.Json.JsonSerializerSettings { NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonString, s);
        }

        public static Object Json2Obj(String json, Type t)
        {
            try
            {
                System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(t);
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(Encoding.UTF8.GetBytes(json)))
                {
                    return serializer.ReadObject(ms);
                }
            }
            catch
            {
                return null;
            }
        }

        public static void WirteLog(object sender, string func, string txt)
        {
            try
            {
                string path = "";
                if (HttpContext.Current.Server == null)
                {
                    path = "D:\\WebDownFiles\\InterFace";
                }
                else
                {
                    path = HttpContext.Current.Server.MapPath("/Notify_DATA");
                }
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                System.IO.StreamWriter fs = new System.IO.StreamWriter(path + "\\SQL_" + DateTime.Now.ToString("yyyyMMddHH") + ".txt", true, System.Text.Encoding.Default);
                fs.Write("******>" + sender.GetType() + "." + func + "\r\n>Time:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n>内容:" + txt + "\r\n");
                fs.Close();
            }
            catch
            {
            }
        }


        public static void WirteLog(string err, string txt)
        {
            try
            {
                string path = "";
                if (HttpContext.Current.Server == null)
                {
                    path = "D:\\WebDownFiles\\InterFace";
                }
                else
                {
                    path = HttpContext.Current.Server.MapPath("/Notify_DATA");
                }
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                System.IO.StreamWriter fs = new System.IO.StreamWriter(path + "\\SQL_" + DateTime.Now.ToString("yyyyMMddHH") + ".txt", true, System.Text.Encoding.Default);
                fs.Write("******>Time:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n******>" + err + "\r\n>内容:" + txt + "\r\n");
                fs.Close();
            }
            catch
            {
            }
        }
        public static void WirteLogNoext(string err, string txt, string logname = "")
        {
            try
            {
                if (logname == "") logname = "SQL_";
                string path = "";
                if (HttpContext.Current.Server == null)
                {
                    path = "D:\\WebDownFiles\\InterFace";
                }
                else
                {
                    path = HttpContext.Current.Server.MapPath("/Notify_DATA");
                }
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                System.IO.StreamWriter fs = new System.IO.StreamWriter(path + "\\" + logname + DateTime.Now.ToString("yyyyMMddHH") + ".txt", true, System.Text.Encoding.Default);
                fs.Write("******>" + err + ":>" + txt + "\r\n");
                fs.Close();
            }
            catch
            {
            }
        }

        private static string BitsToString(byte[] b)
        {
            string s = "";
            for (int i = 0; i < b.Length; i++)
            {
                char c = Convert.ToChar(b[i]);
                if (c == '&')
                {
                    s += "&amp;";
                }
                else if ("1234567890.qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM".IndexOf(c) >= 0)
                {
                    s += c;
                }
                else
                {
                    s += "%" + b[i].ToString("x");
                }
            }
            return s;
        }

        public static Int64 ToInt64(object p, long Default = 0)
        {
            return Nvl(p, Default);
        }

        public static decimal ToDecimal(object p, decimal Default = 0)
        {
            return Nvl(p, Default);
        }

        public static int ToInt(object p, int Default = 0)
        {
            return Nvl(p, Default);
        }

        public static bool ToBoolean(object p)
        {
            return Nvl(p, false);
        }

        public static DateTime ToDateTime(object p)
        {
            return Nvl(p, new DateTime(1900, 1, 1));
        }

        public static int ToInt100(object val)
        {
            return Nvl(Nvl(val, DoubleZero) * 100, IntZero);
        }

        public static string ToString(object p)
        {
            return Nvl(p);
        }


        public static void SetDropDownControl(System.Web.UI.WebControls.DropDownList ddl, object value)
        {
            if (ddl.Items.FindByValue(ToString(value)) != null)
            {
                ddl.SelectedValue = ToString(value);
            }
            else
            {
                ddl.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 在字符串的指定位置插入特定的字符
        /// </summary>
        /// <param name="sourestring">待插入字符的字符串</param>
        /// <param name="startindex">插入位置（以0开始）</param>
        /// <param name="length">特定字符的重复次数</param>
        /// <param name="insertchar">要插入的特定字符</param>
        /// <returns>整理好的字符串</returns>
        public static string InserCharToString(string sourestring, int startindex, int length, string insertchar = "")
        {
            string tempFString = sourestring.Substring(0, startindex);
            string tempBString = sourestring.Substring(startindex);
            for (int i = 0; i < length; i++)
            {
                tempFString += insertchar;
            }
            return tempFString + tempBString;

        }
        public static string FromObjectTo<T>(T t)
        {
            Newtonsoft.Json.JsonSerializerSettings s = new Newtonsoft.Json.JsonSerializerSettings { NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore };
            return JsonConvert.SerializeObject(t, s);

        }
        public static string InserCharToString(string sourestring, int length, string insertchar = "")
        {
            return InserCharToString(sourestring, 0, length, insertchar);
        }
        #region DataTable,List相互转换
        public static DataTable ConvertTo<T>(IList<T> list)
        {
            DataTable table = CreateTable<T>();
            Type entityType = typeof(T);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);
            foreach (T item in list)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item);
                table.Rows.Add(row);
            }
            return table;
        }

        public static IList<T> ConvertTo<T>(IList<DataRow> rows)
        {
            IList<T> list = null;
            if (rows != null)
            {
                list = new List<T>();
                foreach (DataRow row in rows)
                {
                    T item = CreateItem<T>(row);
                    list.Add(item);
                }
            }
            return list;
        }

        public static IList<T> ConvertTo<T>(DataTable table)
        {
            if (table == null)
                return null;

            var rows = table.Rows.Cast<DataRow>().ToList();

            return ConvertTo<T>(rows);
        }

        //Convert DataRow into T Object
        public static T CreateItem<T>(DataRow row)
        {
            T obj = default(T);
            if (row == null) return obj;
            obj = Activator.CreateInstance<T>();
            foreach (DataColumn column in row.Table.Columns)
            {
                var columnName = column.ColumnName;
                //Get property with same columnName
                var prop = obj.GetType().GetProperty(columnName);
                //Get value for the column
                var value = (row[columnName] is DBNull)
                    ? null : row[columnName];
                //Set property value
                if (prop != null && prop.CanWrite)    //判断其是否可写
                    prop.SetValue(obj, value, null);
            }
            return obj;
        }

        public static DataTable CreateTable<T>()
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entityType);
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, prop.PropertyType);

            return table;
        }

        public static List<T> ConvertToEx<T>(DataTable dt) where T : new()
        {
            if (dt == null) return null;
            if (dt.Rows.Count <= 0) return null;

            List<T> list = new List<T>();
            Type type = typeof(T);
            PropertyInfo[] propertyInfos = type.GetProperties();  //获取泛型的属性
            List<DataColumn> listColumns = dt.Columns.Cast<DataColumn>().ToList();  //获取数据集的表头，以便于匹配
            T t;
            foreach (DataRow dr in dt.Rows)
            {
                t = new T();
                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    try
                    {
                        DataColumn dColumn = listColumns.Find(name => name.ToString().ToUpper() == propertyInfo.Name.ToUpper());  //查看是否存在对应的列名
                        if (dColumn != null)
                            propertyInfo.SetValue(t, dr[propertyInfo.Name], null);  //赋值
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                list.Add(t);
            }
            return list;
        }

        #endregion

        public static string Getwuliu(string typeCom)
        {
            if (typeCom == "AAE全球专递")
            {
                typeCom = "aae";
            }
            if (typeCom == "安捷快递")
            {
                typeCom = "anjiekuaidi";
            }
            if (typeCom == "安信达快递")
            {
                typeCom = "anxindakuaixi";
            }
            if (typeCom == "百福东方")
            {
                typeCom = "baifudongfang";
            }
            if (typeCom == "彪记快递")
            {
                typeCom = "biaojikuaidi";
            }
            if (typeCom == "BHT")
            {
                typeCom = "bht";
            }
            if (typeCom == "BHT")
            {
                typeCom = "bht";
            }
            if (typeCom == "希伊艾斯快递")
            {
                typeCom = "cces";
            }
            if (typeCom == "中国东方")
            {
                typeCom = "Coe";
            }
            if (typeCom == "长宇物流")
            {
                typeCom = "changyuwuliu";
            }
            if (typeCom == "大田物流")
            {
                typeCom = "datianwuliu";
            }
            if (typeCom == "德邦物流")
            {
                typeCom = "debangwuliu";
            }
            if (typeCom == "DPEX")
            {
                typeCom = "dpex";
            }
            if (typeCom == "DHL")
            {
                typeCom = "dhl";
            }
            if (typeCom == "D速快递")
            {
                typeCom = "dsukuaidi";
            }
            if (typeCom == "fedex")
            {
                typeCom = "fedex";
            }
            if (typeCom == "飞康达物流")
            {
                typeCom = "feikangda";
            }
            if (typeCom == "凤凰快递")
            {
                typeCom = "fenghuangkuaidi";
            }
            if (typeCom == "港中能达物流")
            {
                typeCom = "ganzhongnengda";
            }
            if (typeCom == "广东邮政物流")
            {
                typeCom = "guangdongyouzhengwuliu";
            }
            if (typeCom == "汇通快运")
            {
                typeCom = "huitongkuaidi";
            }
            if (typeCom == "恒路物流")
            {
                typeCom = "hengluwuliu";
            }
            if (typeCom == "华夏龙物流")
            {
                typeCom = "huaxialongwuliu";
            }
            if (typeCom == "佳怡物流")
            {
                typeCom = "jiayiwuliu";
            }
            if (typeCom == "京广速递")
            {
                typeCom = "jinguangsudikuaijian";
            }
            if (typeCom == "急先达")
            {
                typeCom = "jixianda";
            }
            if (typeCom == "佳吉物流")
            {
                typeCom = "jiajiwuliu";
            }
            if (typeCom == "加运美")
            {
                typeCom = "jiayunmeiwuliu";
            }
            if (typeCom == "快捷速递")
            {
                typeCom = "kuaijiesudi";
            }
            if (typeCom == "联昊通物流")
            {
                typeCom = "lianhaowuliu";
            }
            if (typeCom == "龙邦物流")
            {
                typeCom = "longbanwuliu";
            }
            if (typeCom == "民航快递")
            {
                typeCom = "minghangkuaidi";
            }
            if (typeCom == "配思货运")
            {
                typeCom = "peisihuoyunkuaidi";
            }
            if (typeCom == "全晨快递")
            {
                typeCom = "quanchenkuaidi";
            }
            if (typeCom == "全际通物流")
            {
                typeCom = "quanjitong";
            }
            if (typeCom == "全日通快递")
            {
                typeCom = "quanritongkuaidi";
            }
            if (typeCom == "全一快递")
            {
                typeCom = "quanyikuaidi";
            }
            if (typeCom == "盛辉物流")
            {
                typeCom = "shenghuiwuliu";
            }
            if (typeCom == "速尔物流")
            {
                typeCom = "suer";
            }
            if (typeCom == "盛丰物流")
            {
                typeCom = "shengfengwuliu";
            }
            if (typeCom == "天地华宇")
            {
                typeCom = "tiandihuayu";
            }
            if (typeCom == "天天快递")
            {
                typeCom = "tiantian";
            }
            if (typeCom == "TNT")
            {
                typeCom = "tnt";
            }
            if (typeCom == "UPS")
            {
                typeCom = "ups";
            }
            if (typeCom == "万家物流")
            {
                typeCom = "wanjiawuliu";
            }
            if (typeCom == "文捷航空速递")
            {
                typeCom = "wenjiesudi";
            }
            if (typeCom == "伍圆速递")
            {
                typeCom = "wuyuansudi";
            }
            if (typeCom == "万象物流")
            {
                typeCom = "wanxiangwuliu";
            }
            if (typeCom == "新邦物流")
            {
                typeCom = "xinbangwuliu";
            }
            if (typeCom == "信丰物流")
            {
                typeCom = "xinfengwuliu";
            }
            if (typeCom == "星晨急便")
            {
                typeCom = "xingchengjibian";
            }
            if (typeCom == "鑫飞鸿物流")
            {
                typeCom = "xinhongyukuaidi";
            }
            if (typeCom == "亚风速递")
            {
                typeCom = "yafengsudi";
            }
            if (typeCom == "一邦速递")
            {
                typeCom = "yibangwuliu";
            }
            if (typeCom == "优速物流")
            {
                typeCom = "youshuwuliu";
            }
            if (typeCom == "远成物流")
            {
                typeCom = "yuanchengwuliu";
            }
            if (typeCom == "圆通速递")
            {
                typeCom = "yuantong";
            }
            if (typeCom == "源伟丰快递")
            {
                typeCom = "yuanweifeng";
            }
            if (typeCom == "元智捷诚快递")
            {
                typeCom = "yuanzhijiecheng";
            }
            if (typeCom == "越丰物流")
            {
                typeCom = "yuefengwuliu";
            }
            if (typeCom == "韵达快递")
            {
                typeCom = "yunda";
            }
            if (typeCom == "源安达")
            {
                typeCom = "yuananda";
            }
            if (typeCom == "运通快递")
            {
                typeCom = "yuntongkuaidi";
            }
            if (typeCom == "宅急送")
            {
                typeCom = "zhaijisong";
            }
            if (typeCom == "中铁快运")
            {
                typeCom = "zhongtiewuliu";
            }
            if (typeCom == "中通速递")
            {
                typeCom = "zhongtong";
            }
            if (typeCom == "中邮物流")
            {
                typeCom = "zhongyouwuliu";
            }

            return typeCom;

        }

        /// <summary>
        /// Post方式提交数据，返回网页的源代码
        /// </summary>
        /// <param name="url">发送请求的 URL</param>
        /// <param name="param">请求的参数集合</param>
        /// <returns>远程资源的响应结果</returns>
        public static string SendPost(string url, Dictionary<string, string> param)
        {
            string result = "";
            StringBuilder postData = new StringBuilder();
            if (param != null && param.Count > 0)
            {
                foreach (var p in param)
                {
                    if (postData.Length > 0)
                    {
                        postData.Append("&");
                    }
                    postData.Append(p.Key);
                    postData.Append("=");
                    postData.Append(p.Value);
                }
            }
            byte[] byteData = Encoding.GetEncoding("UTF-8").GetBytes(postData.ToString());
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ContentType = "application/x-www-form-urlencoded";
                request.Referer = url;
                request.Accept = "*/*";
                request.Timeout = 30 * 1000;
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)";
                request.Method = "POST";
                request.ContentLength = byteData.Length;
                Stream stream = request.GetRequestStream();
                stream.Write(byteData, 0, byteData.Length);
                stream.Flush();
                stream.Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream backStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(backStream, Encoding.GetEncoding("UTF-8"));
                result = sr.ReadToEnd();
                sr.Close();
                backStream.Close();
                response.Close();
                request.Abort();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }


        /// <summary>
        /// Convert a List{T} to a DataTable.
        /// </summary>
        public static DataTable ToDataTable<T>(List<T> items)
        {
            var tb = new DataTable(typeof(T).Name);

            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                tb.Columns.Add(prop.Name, t);
            }

            foreach (T item in items)
            {
                var values = new object[props.Length];

                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                tb.Rows.Add(values);
            }

            return tb;
        }
        /// <summary>
        /// Determine of specified type is nullable
        /// </summary>
        public static bool IsNullable(Type t)
        {
            return !t.IsValueType || (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
        /// <summary>
        /// Return underlying type if type is Nullable otherwise return the type
        /// </summary>
        public static Type GetCoreType(Type t)
        {
            if (t != null && IsNullable(t))
            {
                if (!t.IsValueType)
                {
                    return t;
                }
                else
                {
                    return Nullable.GetUnderlyingType(t);
                }
            }
            else
            {
                return t;
            }
        }
    }
}

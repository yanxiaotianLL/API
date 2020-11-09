using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace myselfFast.Fund.Core.Common.Extensions
{
    /**********************************************************************************
     *项目名称	：FS.Common.Extensions
     *项目描述  ：
     *类名称    ：ExtensionOld
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ExtensionOld
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/6 12:52:57
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 扩展类
    /// </summary>
    public static class ExtensionOld
    {
        #region String 验证类
        public static bool IsGuid(this string guid)
        {
            if (guid.IsNull()) return false;
            Guid g;
            if (Guid.TryParse(guid as string, out g))
            {
                return true;
            }
            if (Guid.TryParseExact(guid, "D", out g))
            {
                return true;
            }
            if (Guid.TryParseExact(guid, "B", out g))
            {
                return true;
            }
            if (Guid.TryParseExact(guid, "P", out g))
            {
                return true;
            }
            if (Guid.TryParseExact(guid, "N", out g))
            {
                return true;
            }
            if (Guid.TryParseExact(guid, "X", out g))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 是否数字
        /// </summary>
        /// <param name="In"></param>
        /// <returns></returns>
        public static bool IsNumber(this string In)
        {
            if (In.Length == 0) return true;
            System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^\d+$");
            return rex.IsMatch(In);
        }

        /// <summary>
        /// 是否数值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool IsNumeric(this string nums)
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
        public static bool IsDate(this string date)
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

        /// <summary>
        /// 是否身份证号
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public static bool IsCid(this string cid)
        {
            if (cid.Length == 15)
            {
                return IsCard15(cid);
            }
            else if (cid.Length == 18)
            {
                return IsCard18(cid);
            }
            else
            {
                return false;
            }
        }

        private static bool IsCard18(this string CardId)//CheckCard18用于检查18位身份证号码合性        
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
        private static bool IsCard15(this string CardId)
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
        /// <summary>
        /// 是否邮箱字符串
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsEmail(this string email)
        {
            Regex reg = new Regex(@"^[A-Za-z0-9]([A-Za-z0-9]*[-_.]?[A-Za-z0-9]+)*@([A-Za-z0-9]*[-_]?[A-Za-z0-9]+)+[\.][A-Za-z]{2,}([\.][A-Za-z]{2,})?$", RegexOptions.IgnoreCase);
            return reg.IsMatch(email);
        }
        /// <summary>
        /// 是否布尔值
        /// </summary>
        public static bool IsBool(this string boolean)
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

        #endregion

        #region String 取值类
        /// <summary>
        /// 截取字符串，保留前部与尾部字符串，中间用特定字符串代替
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="length">前部字符串长度</param>
        /// <param name="replaceStr">用于替换的特定字符串</param>
        /// <returns>截取后的字符串</returns>
        public static string Left(this string Sour, int length, string replaceStr = "")
        {
            if (Sour == null) return "";
            if (Sour.Length <= length) return Sour;
            if (length < 1) return "";
            string tmp = Sour.Substring(0, length);
            if (tmp.Length != Sour.Length && replaceStr != "")
            {
                tmp += replaceStr;
            }

            return tmp;
        }

        /// <summary>
        /// 取右边指定数目个字符
        /// </summary>
        /// <param name="Sour">原字符串</param>
        /// <param name="length">长度</param>
        public static string Right(this string Sour, int length)
        {
            if (Sour == null) return "";
            if (Sour.Length <= length) return Sour;
            if (length < 1) return "";
            return Sour.Substring(Sour.Length - length);
        }

        /// <summary>
        /// 取指定位置开始取指定数目个字符
        /// </summary>
        /// <param name="Sour">原字符串</param>
        /// <param name="start">起始位置</param>
        /// <param name="length">长度</param>
        public static string Mid(this string Sour, int start, int length = 0)
        {
            if (Sour == null) return "";
            if (Sour.Length < start) return "";
            int istart = start;
            if (istart <= 0) istart = 0;
            return Sour.Substring(istart).Left(length == 0 ? Sour.Length : length);
        }

        /// <summary>
        /// 截取字符串，保留前部与尾部字符串，中间用特定字符串代替
        /// </summary>
        /// <param name="str">源字符串</param>
        /// <param name="slength">前部字符串长度</param>
        /// <param name="elength">尾部字符串长度</param>
        /// <param name="replaceStr">用于替换的特定字符串</param>
        /// <returns>截取后的字符串</returns>
        public static string Mid(this string str, int slength, int elength, string replaceStr)
        {
            if (str.Length > (slength + elength))
            {
                string str1 = str.Left(slength);
                string str2 = str.Right(elength);
                str = str1 + replaceStr + str2;
            }
            return str;
        }
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <param name="In"></param>
        /// <returns></returns>
        public static bool IsNull(this string In)
        {
            return String.IsNullOrEmpty(In) || String.IsNullOrWhiteSpace(In);
        }

        /// <summary>
        /// 浮点值
        /// </summary>
        /// <param name="val"></param>
        /// <param name="vDefault"></param>
        /// <returns></returns>
        public static double ToDoubleValue(this string val, double vDefault = 0)
        {
            try
            {
                if (val.IsNull())
                {
                    return vDefault;
                }
                return Convert.ToDouble(val.ToString().Replace(" ", ""));
            }
            catch
            {
                return vDefault;
            }
        }
        /// <summary>
        /// decimal型值
        /// </summary>
        /// <param name="val"></param>
        /// <param name="vDefault"></param>
        /// <returns></returns>
        public static decimal ToDecimalValue(this string val, decimal vDefault = 0)
        {
            try
            {
                if (val.IsNull())
                {
                    return vDefault;
                }
                return Convert.ToDecimal(val.ToString().Replace(" ", ""));
            }
            catch
            {
                return vDefault;
            }
        }

        /// <summary>
        /// 整型值
        /// </summary>
        /// <param name="val"></param>
        /// <param name="vDefault"></param>
        /// <returns></returns>
        public static int ToIntValue(this string val, int vDefault = -1)
        {
            try
            {
                if (val.IsNull()) return vDefault;

                return Convert.ToInt32(val.ToDoubleValue(vDefault));
            }
            catch
            {
                return vDefault;
            }
        }
        /// <summary>
        /// Long型值
        /// </summary>
        /// <param name="val"></param>
        /// <param name="vDefault"></param>
        /// <returns></returns>
        public static long ToLongValue(this string val, long vDefault = -1)
        {
            try
            {
                if (val.IsNull()) return vDefault;

                return Convert.ToInt64(val.ToDoubleValue(vDefault));
            }
            catch
            {
                return vDefault;
            }
        }
        /// <summary>
        /// 日期值
        /// </summary>
        /// <param name="val"></param>
        /// <param name="vDefault"></param>
        /// <returns></returns>
        public static DateTime ToDateValue(this string val, DateTime vDefault = default(DateTime))
        {
            try
            {
                if (val.IsNull())
                {
                    return vDefault;
                }
                string sval = val.ToString();

                if (IsNumber(sval))
                {
                    if (sval.Length >= 4 && (Left(sval, 2) == "19" || Left(sval, 2) == "20"))
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
                                break;
                        }
                    }
                    double d = sval.ToDoubleValue();
                    DateTime t = DateTime.FromOADate(d);
                    if (t.Date.CompareTo(new DateTime(2099, 12, 31)) < 0)
                    {
                        return t;
                    }
                    else
                    {
                        return new DateTime(1900, 1, 1);
                    }
                }
                else if (IsNumeric(sval))
                {
                    double d = sval.ToDoubleValue();
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
        /// 取去掉尾部数据标后的串
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string SymbolPart(this string val)
        {
            return val.TrimEnd("01234567890".ToCharArray());
        }

        /// <summary>
        /// 截去尾部相应字符
        /// </summary>
        /// <param name="val"></param>
        /// <param name="TrimChars"></param>
        public static void TrimEnd(this StringBuilder val, params char[] TrimChars)
        {
            List<char> chs = TrimChars.ToList();
            while (chs.Exists(C => C == val[val.Length - 1]))
            {
                val.Remove(val.Length - 1, 1);
            }
        }
        /// <summary>
        /// 截去首部相应字符
        /// </summary>
        /// <param name="val"></param>
        /// <param name="TrimChars"></param>
        public static void TrimStart(this StringBuilder val, params char[] TrimChars)
        {
            List<char> chs = TrimChars.ToList();
            while (chs.Exists(C => C == val[0]))
            {
                val.Remove(0, 1);
            }
        }

        /// <summary>
        /// 截去首尾相应字符
        /// </summary>
        /// <param name="val"></param>
        /// <param name="TrimChars"></param>
        public static void Trim(this StringBuilder val, params char[] TrimChars)
        {
            val.TrimStart(TrimChars);
            val.TrimEnd(TrimChars);
        }

        #endregion

        #region Data转换类
        /// <summary>
        /// 将DataRow转换成对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="r"></param>
        /// <returns></returns>
        /*
        public static T To<T>(this DataRow r)
        {
            T info = System.Activator.CreateInstance<T>();
            #region 赋值
            Type t = typeof(T);
            foreach (PropertyInfo prop in t.GetProperties())
            {
                if (r.Table.Columns.Contains(prop.Name))
                {
                    foreach (Attribute attr in prop.GetCustomAttributes(true))
                    {
                        if (attr is myselfField)
                        {
                            myselfField field = attr as myselfField;

                            switch (field.FieldType.ToLower())
                            {
                                case "varchar":
                                case "nvarchar":
                                case "string":
                                case "text":
                                case "ntext":
                                    if (field.IsDes)
                                    {
                                        prop.SetValue(info, Des.Decrypt(Utils.ToString(r[prop.Name])), null);
                                    }
                                    else
                                    {
                                        prop.SetValue(info, Utils.ToString(r[prop.Name]), null);
                                    }
                                    break;
                                case "bit":
                                case "bool":
                                case "boolean":
                                    prop.SetValue(info, Utils.ToBoolean(r[prop.Name]), null);
                                    break;
                                case "tinyint":
                                case "int":
                                    prop.SetValue(info, Utils.ToInt(r[prop.Name]), null);
                                    break;
                                case "long":
                                case "int64":
                                case "bigint":
                                    prop.SetValue(info, Utils.ToInt64(r[prop.Name]), null);
                                    break;
                                case "decimal":
                                case "float":
                                case "real":
                                    prop.SetValue(info, Utils.ToDecimal(r[prop.Name]), null);
                                    break;
                                case "double":
                                    prop.SetValue(info, Convert.ToDouble(r[prop.Name]), null);
                                    break;
                                case "datetime":
                                case "date":
                                    prop.SetValue(info, Utils.ToDateTime(r[prop.Name]), null);
                                    break;
                                case "uniqueidentifier":
                                    prop.SetValue(info, Utils.ToGuid(r[prop.Name]), null);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
            #endregion
            return info;
        }
        /// <summary>
        /// 将DataRowView转成对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="r"></param>
        /// <returns></returns>
        public static T To<T>(this DataRowView r)
        {
            if (r != null && r.Row != null) return To<T>(r.Row);
            return default(T);
        }
        /// <summary>
        /// 将SqlDataReader值转换成对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="r"></param>
        /// <returns></returns>
        public static T To<T>(this System.Data.SqlClient.SqlDataReader r)
        {
            T info = System.Activator.CreateInstance<T>();
            #region 赋值
            Type t = typeof(T);
            List<PropertyInfo> s = t.GetProperties().ToList();

            for (int i = 0; i < r.FieldCount; i++)
            {
                string fieldName = r.GetName(i);
                if (s.Exists(x => x.Name.Equals(fieldName, StringComparison.CurrentCultureIgnoreCase)))
                {
                    Func<PropertyInfo, bool> f = x => x.Name.Equals(fieldName, StringComparison.CurrentCultureIgnoreCase);
                    PropertyInfo prop = s.First<PropertyInfo>(f);
                    if (prop != null)
                    {
                        foreach (Attribute attr in prop.GetCustomAttributes(true))
                        {
                            if (attr is myselfField)
                            {
                                myselfField field = attr as myselfField;

                                switch (field.FieldType.ToLower())
                                {
                                    case "varchar":
                                    case "nvarchar":
                                    case "string":
                                    case "text":
                                    case "ntext":
                                        if (field.IsDes)
                                        {
                                            prop.SetValue(info, Des.Decrypt(Utils.ToString(r[prop.Name])), null);
                                        }
                                        else
                                        {
                                            prop.SetValue(info, Utils.ToString(r[prop.Name]), null);
                                        }
                                        break;
                                    case "bit":
                                    case "bool":
                                    case "boolean":
                                        prop.SetValue(info, Utils.ToBoolean(r[prop.Name]), null);
                                        break;
                                    case "tinyint":
                                    case "int":
                                        prop.SetValue(info, Utils.ToInt(r[prop.Name]), null);
                                        break;
                                    case "long":
                                    case "int64":
                                    case "bigint":
                                        prop.SetValue(info, Utils.ToInt64(r[prop.Name]), null);
                                        break;
                                    case "decimal":
                                    case "float":
                                    case "real":
                                        prop.SetValue(info, Utils.ToDecimal(r[prop.Name]), null);
                                        break;
                                    case "datetime":
                                    case "date":
                                        prop.SetValue(info, Utils.ToDateTime(r[prop.Name]), null);
                                        break;
                                    case "uniqueidentifier":
                                        prop.SetValue(info, Utils.ToGuid(r[prop.Name]), null);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            return info;
        }
         * */
        #endregion

        #region 取对象的属性值
        /// <summary>
        /// 取对象的属性值
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="prop">属性名</param>
        /// <returns>整型</returns>
        public static int GetIntPropValue(this Object obj, string prop)
        {
            List<PropertyInfo> s = obj.GetType().GetProperties().ToList();
            if (s.Exists(S => S.Name.Equals(prop, StringComparison.CurrentCultureIgnoreCase)))
            {
                PropertyInfo p = s.Find(S => S.Name.Equals(prop, StringComparison.CurrentCultureIgnoreCase));
                return (int)p.GetValue(obj, null);
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 取对象的属性值
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="prop">属性名</param>
        /// <returns>字符串</returns>
        public static string GetStringPropValue(this Object obj, string prop)
        {
            List<PropertyInfo> s = obj.GetType().GetProperties().ToList();
            if (s.Exists(S => S.Name.Equals(prop, StringComparison.CurrentCultureIgnoreCase)))
            {
                PropertyInfo p = s.Find(S => S.Name.Equals(prop, StringComparison.CurrentCultureIgnoreCase));
                return p.GetValue(obj, null).ToString();
            }
            else
            {
                return null;
            }
        }
        public static object GetObjectPropValue(this Object obj, string prop)
        {
            List<PropertyInfo> s = obj.GetType().GetProperties().ToList();
            if (s.Exists(S => S.Name.Equals(prop, StringComparison.CurrentCultureIgnoreCase)))
            {
                PropertyInfo p = s.Find(S => S.Name.Equals(prop, StringComparison.CurrentCultureIgnoreCase));
                return p.GetValue(obj, null);
            }
            else
            {
                return null;
            }
        }
        public static string GetObjectPropType(this Object obj, string prop)
        {
            List<PropertyInfo> s = obj.GetType().GetProperties().ToList();
            if (s.Exists(S => S.Name.Equals(prop, StringComparison.CurrentCultureIgnoreCase)))
            {
                PropertyInfo p = s.Find(S => S.Name.Equals(prop, StringComparison.CurrentCultureIgnoreCase));
                return p.GetValue(obj, null).GetType().ToString();
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region DataTable,List相互转换
        //public static List<T> ToList<T>(this List<DataRow> rows)
        //{
        //    List<T> list = null;
        //    if (rows != null)
        //    {
        //        list = new List<T>();
        //        foreach (DataRow row in rows)
        //        {
        //            T item = row.To<T>();
        //            list.Add(item);
        //        }
        //    }
        //    return list;
        //}
        //public static List<T> ToList<T>(this DataTable table)
        //{
        //    if (table != null)
        //    {
        //        var rows = table.Rows.Cast<DataRow>().ToList();

        //        return rows.ToList<T>();
        //    }
        //    else
        //    {
        //        return new List<T>();
        //    }
        //}

        public static DataTable ToDataTable<T>(this IList<T> list)
        {
            Type entityType = typeof(T);
            DataTable table = new DataTable(entityType.Name);
            System.ComponentModel.PropertyDescriptorCollection properties = System.ComponentModel.TypeDescriptor.GetProperties(entityType);
            foreach (System.ComponentModel.PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, prop.PropertyType);
            foreach (T item in list)
            {
                DataRow row = table.NewRow();
                foreach (System.ComponentModel.PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item);
                table.Rows.Add(row);
            }
            return table;
        }
        
        #endregion
       

    }
}

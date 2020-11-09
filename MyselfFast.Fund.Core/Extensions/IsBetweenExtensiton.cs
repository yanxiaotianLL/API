using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Common.Extensions
{
    /// <summary>
    /// 泛型版本 IsBetween 扩展
    /// </summary>
    public static  class IsBetweenExtensiton
    {
        /// <summary>
        /// 范围判断
        /// </summary>
        /// <typeparam name="T">泛型类型</typeparam>
        /// <param name="t">扩展类型</param>
        /// <param name="lowerBound">最小值</param>
        /// <param name="upperBound">最大值</param>
        /// <param name="includeLowerBound">是否包括最小边界值</param>
        /// <param name="includeUpperBound">是否包括最大边界值</param>
        /// <returns></returns>
        public static bool IsBetween<T>(this T t, T lowerBound, T upperBound,
    bool includeLowerBound = false, bool includeUpperBound = false)
        where T : IComparable<T>
        {
            if (t == null) throw new ArgumentNullException("t");

            var lowerCompareResult = t.CompareTo(lowerBound);
            var upperCompareResult = t.CompareTo(upperBound);

            return (includeLowerBound && lowerCompareResult == 0) ||
                (includeUpperBound && upperCompareResult == 0) ||
                (lowerCompareResult > 0 && upperCompareResult < 0);
        }
        /// <summary>
        /// 带 IComparer<T> 参数的 IsBetween 扩展
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="lowerBound"></param>
        /// <param name="upperBound"></param>
        /// <param name="comparer"></param>
        /// <param name="includeLowerBound"></param>
        /// <param name="includeUpperBound"></param>
        /// <returns></returns>
        public static bool IsBetween<T>(this T t, T lowerBound, T upperBound, IComparer<T> comparer,
    bool includeLowerBound = false, bool includeUpperBound = false)
        {
            if (comparer == null) throw new ArgumentNullException("comparer");

            var lowerCompareResult = comparer.Compare(t, lowerBound);
            var upperCompareResult = comparer.Compare(t, upperBound);

            return (includeLowerBound && lowerCompareResult == 0) ||
                (includeUpperBound && upperCompareResult == 0) ||
                (lowerCompareResult > 0 && upperCompareResult < 0);
        }
        //public class PersonBirthdayComparer : IComparer<Person>
        //{
        //    public int Compare(Person x, Person y)
        //    {
        //        return Comparer<DateTime>.Default.Compare(x.Birthday, y.Birthday);
        //    }
        //}
        /// <summary>
        /// 针对 IComparable<T> 接口的 IsBetween 扩展
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="lowerBound"></param>
        /// <param name="upperBound"></param>
        /// <param name="includeLowerBound"></param>
        /// <param name="includeUpperBound"></param>
        /// <returns></returns>
        public static bool IsBetween<T>(this IComparable<T> t, T lowerBound, T upperBound,
    bool includeLowerBound = false, bool includeUpperBound = false)
        {
            if (t == null) throw new ArgumentNullException("t");

            var lowerCompareResult = t.CompareTo(lowerBound);
            var upperCompareResult = t.CompareTo(upperBound);

            return (includeLowerBound && lowerCompareResult == 0) ||
                (includeUpperBound && upperCompareResult == 0) ||
                (lowerCompareResult > 0 && upperCompareResult < 0);
        }
    }
}

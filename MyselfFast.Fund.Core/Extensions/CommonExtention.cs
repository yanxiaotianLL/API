using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Common.Extensions
{
    /// <summary>
    /// 通用扩展
    /// </summary>
    public static  class CommonExtention
    {
        //In扩展-泛型版本
        public static bool In<T>(this T t, params T[] c)
        {
            return c.Any(i => i.Equals(t));
        }
        public static bool IsNotNull(this IList list)
        {
            return list != null && list.Count > 0;
        }

    }
}

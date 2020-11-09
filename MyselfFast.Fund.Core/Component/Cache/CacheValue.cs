using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.Cache
{
   public class CacheValue<T> {
        public CacheValue(T value, bool hasValue) {
            Value = value;
            HasValue = hasValue;
        }

        public bool HasValue { get; set;}

        public bool IsNull(){
            return Value == null;
        }

        public T Value { get;set; }

        public static CacheValue<T> Null()
        {
            return new CacheValue<T>(default(T), true);
        }

        public static CacheValue<T> NoValue()
        {
            return new CacheValue<T>(default(T), false);
        }

        public override string ToString() {
            return Value.ToString() ?? "<null>";
        }
    }
    /// <summary>
    /// 过期方式
    /// </summary>
   public enum ExpirationMethod
   {
       AbsoluteExpiration = 0,//绝对过期
       SlidingExpiration = 1//滑动过期
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core.Common;

namespace myselfFast.Fund.Core.Common
{
    public class SignHelper
    {
        /// <summary>
        /// 签名计算
        /// </summary>
        /// <param name="paramDic"></param>
        /// <returns></returns>
        public static string SignCreate(List<KeyValuePair<string, string>> paramDic, string appsecret)
        {
            paramDic = paramDic.Where(p => !string.IsNullOrEmpty(p.Value)).ToList();
            paramDic.Sort((a, b) => String.Compare(a.Key, b.Key, false));
            var text = string.Concat(paramDic.Select(p => string.Concat(p.Key, p.Value)));
            var sign = EncryptHelper.MD5(appsecret + text.EncodingToUtf8()).ToLower();
            return sign;
        }

        /// <summary>
        /// 生成随机串
        /// </summary>
        /// <returns></returns>
        public static string CreateNoncestr()
        {
            return Guid.NewGuid().ToString();
        }
        /// <summary>
        /// 生成时间戳
        /// </summary>
        /// <returns></returns>
        public static long CreateTimeStamp()
        {
            return TimeStampHelper.DateTimeToStamp(DateTime.Now);
        }

        /// <summary>
        /// 生成时间戳
        /// </summary>
        /// <returns></returns>
        public static long CreateTimeStamp(DateTime dt)
        {
            return TimeStampHelper.DateTimeToStamp(dt);
        }
    }
}

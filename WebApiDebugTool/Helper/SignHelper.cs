using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Common.Extensions;
using LitJson2;
using myselfFast.Fund.Core.Common;

namespace WebApiDebugTool.Helper
{
    /**********************************************************************************
     *项目名称	：WebApiDebugTool.Helper
     *项目描述  ：
     *类名称    ：SignHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : SignHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/4 13:54:44
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
   public   class SignHelper
    {
        /// <summary>
        /// 签名所需参数部分处理
        /// </summary>
        /// <param name="paramDic"></param>
        /// <param name="jsonParamter"></param>
        public static void JsonParamtersToSign(List<KeyValuePair<string, string>> paramDic, string jsonParamter)
        {
            JsonData jd = JsonMapper.ToObject(jsonParamter);

            foreach (var p in jd.Keys)
            {
                var v = jd[p];
                if (v.IsObject || v.IsArray)
                {

                    //暂时不在签名中使用
                }
                else
                {
                    paramDic.Add(new KeyValuePair<string, string>(p, jd[p].ToString()));
                }
            }
        }
        /// <summary>
        /// 签名所需参数部分处理
        /// </summary>
        /// <param name="paramDic"></param>
        /// <param name="jsonParamter"></param>
        public static void JsonParamtersToSign(List<KeyValuePair<string, string>> paramDic, JsonData jsonParamter)
        {
            JsonData jd = jsonParamter;

            foreach (var p in jd.Keys)
            {
                var v = jd[p];
                if (v.IsObject || v.IsArray)
                {
                    //暂时不在签名中使用
                }
                else
                {
                    paramDic.Add(new KeyValuePair<string, string>(p, jd[p].ToString()));
                }
            }
        }
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
            var sign = EncryptHelperTwo.MD5One(appsecret + text.EncodingToUtf8()).ToLower();
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
    }
}

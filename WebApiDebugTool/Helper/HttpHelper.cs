using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Common.Extensions;
using LitJson2;

namespace WebApiDebugTool.Helper
{
    /**********************************************************************************
     *项目名称	：WebApiDebugTool.Helper
     *项目描述  ：
     *类名称    ：HttpHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : HttpHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/4 13:48:22
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class HttpParmpterHelper
    {
        public static string appid = "HeloHRAdmin";
        public static string appsecret = "5s6ver9vbhb3e8rtt7111czs6w8qfq31";
        public static string CreateGetUrlAndParm(string jsonParmters)
        {
            string sign = string.Empty;
            string nonestr = string.Empty;
            string timestamp = string.Empty;
            List<KeyValuePair<string, string>> paramDic = new List<KeyValuePair<string, string>>();
            paramDic.Add(new KeyValuePair<string, string>(SignParamter.AppAccount, appid));
            nonestr = SignHelper.CreateNoncestr();
            paramDic.Add(new KeyValuePair<string, string>(SignParamter.Noncestr, nonestr));
            timestamp = SignHelper.CreateTimeStamp().ToString();
            paramDic.Add(new KeyValuePair<string, string>(SignParamter.Timestamp, timestamp));
            


            //拼接字符串
            string parmStr = string.Empty;
            if (!string.IsNullOrEmpty(jsonParmters))
            {
                jsonParmters = jsonParmters.EncodingToUtf8();
                SignHelper.JsonParamtersToSign(paramDic, jsonParmters);
                sign = SignHelper.SignCreate(paramDic, appsecret);
               parmStr =  string.Format("?{0}={1}&{2}={3}&{4}={5}&{6}={7}&{8}={9}", SignParamter.AppAccount, appid,
                    SignParamter.Noncestr, nonestr, SignParamter.Timestamp, timestamp, SignParamter.Signature, sign,
                    SignParamter.JsonParam, jsonParmters);
            }
            else
            {
                //SignHelper.JsonParamtersToSign(paramDic, jsonParmters);
                sign = SignHelper.SignCreate(paramDic, appsecret);
                parmStr = string.Format("?{0}={1}&{2}={3}&{4}={5}&{6}={7}", SignParamter.AppAccount, appid,
                SignParamter.Noncestr, nonestr, SignParamter.Timestamp, timestamp, SignParamter.Signature, sign);
            }
            return parmStr;
        }
        /// <summary>
        /// post请求构造
        /// </summary>
        /// <param name="jsonParmters"></param>
        /// <returns></returns>
        public static string CreatePostParm(string jsonParmters)
        {
            RequestEntity requestEntity = new RequestEntity();
            List<KeyValuePair<string, string>> paramDic = new List<KeyValuePair<string, string>>();
            paramDic.Add(new KeyValuePair<string, string>(SignParamter.AppAccount, appid));
            requestEntity.noncestr = SignHelper.CreateNoncestr();
            requestEntity.appaccount = appid;
            paramDic.Add(new KeyValuePair<string, string>(SignParamter.Noncestr, requestEntity.noncestr));
            requestEntity.timestamp = SignHelper.CreateTimeStamp().ToString();
            paramDic.Add(new KeyValuePair<string, string>(SignParamter.Timestamp, requestEntity.timestamp));
            SignHelper.JsonParamtersToSign(paramDic, jsonParmters);
            requestEntity.sign = SignHelper.SignCreate(paramDic, appsecret);
            requestEntity.jsonParam = "";
            //requestEntity.jsonParam = LitJson2.JsonMapper.ToObject(jsonParmters);
            //拼接字符串
            
            string parmStr = LitJson2.JsonMapper.ToJson(requestEntity);
            JsonData jd = LitJson2.JsonMapper.ToObject(parmStr);
            jd["jsonParam"] = LitJson2.JsonMapper.ToObject(jsonParmters);
            parmStr = jd.ToJson().EncodingToUtf8();
            return parmStr;
        }
       
    }
    /// <summary>
    /// post的请求辅助类
    /// </summary>
    public class RequestEntity
    {
        public string sign { get; set; }
        public string noncestr { get; set; }
        public string timestamp { get; set; }
        public string appaccount { get; set; }
        public string jsonParam { get; set; }
    }
}

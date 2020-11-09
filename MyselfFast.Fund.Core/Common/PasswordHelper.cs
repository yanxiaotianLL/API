using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Fund.Core.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Common
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Common
     *项目描述  ：与java对称的加解密操作
     *类名称    ：PasswordHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : PasswordHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-31 10:56:57
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static class PasswordHelper
    {
        public static string defaultPass = "@wsxzaq1";
        ///<summary><![CDATA[字符串DES加密函数]]></summary>  
        ///<param name="str"><![CDATA[被加密字符串 ]]></param>  
        ///<param name="key"><![CDATA[密钥 ]]></param>   
        ///<returns><![CDATA[加密后字符串]]></returns>     
        public static string EncodeDES(string str, string key)
        {
            try
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.Key = Encoding.ASCII.GetBytes(key.Substring(0, 8));
                provider.IV = Encoding.ASCII.GetBytes(key.Substring(0, 8));
                byte[] bytes = Encoding.GetEncoding("UTF-8").GetBytes(str);
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(), CryptoStreamMode.Write);
                stream2.Write(bytes, 0, bytes.Length);
                stream2.FlushFinalBlock();
                StringBuilder builder = new StringBuilder();
                foreach (byte num in stream.ToArray())
                {
                    builder.AppendFormat("{0:X2}", num);
                }
                stream.Close();
                return builder.ToString();
            }
            catch (Exception ex)
            {
                var log = EngineContext.Current.Resolve<ILoggerProviderFactory>().CreateLogger(myselfFast.Component.Logging.LoggerType.LogEntity);
                log.Error(null, string.Format("str:{0},key:{1}", str, key), ex);

            }
            return "";
        }
        ///<summary><![CDATA[字符串DES解密函数]]></summary>  
        ///<param name="str"><![CDATA[被解密字符串 ]]></param>  
        ///<param name="key"><![CDATA[密钥 ]]></param>   
        ///<returns><![CDATA[解密后字符串]]></returns>     
        public static string DecodeDES(string str, string key)
        {
            try
            {
                if (!string.IsNullOrEmpty(str))
                {
                    DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                    provider.Key = Encoding.ASCII.GetBytes(key.Substring(0, 8));
                    provider.IV = Encoding.ASCII.GetBytes(key.Substring(0, 8));
                    byte[] buffer = new byte[str.Length / 2];
                    for (int i = 0; i < (str.Length / 2); i++)
                    {
                        int num2 = Convert.ToInt32(str.Substring(i * 2, 2), 0x10);
                        buffer[i] = (byte)num2;
                    }
                    MemoryStream stream = new MemoryStream();
                    CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor(), CryptoStreamMode.Write);
                    stream2.Write(buffer, 0, buffer.Length);
                    stream2.FlushFinalBlock();
                    stream.Close();
                    return Encoding.GetEncoding("UTF-8").GetString(stream.ToArray());
                }
                else
                    return "";
            }
            catch (Exception ex)
            {
                var log = EngineContext.Current.Resolve<ILoggerProviderFactory>().CreateLogger(myselfFast.Component.Logging.LoggerType.LogEntity);
                log.Error(null, string.Format("str:{0},key:{1}", str, key), ex);

            }
            return "";
        }

        public static string Md5(string value)
        {
            byte[] result = Encoding.UTF8.GetBytes(value);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "");
        }

        public static string GetPass()
        {
            string key = XMLConfigHelper.GetValue("datapass").ToString();
            return PasswordHelper.DecodeDES(key, PasswordHelper.defaultPass);
        }
        /// <summary>
        /// 默认加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string EncodeDES(string str)
        {
            string pass = GetPass();
            return EncodeDES(str, pass);
        }
        /// <summary>
        /// 默认解密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string DecodeDES(string str)
        {
            string pass = GetPass();
            return DecodeDES(str, pass);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using myselfFast.Fund.Core.Common.Extensions;

namespace myselfFast.Fund.Core.Common
{
    public class Encryption
    {
        #region ========加密========

        /// <summary> 
        /// 加密 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <returns></returns> 
        public static string Encrypt(string Text)
        {
            if (Text == "") return Text;
            return Encrypt(Text, "key!(*&");
        }
        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Encrypt(string Text, string sKey)
        {

            try
            {

            

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray;
            inputByteArray = Encoding.Default.GetBytes(Text);
            des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            return ret.ToString();
            }
            catch (Exception)
            {

                return Text;
            }
        }

     
      
        #endregion

        #region ========解密========


        /// <summary> 
        /// 解密 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <returns></returns> 
        public static string Decrypt(string Text)
        {
            if (Text == "") return Text;
            return Decrypt(Text, "key!(*&");
        }
        /// <summary> 
        /// 解密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Decrypt(string Text, string sKey)
        {

            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                int len;
                len = Text.Length / 2;
                byte[] inputByteArray = new byte[len];
                int x, i;
                for (x = 0; x < len; x++)
                {
                    i = Convert.ToInt32(Text.Substring(x * 2, 2), 16);
                    inputByteArray[x] = (byte)i;
                }
                des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
                des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Encoding.Default.GetString(ms.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static bool IsEncrypted(string Text)
        {
            return IsEncrypted(Text, "key!(*&");
        }
        /// <summary>
        /// 判断是否已加密
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="sKey"></param>
        /// <returns></returns>
        private static bool IsEncrypted(string Text, string sKey)
        {
            if (string.IsNullOrWhiteSpace(Text)) return false;
            try
            {
                if (Text.IsNumber()) return false;
                char[] c = Text.ToCharArray();
                for (int n = 0; n < c.Length; n++)
                    if (c[n] >= 0x4e00 && c[n] <= 0x9fbb)
                        return false;

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                int len;
                len = Text.Length / 2;
                byte[] inputByteArray = new byte[len];
                int x, i;
                for (x = 0; x < len; x++)
                {
                    i = Convert.ToInt32(Text.Substring(x * 2, 2), 16);
                    inputByteArray[x] = (byte)i;
                }
                des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
                des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return true;
            }
            catch
            {
                //Utils.WirteLog("DES问题：", Text);
                return false;
            }
        }
        #endregion 
        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static void SetEncrypt(object obj)
        {
            if (obj.GetType().Name == "T_Fes_User")
            {
                PropertyInfo[] ps = obj.GetType().GetProperties();
                foreach (PropertyInfo p in ps)
                {
                    //string md5p = pass.EnCode(Exten.CodeType.MD5).ToLower();
                    if (p.PropertyType == typeof(string) && p.GetValue(obj, null) == null)
                    {
                        p.SetValue(obj, "", null);
                    }
                    if (p.Name == "Fname" || p.Name == "Cname" || p.Name == "Ename" || p.Name == "Sname" || p.Name == "CardId" || p.Name == "Mobile" || p.Name == "Email" || p.Name == "Fname")
                    {
                        p.SetValue(obj, Encrypt(p.GetValue(obj, null).ToString()), null);
                    }

                }
            }
            else if (obj.GetType().Name == "T_Fes_Shouaddr")
            {
                PropertyInfo[] ps = obj.GetType().GetProperties();
                foreach (PropertyInfo p in ps)
                {

                    if (p.PropertyType == typeof(string) && p.GetValue(obj, null) == null)
                    {
                        p.SetValue(obj, "", null);
                    }
                    if (p.Name == "Shouman" || p.Name == "Addr" || p.Name == "Mobile" || p.Name == "Email")
                    {
                        p.SetValue(obj, Encrypt(p.GetValue(obj, null).ToString()), null);
                    }

                }
            }

        }
        /// <summary>
        /// user表解密
        /// </summary>
        /// <param name="obj"></param>
        public static void SetDecrypt(object obj)
        {
            if (obj.GetType().Name == "T_Fes_User")
            {
                PropertyInfo[] ps = obj.GetType().GetProperties();
                foreach (PropertyInfo p in ps)
                {

                    if (p.PropertyType == typeof(string) && p.GetValue(obj, null) == null)
                    {
                        p.SetValue(obj, "", null);
                    }
                    if (p.Name == "Fname" || p.Name == "Cname" || p.Name == "Ename" || p.Name == "Sname" || p.Name == "CardId" || p.Name == "Mobile" || p.Name == "Email" || p.Name == "Fname")
                    {
                        p.SetValue(obj, Decrypt(p.GetValue(obj, null).ToString()), null);
                    }

                }
            }
            else if (obj.GetType().Name == "T_Fes_Shouaddr")
            {
                PropertyInfo[] ps = obj.GetType().GetProperties();
                foreach (PropertyInfo p in ps)
                {

                    if (p.PropertyType == typeof(string) && p.GetValue(obj, null) == null)
                    {
                        p.SetValue(obj, "", null);
                    }
                    if (p.Name == "Shouman" || p.Name == "Addr" || p.Name == "Mobile" || p.Name == "Email")
                    {
                        p.SetValue(obj, Decrypt(p.GetValue(obj, null).ToString()), null);
                    }

                }
            }
        }


         
    }
}

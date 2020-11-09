using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace myselfFast.Component.MsgMobile
{
    /**********************************************************************************
     *项目名称	：FS.Component.MsgMobile
     *项目描述  ：
     *类名称    ：SendMsgHCommpont
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : SendMsgHCommpont
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/11 14:18:01
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class MsgMobile
    {
        //private const string msgAPI = "http://10.44.181.68:9053/communication/sendSms.ashx";
        //private const string msgAPI89 = "http://10.44.183.161:9053/communication/sendSms.ashx";


        private const string msgAPI = "http://proxy144.myself.com.cn:9053/communication/sendSms.ashx";
        private const string msgAPI89 = "http://proxy89.myself.com.cn:9053/communication/sendSms.ashx";

        private const string postStr = "cid=ODI0Ng==&pwd=MTIzNDU2&productid=20141114&mobile={0}=&content={1}&lcode=123&ssid=1000010&format=32&sign={2}&custom=";

        #region  发送到144服务器的发送短信方法
        public static bool SendMsg(string phone, string content, CreateMsgLogHandler logHandler, SendEmailHandler sendEmailHandler)
        {
            bool rel = false;
            Encoding cd = Encoding.UTF8;
            //Encoding.GetEncoding(1200);
            //MsgService.SendSms ser = new MsgService.SendSms();
            byte[] bytes = cd.GetBytes(HttpUtility.UrlEncode(phone));
            string bp = Convert.ToBase64String(bytes);

            byte[] bytes2 = cd.GetBytes(HttpUtility.UrlEncode(content + "【myself】"));
            string bc = Convert.ToBase64String(bytes2);

            byte[] bytes3 = cd.GetBytes(HttpUtility.UrlEncode("【myself】"));
            string si = Convert.ToBase64String(bytes3);

            string post = string.Format(postStr, bp, bc, si);

            try
            {
                string str = HttpHelper.HttpPost(msgAPI, post, Encoding.UTF8);
                LitJson2.JsonData JD = LitJson2.JsonMapper.ToObject(str);
                if (JD["status"].ToString() == "0")
                {
                    //如果发送成功,记录到T_HELO_MsgLog
                    if (logHandler != null)
                    {
                        logHandler(phone,"", content, "");
                    }
                    rel = true;
                }
            }
            catch
            {
                SendMsg89(phone, content,logHandler,sendEmailHandler);//通过db去发送

            }

            return rel;
        }
        public static bool SendMsg(string phone, string content,CreateMsgLogHandler logHandler,SendEmailHandler sendEmailHandler, ref string msg)
        {
            bool rel = false;
            Encoding cd = Encoding.UTF8;
            //Encoding.GetEncoding(1200);
            //MsgService.SendSms ser = new MsgService.SendSms();
            byte[] bytes = cd.GetBytes(HttpUtility.UrlEncode(phone));
            string bp = Convert.ToBase64String(bytes);

            byte[] bytes2 = cd.GetBytes(HttpUtility.UrlEncode(content + "【myself】"));
            string bc = Convert.ToBase64String(bytes2);

            byte[] bytes3 = cd.GetBytes(HttpUtility.UrlEncode("【myself】"));
            string si = Convert.ToBase64String(bytes3);

            string post = string.Format(postStr, bp, bc, si);

            try
            {
                string str = HttpHelper.HttpPost(msgAPI, post, Encoding.UTF8);
                msg = str;
                LitJson2.JsonData JD = LitJson2.JsonMapper.ToObject(str);
                if (JD["status"].ToString() == "0")
                {
                    //如果发送成功,记录到T_HELO_MsgLog
                    if (logHandler != null)
                    {
                        logHandler(phone, "", content, "");
                    }
                    rel = true;
                }
            }
            catch
            {
                SendMsg89(phone, content,logHandler,sendEmailHandler, ref msg);//通过db去发送
            }

            return rel;
        }
        #endregion

        #region  发送到DB服务器的发送短信方法
        public static bool SendMsg89(string phone, string content, CreateMsgLogHandler logHandler,SendEmailHandler sendEmailHandler)
        {
            bool rel = false;
            Encoding cd = Encoding.UTF8;
            byte[] bytes = cd.GetBytes(HttpUtility.UrlEncode(phone));
            string bp = Convert.ToBase64String(bytes);

            byte[] bytes2 = cd.GetBytes(HttpUtility.UrlEncode(content + "【myself】"));
            string bc = Convert.ToBase64String(bytes2);

            byte[] bytes3 = cd.GetBytes(HttpUtility.UrlEncode("【myself】"));
            string si = Convert.ToBase64String(bytes3);

            string post = string.Format(postStr, bp, bc, si);

            try
            {
                string str = HttpHelper.HttpPost(msgAPI89, post, Encoding.UTF8);
                LitJson2.JsonData JD = LitJson2.JsonMapper.ToObject(str);
                if (JD["status"].ToString() == "0")
                {
                    //如果发送成功,记录到T_HELO_MsgLog
                    if (logHandler != null)
                    {
                        logHandler(phone,"", content, "");
                    }
                    rel = true;
                }
            }
            catch (Exception ex)
            {
                //如果发送失败,记录到T_HELO_MsgLog,并且发送邮件给zhu.zhi.peng
                if (logHandler != null)
                {
                    logHandler(phone, "", content, "");
                }
                if (sendEmailHandler != null)
                {
                    sendEmailHandler(ex.Message,phone);
                }
                //myself.Common.Mails.send("", "zhu.zhi.peng@myself.com.cn",
                //        "有短信内容发送失败,需要处理!", "时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + ",手机号:" + phone + ",用户发送短信失败,已记录到数据库,需处理!</br>" + ex.Message);
            }

            return rel;
        }

        public static bool SendMsg89(string phone, string content,CreateMsgLogHandler logHandler,SendEmailHandler sendEmailHandler, ref string msg)
        {
            bool rel = false;
            Encoding cd = Encoding.UTF8;
            byte[] bytes = cd.GetBytes(HttpUtility.UrlEncode(phone));
            string bp = Convert.ToBase64String(bytes);

            byte[] bytes2 = cd.GetBytes(HttpUtility.UrlEncode(content + "【myself】"));
            string bc = Convert.ToBase64String(bytes2);

            byte[] bytes3 = cd.GetBytes(HttpUtility.UrlEncode("【myself】"));
            string si = Convert.ToBase64String(bytes3);

            string post = string.Format(postStr, bp, bc, si);

            try
            {
                string str = HttpHelper.HttpPost(msgAPI, post, Encoding.UTF8);
                msg = str;
                LitJson2.JsonData JD = LitJson2.JsonMapper.ToObject(str);
                if (JD["status"].ToString() == "0")
                {
                    //如果发送成功,记录到T_HELO_MsgLog
                    if (logHandler != null)
                    {
                        logHandler(phone, "", content, "");
                    }
                    rel = true;
                }
            }
            catch (Exception ex)
            {
                //如果发送失败,记录到T_HELO_MsgLog,并且发送邮件给zhu.zhi.peng
                if (logHandler != null)
                {
                    logHandler(phone, "", content, "");
                }
                if (sendEmailHandler != null)
                {
                    sendEmailHandler(ex.Message, phone);
                }
                //myself.Common.Mails.send("", "zhu.zhi.peng@myself.com.cn",
                //        "有短信内容发送失败,需要处理!", "时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + ",手机号:" + phone + ",用户发送短信失败,已记录到数据库,需处理!</br>" + ex.Message);
            }

            return rel;
        }

        #endregion

        /*
        #region 如果发送成功,记录到T_HELO_MsgLog
        public static void CreateMsgLog(string phone, string content)
        {
            if (content.IndexOf("验证码") > 0 || content.IndexOf("您的密码已经更新") > 0)
            {
                return;
            }
            if (phone == null || phone.Equals(""))
            {
                return;
            }
            THeloMsglogInfo msglog = new THeloMsglogInfo();
            msglog.Isneedtry = 0;
            msglog.Mobileno = phone;
            msglog.Msgcontent = content;
            msglog.Sendtime = DateTime.Now;
            msglog.Status = 1; //表示是发送成功的数据
            msglog.Trysendtime = DateTime.Parse("1900-01-01");
            msglog.Trytimes = 0;
            msglog.Isdel = 0;
            msglog.Errorcontent = "";
            myselfEntity.Create<THeloMsglogInfo>(msglog);
        }
        #endregion

        #region 如果发送失败,记录到T_HELO_MsgLog
        public static void CreateMsgLog(string phone, string content, string err)
        {
            if (content.IndexOf("验证码") > 0 || content.IndexOf("您的密码已经更新") > 0)
            {
                return;
            }
            if (phone == null || phone.Equals(""))
            {
                return;
            }
            THeloMsglogInfo msglog = new THeloMsglogInfo();
            msglog.Isneedtry = 1;
            msglog.Mobileno = phone;
            msglog.Msgcontent = content;
            msglog.Sendtime = DateTime.Now;
            msglog.Status = 0; //表示是发送失败的数据
            msglog.Trysendtime = DateTime.Parse("1900-01-01");
            msglog.Trytimes = 0;
            msglog.Isdel = 0;
            msglog.Errorcontent = err;
            myselfEntity.Create<THeloMsglogInfo>(msglog);
        }
        #endregion

        */

    }

    #region HttpHelper 类
    public class HttpHelper
    {

        //Encoding.GetEncoding("utf-8")编码

        private static readonly string DefaultUserAgent = @"Mozilla/5.0 (Windows NT 6.2; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/32.0.1667.0 Safari/537.36 J.HTTP/2.0";




        /// <summary>
        /// 把HttpWebResponse对象读取成字符串
        /// </summary>
        /// <param name="response">请求到的对象</param>
        /// <param name="readEncode">本地读取用的encode</param>
        /// <returns></returns>
        public static string ResToString(HttpWebResponse response, Encoding readEncode)
        {
            Stream stream = response.GetResponseStream();
            Encoding myEncoding = readEncode;
            Encoding tarEncode = readEncode;
            StreamReader streamReader = new StreamReader(stream, myEncoding);
            string html = streamReader.ReadToEnd();
            if (html == "")
            {
                return "";
            }
            string set = @"(?i)\bcharset=(?<charset>[-a-zA-Z_0-9]+)";
            string charset = Regex.Match(html, set).Groups["charset"].Value.Trim();
            if (!string.IsNullOrEmpty(charset))
            {
                try
                {
                    tarEncode = Encoding.GetEncoding(charset);
                }
                catch
                {
                }
            }
            if (tarEncode != myEncoding)
            {
                streamReader = new StreamReader(stream, tarEncode);
                html = streamReader.ReadToEnd();
            }
            return html;
        }



        /// <summary>
        /// post请求返回字符串
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postData"></param>
        /// <param name="requestEncoding"></param>
        /// <returns></returns>
        public static string HttpPost(string url, string postData, Encoding requestEncoding)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }

            HttpWebRequest request = null;

            request = WebRequest.Create(url) as HttpWebRequest;

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = DefaultUserAgent;

            //POST数据  
            if (!string.IsNullOrEmpty(postData))
            {
                StringBuilder buffer = new StringBuilder(postData);
                byte[] data = requestEncoding.GetBytes(buffer.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            return ResToString(request.GetResponse() as HttpWebResponse, requestEncoding);
        }




    }
    #endregion
}

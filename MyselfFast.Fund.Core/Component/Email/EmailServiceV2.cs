using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Common;
using myselfFast.Component.Email;
using System;
using System.ComponentModel;
using System.Text;
using System.Web.Mail;

namespace myselfFast.Component.Email
{
    /**********************************************************************************
     *项目名称	：myselfFast.Advertise.Core.Component.Email
     *项目描述  ：
     *类名称    ：EmailServiceV2
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : EmailServiceV2
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-07-04 15:30:37
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/

    public class EmailServiceV2 : IEmail
    {
        private ILoggerProviderFactory loggerProvderFactory;

        public EmailServiceV2(ILoggerProviderFactory loggerProvderFactory)
        {
            this.loggerProvderFactory = loggerProvderFactory;
        }

        public void SendEmail(string to, string subject, string message)
        {
            Send(GlobalConfiguration.Configuration.EmailServer.EmailHostIP, int.Parse(GlobalConfiguration.Configuration.EmailServer.EmailHostPort), GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, GlobalConfiguration.Configuration.EmailServer.EmailFromPassword, to, subject, message);
        }

        public void SendEmail(string to, string cc, string bcc, string subject, string message)
        {
            Send(GlobalConfiguration.Configuration.EmailServer.EmailHostIP, int.Parse(GlobalConfiguration.Configuration.EmailServer.EmailHostPort), GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, GlobalConfiguration.Configuration.EmailServer.EmailFromPassword, to, subject, message, cc, bcc, null);
        }

        public void SendEmail(string[] to, string[] cc, string[] bcc, string subject, string message)
        {
            Send(GlobalConfiguration.Configuration.EmailServer.EmailHostIP, int.Parse(GlobalConfiguration.Configuration.EmailServer.EmailHostPort), GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, GlobalConfiguration.Configuration.EmailServer.EmailFromPassword, EmailConcat(to), subject, message, EmailConcat(cc), EmailConcat(bcc), null);
        }

        public void SendIndiviualEmailPerRecipient(string[] to, string subject, string message)
        {
            foreach (var t in to)
            {
                Send(GlobalConfiguration.Configuration.EmailServer.EmailHostIP, int.Parse(GlobalConfiguration.Configuration.EmailServer.EmailHostPort), GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, GlobalConfiguration.Configuration.EmailServer.EmailFromPassword, t, subject, message);
            }
        }

        public void SendEmail(string to, string subject, string message, string[] attachment)
        {
            Send(GlobalConfiguration.Configuration.EmailServer.EmailHostIP, int.Parse(GlobalConfiguration.Configuration.EmailServer.EmailHostPort), GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, GlobalConfiguration.Configuration.EmailServer.EmailFromPassword, to, subject, message, null, null, attachment);
        }

        public void SendEmail(string to, string cc, string bcc, string subject, string message, string[] attachment)
        {
            Send(GlobalConfiguration.Configuration.EmailServer.EmailHostIP, int.Parse(GlobalConfiguration.Configuration.EmailServer.EmailHostPort), GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, GlobalConfiguration.Configuration.EmailServer.EmailFromPassword, to, subject, message, cc, bcc, attachment);
        }

        public void SendEmail(string[] to, string[] cc, string[] bcc, string subject, string message, string[] attachment)
        {
            Send(GlobalConfiguration.Configuration.EmailServer.EmailHostIP, int.Parse(GlobalConfiguration.Configuration.EmailServer.EmailHostPort), GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, GlobalConfiguration.Configuration.EmailServer.EmailFromPassword, EmailConcat(to), subject, message, EmailConcat(cc), EmailConcat(bcc), attachment);
        }

        public void SendIndiviualEmailPerRecipient(string[] to, string subject, string message, string[] attachment)
        {
            foreach (var t in to)
            {
                Send(GlobalConfiguration.Configuration.EmailServer.EmailHostIP, int.Parse(GlobalConfiguration.Configuration.EmailServer.EmailHostPort), GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, GlobalConfiguration.Configuration.EmailServer.EmailFromPassword, EmailConcat(to), subject, message, null, null, attachment);
            }
        }

        private void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MailMessage mailMsg = (MailMessage)e.UserState;
            string subject = mailMsg.Subject;
            if (e.Cancelled) // 邮件被取消
            {
                Console.WriteLine(subject + " 被取消。");
            }
            if (e.Error != null)
            {
                Console.WriteLine("错误：" + e.Error.ToString());
            }
            else
            {
                Console.WriteLine("发送完成。");
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="host">邮箱服务器</param>
        /// <param name="port">服务器端口</param>
        /// <param name="from">发件人</param>
        /// <param name="pass">发件人密码</param>
        /// <param name="to">收件人</param>
        /// <param name="subject">主题</param>
        /// <param name="body">邮件内容</param>
        /// <returns>发送结果</returns>
        private Boolean Send(string host, int port, string from, string pass, string to, string subject, string body)
        {
            return Send(host, port, from, pass, to, subject, body, null, null, null);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="host">邮箱服务器</param>
        /// <param name="port">服务器端口</param>
        /// <param name="from">发件人</param>
        /// <param name="pass">发件人密码</param>
        /// <param name="to">收件人</param>
        /// <param name="subject">主题</param>
        /// <param name="body">邮件内容</param>
        /// <returns>发送结果</returns>
        public Boolean Send(string host, int port, string from, string pass, string to, string subject, string body, string cc, string bcc, string[] attachment)
        {
            MailMessage mmsg = new MailMessage();
            //邮件主题
            mmsg.Subject = subject;
            mmsg.BodyFormat = MailFormat.Html;
            //邮件正文
            mmsg.Body = body;
            //正文编码
            mmsg.BodyEncoding = Encoding.UTF8;
            //优先级
            mmsg.Priority = MailPriority.Normal;
            //发件者邮箱地址
            mmsg.From = from;//发件人地址;
            //收件人收箱地址
            string email_address = to;
            mmsg.To = email_address;
            if (cc != null)
            {
                mmsg.Cc = cc;
            }
            if (bcc != null)
            {
                mmsg.Bcc = bcc;
            }
            if (attachment != null && attachment.Length > 0)
            {
                foreach (var item in attachment)
                {
                    mmsg.Attachments.Add(item);
                }
            }
            mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
            //用户名
            mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", from);
            //密码
            mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", pass);
            //端口
            mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", port);
            if (port != 25)
            {
                //是否ssl
                mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");
            }
            //Smtp服务器
            System.Web.Mail.SmtpMail.SmtpServer = host;
            try
            {
                SmtpMail.Send(mmsg);

                return true;
            }
            catch (Exception ex)
            {
                var logger = loggerProvderFactory.CreateDefaultLogger();
                string message = JsonHelper.SerializeObject(mmsg);
                logger.Error(this, message, ex);
                return false;
            }
        }

        private string EmailConcat(string[] strs)
        {
            string str = string.Empty;
            if (strs != null && strs.Length > 0)
            {
                foreach (var s in strs)
                {
                    str += s + ";";
                }
            }
            return str;
        }
    }
}
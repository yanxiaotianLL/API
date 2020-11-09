using myselfFast.Fund.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mail;

namespace myselfFast.Fund.Core.Common
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Common
     *项目描述  ：
     *类名称    ：EmailHelperTwo
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : EmailHelperTwo
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-07-03 17:16:16
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class EmailHelperTwo
    {

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
        public static Boolean SendMailTestTwo(string host,int port,string from,string pass,string to,string subject,string body)
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
            mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
            //用户名                               
            mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", from);
            //密码                        
            mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", pass);
            //端口 
            mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", port);
            //是否ssl
            mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");
            //Smtp服务器
            System.Web.Mail.SmtpMail.SmtpServer = host;
            try
            {
                SmtpMail.Send(mmsg);
                return true;
            }
            catch{
                return false;

            }

        }
        
    }
}

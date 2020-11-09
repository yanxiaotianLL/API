using myselfFast.Fund.Core.Common;
using myselfFast.Component.Email;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mail;

namespace myselfFast.Fund.Core.Test.Compoent
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Test.Compoent
     *项目描述  ：
     *类名称    ：EmailTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : EmailTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-02-09 18:43:19
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public  class EmailTest
    {
        [TestMethod]
        public void TestEmailBySSL()
        {

           
            EmailServer email = new EmailServer {
                EmailFromAddress = "website@myselfweekly.com.cn",
                EmailFromPassword = "FpgNPQqNkd9Sw6FMgK3qEy9I6boP30mZE/3P7vSq6aM=",
                EmailHostIP = "192.168.0.37",
                EmailHostPort = "465"
                
            };
            GlobalConfiguration.Configuration.EmailServer = email;
            //EmailService emialServcieTest = new EmailService();
            EmailServiceV2 emailServer = new EmailServiceV2(null);
            emailServer.SendEmail("liu.yong@myself.com.cn", "test", "test");
            //EmailService.SendMailTestTwo(email.EmailFromAddress, email.EmailFromPassword, "titel", "sdfdsfs", "779454682@qq.com");
            //emialServcieTest.SendEmailTest(email, "779454682@qq.com", "sslTest", "sslTest");

        }
          [TestMethod]
        public void TestEamil()
        {

                String pass =  CryptographyHelper.Encrypt("myself2667@^^&", "sdfds#*&Rkd");
                MailMessage mmsg = new MailMessage();
                //邮件主题
                mmsg.Subject = "记忆2030机构入驻审核情况通知";
                mmsg.BodyFormat = MailFormat.Html;
                //邮件正文 
                mmsg.Body = "邮件正文";
                //正文编码
                mmsg.BodyEncoding = Encoding.UTF8;
                //优先级
                mmsg.Priority = MailPriority.Normal;
                //发件者邮箱地址
                mmsg.From = "flservice@myself.com.cn";//发件人地址;
                //收件人收箱地址
                string email_address = "liu .yong@myself.com.cn";
                mmsg.To = email_address;
                mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
                //用户名                               
                mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "flservice@myself.com.cn");
                //密码                        
                mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "myself2667@^^&");
                //端口 
                mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", "465");
                //是否ssl
                mmsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");
                //Smtp服务器
                System.Web.Mail.SmtpMail.SmtpServer = "mail.myself.com.cn";
                SmtpMail.Send(mmsg);


               
        }
    }
}

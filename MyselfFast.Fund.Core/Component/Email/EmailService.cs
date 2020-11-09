using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.Email
{
    public class EmailService : IEmail
    {      

        

        public void SendEmail(string to, string subject, string message)
        {
            MailMessage mm = new MailMessage(GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, to);
            mm.Subject = subject;
            mm.IsBodyHtml = true;
            mm.Body = message;
            Send(mm);
        }

        public void SendEmail(string to, string cc, string bcc, string subject, string message)
        {
            MailMessage mm = new MailMessage(GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, to);
            mm.CC.Add(cc);
            mm.Bcc.Add(bcc);
            mm.Subject = subject;
            mm.Body = message;
            mm.IsBodyHtml = true;
            Send(mm);
        }

        public void SendEmail(string[] to, string[] cc, string[] bcc, string subject, string message)
        {
            MailMessage mm = new MailMessage();
            foreach (var t in to)
            {
                mm.To.Add(t);
            }

            foreach (var c in cc)
            {
                mm.CC.Add(c);
            }

            foreach (var b in bcc)
            {
                mm.Bcc.Add(b);
            }

            mm.From = new MailAddress(GlobalConfiguration.Configuration.EmailServer.EmailFromAddress);
            mm.Subject = subject;
            mm.Body = message;
            mm.IsBodyHtml = true;
            Send(mm);
        }

        public void SendIndiviualEmailPerRecipient(string[] to, string subject, string message)
        {
            foreach (var t in to)
            {
                MailMessage mm = new MailMessage(GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, t);
                mm.Subject = subject;
                mm.Body = message;
                mm.IsBodyHtml = true;
                Send(mm);
            }
        }

        public void SendEmail(string to, string subject, string message, string[] attachment)
        {
            MailMessage mm = new MailMessage(GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, to);
            mm.Subject = subject;
            mm.Body = message;
            mm.IsBodyHtml = true;
            AttachMentCreate(mm, attachment);
           
            Send(mm);
        }

        public void SendEmail(string to, string cc, string bcc, string subject, string message, string[] attachment)
        {
            MailMessage mm = new MailMessage(GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, to);
            mm.CC.Add(cc);
            mm.Bcc.Add(bcc);
            mm.Subject = subject;
            mm.Body = message;
            mm.IsBodyHtml = true;
            AttachMentCreate(mm, attachment);
            Send(mm);
        }

        public void SendEmail(string[] to, string[] cc, string[] bcc, string subject, string message, string[] attachment)
        {
            MailMessage mm = new MailMessage();
            foreach (var t in to)
            {
                mm.To.Add(t);
            }

            foreach (var c in cc)
            {
                mm.CC.Add(c);
            }

            foreach (var b in bcc)
            {
                mm.Bcc.Add(b);
            }

            mm.From = new MailAddress(GlobalConfiguration.Configuration.EmailServer.EmailFromAddress);
            mm.Subject = subject;
            mm.Body = message;
            mm.IsBodyHtml = true;
            AttachMentCreate(mm, attachment);
            Send(mm);
        }

        public void SendIndiviualEmailPerRecipient(string[] to, string subject, string message, string[] attachment)
        {
            foreach (var t in to)
            {
                MailMessage mm = new MailMessage(GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, t);
                mm.Subject = subject;
                mm.Body = message;
                mm.IsBodyHtml = true;
                AttachMentCreate(mm, attachment);
                Send(mm);
            }
        }
        private void AttachMentCreate(MailMessage mm, string[] attachment)
        {
            if (attachment.Length > 0)
            {
                foreach (string file in attachment)
                {
                    mm.Attachments.Add(new Attachment(file));
                }
            }
        }
        private bool Send(MailMessage message)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = GlobalConfiguration.Configuration.EmailServer.EmailHostIP;
            smtp.Port = Convert.ToInt32(GlobalConfiguration.Configuration.EmailServer.EmailHostPort);
            smtp.Credentials = new NetworkCredential(GlobalConfiguration.Configuration.EmailServer.EmailFromAddress, GlobalConfiguration.Configuration.EmailServer.EmailFromPassword);
            if (smtp.Port != 25)
            {
                smtp.EnableSsl = true;
                smtp.SendCompleted += smtp_SendCompleted;
            }
            try
            {
                smtp.Send(message);
            }
            catch (SmtpException ex)
            {
                throw ex;
            }
            return true;
        }

        void smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
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
        

        private bool SendTest(EmailServer emailServer,MailMessage message)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = emailServer.EmailHostIP;
            
            smtp.Port = Convert.ToInt32(emailServer.EmailHostPort);
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new NetworkCredential(emailServer.EmailFromAddress, emailServer.EmailFromPassword);

            
           
            if (smtp.Port != 25)
            {
                smtp.EnableSsl = true;
                smtp.SendCompleted += smtp_SendCompleted;
                smtp.UseDefaultCredentials = true;
            }
            try
            {
                smtp.Send(message);
            }
            catch (SmtpException ex)
            {
                throw ex;
            }
            return true;
        }

        public void SendEmailTest(EmailServer emailServer, string to, string subject, string message)
        {
            MailMessage mm = new MailMessage(emailServer.EmailFromAddress, to);
            mm.Subject = subject;
            mm.IsBodyHtml = true;
            mm.Body = message;
            SendTest(emailServer,mm);
        }

        
            
    }
}

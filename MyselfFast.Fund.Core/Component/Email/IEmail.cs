using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.Email
{
    public interface IEmail
    {
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="to">收件人</param>
        /// <param name="subject">主题</param>
        /// <param name="message">邮件内容</param>
        void SendEmail(string to, string subject, string message);
        /// <summary>
        ///  发送邮件
        /// </summary>
        /// <param name="to">收件人</param>
        /// <param name="cc">抄送邮箱列表</param>
        /// <param name="bcc"></param>
        /// <param name="subject">主题</param>
        /// <param name="message">邮件内容</param>
        void SendEmail(string to, string cc, string bcc, string subject, string message);
        /// <summary>
        /// 群发
        /// </summary>
        /// <param name="to"></param>
        /// <param name="cc">抄送</param>
        /// <param name="bcc">密件抄送地址列表</param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        void SendEmail(string[] to, string[] cc, string[] bcc, string subject, string message);
        /// <summary>
        /// 群发
        /// </summary>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        void SendIndiviualEmailPerRecipient(string[] to, string subject, string message);
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="to">收件人</param>
        /// <param name="subject">主题</param>
        /// <param name="message">邮件内容</param>
        void SendEmail(string to, string subject, string message, string[] attachment);
        /// <summary
        ///  发送邮件
        /// </summary>
        /// <param name="to">收件人</param>
        /// <param name="cc">抄送邮箱列表</param>
        /// <param name="bcc"></param>
        /// <param name="subject">主题</param>
        /// <param name="message">邮件内容</param>
        void SendEmail(string to, string cc, string bcc, string subject, string message, string[] attachment);
        /// <summary>
        /// 群发
        /// </summary>
        /// <param name="to"></param>
        /// <param name="cc">抄送</param>
        /// <param name="bcc">密件抄送地址列表</param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        void SendEmail(string[] to, string[] cc, string[] bcc, string subject, string message, string[] attachment);
        /// <summary>
        /// 群发
        /// </summary>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        void SendIndiviualEmailPerRecipient(string[] to, string subject, string message, string[] attachment);

    }
}

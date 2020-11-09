using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace myselfFast.Fund.Core.Common
{
    public class MailHelper
    {
        public static void SendMail()
        {
            Outlook.Application olApp = new Outlook.Application();
            Outlook.MailItem mailItem = (Outlook.MailItem)olApp.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.To = "abc@163.com";
            mailItem.Subject = DateTime.Now.ToString("yyyyMMdd") + "_报表";
            mailItem.BodyFormat = Outlook.OlBodyFormat.olFormatHTML;

            string content = "附件为" + DateTime.Now.ToString("yyyyMMdd") + " 数据，请查阅，谢谢！";
            content = "各收件人，<br/> <br/>请重点关注以下内容：<br/> <br/>" + content + "<br/> <br/><br/><br/>此邮件为系统自动邮件通知，请不要直接进行回复！谢谢。";
            content = content + "<br/>\r\n                                    <br/>Best Regards!\r\n                                    <br/>\r\n                                    <br/>          \r\n                                    <br/>==============================================\r\n                               \r\n                                    <br/>\r\n                                    <br/>\r\n                \r\n             ===============================================";


            mailItem.HTMLBody = content;
            mailItem.Attachments.Add(@"c:\test.rar");
            ((Outlook._MailItem)mailItem).Send();
            mailItem = null;
            olApp = null;
        }
    }



}

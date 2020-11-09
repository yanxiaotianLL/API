using myselfFast.Fund.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 

namespace myselfFast.Component.MsgMobile
{
    /**********************************************************************************
	 *项目名称	：FS.ServiceHost.SendMsg
	 *项目描述  ：
	 *类名称    ：Email
	 *版本号    ：v1.0.0
	 *机器名称  ：LIUYONG-PC
	 *项目名称  : Email
	 *CLR版本   : 4.0.30319.42000
	 *作者      ：liu.yong
	 *创建时间  : 2017/1/11 23:36:10
	 *------------------------------------变更记录--------------------------------------
	 *变更描述  :
	 *变更作者  :
	 *变更时间  :
	***********************************************************************************/

    public class Email:IEmail
    {
        public void SendEmailHandler(string msg, string phone)
        {
            myselfFast.Component.Email.IEmail email = EngineContext.Current.Resolve<myselfFast.Component.Email.IEmail>();
            email.SendEmail("zhu.zhi.peng@myself.com.cn", msg, string.Format("有短信内容发送失败,需要处理!, 时间: {0} ,手机号:{1},用户发送短信失败,已记录到数据库,需处理!</br>{2}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), phone, msg));
        }
    }
}
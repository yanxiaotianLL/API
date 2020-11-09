using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myselfFast.Component.MsgMobile
{
    /**********************************************************************************
	 *项目名称	：FS.ServiceHost.SendMsg
	 *项目描述  ：
	 *类名称    ：SendMsgEmailFactory
	 *版本号    ：v1.0.0
	 *机器名称  ：LIUYONG-PC
	 *项目名称  : SendMsgEmailFactory
	 *CLR版本   : 4.0.30319.42000
	 *作者      ：liu.yong
	 *创建时间  : 2017/1/11 23:35:35
	 *------------------------------------变更记录--------------------------------------
	 *变更描述  :
	 *变更作者  :
	 *变更时间  :
	***********************************************************************************/

    public class SendMsgEmailFactory:ISendMsgEmailFactory
    {
        public Component.MsgMobile.IEmail CreateEmail()
        {
            return new Email();
        }
    }
}
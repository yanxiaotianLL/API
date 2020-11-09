using myselfFast.Component.Logging;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.MsgMobile
{
    /**********************************************************************************
     *项目名称	：FS.Component.MsgMobile
     *项目描述  ：
     *类名称    ：SendMsgHandler
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : SendMsgHandler
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/11 14:33:13
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public delegate void CreateMsgLogHandler(string phone, string LinkId, string content, string err);

    public delegate void SendEmailHandler(string msg, string phone);
    /// <summary>
    /// 短信发送处理类
    /// </summary>
    [Obsolete("短信供应商更换，请不要再使用此方法进行短息发送。，请使用FS.Component.MsgMobile.qxt.SendMsgHandler")]
    public class SendMsgHandler : ISendMsgHandler
    {
        private event CreateMsgLogHandler CreateMsgLogEvent;

        private event SendEmailHandler SendEmailHandlerEvent;
        private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;
        private IRepository<T_Helo_MsgLog> _Entity;


        public SendMsgHandler(IRepository<T_Helo_MsgLog> Entity, ILoggerProviderFactory iLoggerProviderFactory)
        {
            this._Entity = Entity;
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
            this.CreateMsgLogEvent += GlobalConfiguration.SendMsgLogFactory.CreaterLog(_Entity,  iLoggerProviderFactory).CreateMsgLog;
            this.SendEmailHandlerEvent += GlobalConfiguration.SendMsgEmailFactory.CreateEmail().SendEmailHandler;
        }
       

        public bool SendMsg(string phone, string content)
        {
           return  MsgMobile.SendMsg(phone, content, CreateMsgLogEvent, SendEmailHandlerEvent);
        }

        public bool SendMsg(string phone, string content, ref string msg)
        {
            return MsgMobile.SendMsg(phone, content, CreateMsgLogEvent, SendEmailHandlerEvent, ref msg);
        }

        public bool SendMsg89(string phone, string content)
        {
            return MsgMobile.SendMsg89(phone, content, CreateMsgLogEvent, SendEmailHandlerEvent);
        }

        public bool SendMsg89(string phone, string content, ref string msg)
        {
            return MsgMobile.SendMsg89(phone, content, CreateMsgLogEvent, SendEmailHandlerEvent, ref msg);
        }



        public event CreateMsgLogHandler CreateMsgLogEventAdd;

        public event SendEmailHandler SendEmailHandlerAdd;


        public bool SendMsg(string[] phones, string content)
        {
            throw new NotImplementedException();
        }

        public bool SendMsg(string[] phones, string content, ref string msg)
        {
            throw new NotImplementedException();
        }
    }
}

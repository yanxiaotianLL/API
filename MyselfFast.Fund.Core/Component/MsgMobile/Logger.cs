using myselfFast.Component.Logging;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace myselfFast.Component.MsgMobile
{
    /**********************************************************************************
	 *项目名称	：FS.ServiceHost.SendMsg
	 *项目描述  ：
	 *类名称    ：Logger
	 *版本号    ：v1.0.0
	 *机器名称  ：LIUYONG-PC
	 *项目名称  : Logger
	 *CLR版本   : 4.0.30319.42000
	 *作者      ：liu.yong
	 *创建时间  : 2017/1/11 23:34:54
	 *------------------------------------变更记录--------------------------------------
	 *变更描述  :
	 *变更作者  :
	 *变更时间  :
	***********************************************************************************/

    public class Logger : ILog
    {
        
        private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;
        private IRepository<T_Helo_MsgLog> _Entity;


        public Logger(IRepository<T_Helo_MsgLog> Entity, ILoggerProviderFactory iLoggerProviderFactory)
             
        {
            this._Entity = Entity;
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
        }
        public void CreateMsgLog(string phone, string LinkId,string content, string err)
        {
            if (content.IndexOf("验证码") > 0 || content.IndexOf("您的密码已经更新") > 0)
            {
                return;
            }
            if (phone == null || phone.Equals(""))
            {
                return;
            }

            try
            {
                T_Helo_MsgLog msgLog = new T_Helo_MsgLog();
                if (string.IsNullOrEmpty(err))
                {
                    msgLog.isNeedTry = 0;
                    msgLog.MobileNo = phone;
                    msgLog.MsgContent = content;
                    msgLog.Sendtime = DateTime.Now;
                    msgLog.Status = 1; //表示是发送成功的数据
                    msgLog.TrySendtime = DateTime.Parse("1900-01-01");
                    msgLog.TryTimes = 0;
                    msgLog.IsDel = 0;
                    msgLog.errorContent = "";
                    msgLog.ElectType = "ALL";
                    msgLog.ElectSource = "NewHeloHrAdmin";
                    msgLog.IsNowSend = 1;
                    msgLog.CreateTime = DateTime.Now;
                    msgLog.LinkId = LinkId;
                }
                else
                {
                    msgLog.isNeedTry = 1;
                    msgLog.MobileNo = phone;
                    msgLog.MsgContent = content;
                    msgLog.Sendtime = DateTime.Now;
                    msgLog.Status = 0; //表示是发送成功的数据
                    msgLog.TrySendtime = DateTime.Parse("1900-01-01");
                    msgLog.TryTimes = 0;
                    msgLog.IsDel = 0;
                    msgLog.errorContent = "";
                    msgLog.ElectType = "ALL";
                    msgLog.ElectSource = "NewHeloHrAdmin";
                    msgLog.IsNowSend = 1;
                    msgLog.CreateTime = DateTime.Now;
                    msgLog.LinkId = LinkId;
                }
                _Entity.Insert(msgLog);

            }
            catch (Exception ex)
            {
                _logger.Info(this.GetType(), "发送短信日志记录异常" + ex);
            }


        }
    }
}
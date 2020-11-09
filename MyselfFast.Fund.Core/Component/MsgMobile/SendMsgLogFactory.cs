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
	 *类名称    ：SendMsgLogFactory
	 *版本号    ：v1.0.0
	 *机器名称  ：LIUYONG-PC
	 *项目名称  : SendMsgLogFactory
	 *CLR版本   : 4.0.30319.42000
	 *作者      ：liu.yong
	 *创建时间  : 2017/1/11 23:34:12
	 *------------------------------------变更记录--------------------------------------
	 *变更描述  :
	 *变更作者  :
	 *变更时间  :
	***********************************************************************************/

    public class SendMsgLogFactory:ISendMsgLogFactory
    {
        private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;
        private IRepository<T_Helo_MsgLog> _Entity;
        public ILog CreaterLog(IRepository<T_Helo_MsgLog> Entity, ILoggerProviderFactory iLoggerProviderFactory)
        {
            this._Entity = Entity;
            this.iLoggerProviderFactory = iLoggerProviderFactory;
           
            return new Logger(_Entity,iLoggerProviderFactory);
        }
    }
}
using DependencyRegister.NewSytemSDKConfig;
using myselfFast.Fund.Core.Infrastructure;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core
     *项目描述  ：
     *类名称    ：StartupTask
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : StartupTask
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-23 16:54:18
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class StartupTask : IStartupTask
    {
        public void Execute()
        {
            #region 日志组建初始化
            //LogInit(); 
            #endregion            

            #region 新系统SDK配置
            NewSytemSDKConfigInit.SDKConfigInit();
            #endregion

            #region 邮件服务配置
            myselfFast.Component.Email.GlobalConfiguration.ConfigInitialization();
            #endregion

            #region 短信发送配置
            myselfFast.Component.MsgMobile.GlobalConfiguration.RegisterSendMsgLogFactory(new myselfFast.Component.MsgMobile.SendMsgLogFactory(),
                   new myselfFast.Component.MsgMobile.SendMsgEmailFactory());
            #endregion

            #region 文件服务器数据初始化
            //myselfFast.Component.File.GlobalConfiguration.ConfigInitialization(); 
            #endregion

            #region sql日志记录配置
            //DbCommandInterceptorRegister.Register();
            #endregion

            //#region 初始化IP地址和域名过滤功能
            //FS.Core.API.MessageHandler.IpAndDomanFilter.GlobalConfiguration.ConfigInitialization(); 
            //#endregion
            #region app服务项目全局配置项目
            myselfFast.Fund.Core.Configuration.FSGlobalConfiguration.ConfigInitialization();
            #endregion
        }

        public int Order
        {
            get { return 0; }
        }
        
    }
}

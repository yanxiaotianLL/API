using DependencyRegister.NewSytemSDKConfig;
using FescoFast.Collect.Core.Infrastructure;
using FescoFast.Component.MsgMobile;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FescoFast.Collect.Core.Configuration
{
    /**********************************************************************************
     *项目名称	：FescoFast.Collect.Core.Configuration
     *项目描述  ：
     *类名称    ：ConfigurationStartupTask
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ConfigurationStartupTask
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-14 16:18:59
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class ConfigurationStartupTask : IStartupTask
    {
        public void Execute()
        {
            //#region 新系统SDK配置
            NewSytemSDKConfigInit.SDKConfigInit();
            //#endregion

            //#region 邮件服务配置
            //FS.Component.Email.GlobalConfiguration.ConfigInitialization();
            //#endregion

            #region 短信发送配置
            //MsgMobile.GlobalConfiguration.RegisterSendMsgLogFactory(new FS.HELO.Admin.Config.SendMsg.SendMsgLogFactory(),
            //       new FS.HELO.Admin.Config.SendMsg.SendMsgEmailFactory());
            #endregion

            //#region 文件服务器数据初始化
            ////FS.Component.File.GlobalConfiguration.ConfigInitialization(); 
            //#endregion

            #region 系统日志配置
            ////日志配置初始化
            //Log4Itialize();
            #endregion
            #region sql日志记录配置
            //DbCommandInterceptorRegister.Register();
            #endregion

            //#region 初始化IP地址和域名过滤功能
            //FS.Core.API.MessageHandler.IpAndDomanFilter.GlobalConfiguration.ConfigInitialization(); 
            //#endregion
            #region app服务项目全局配置项目
            FescoFast.Collect.Core.Configuration.FSGlobalConfiguration.ConfigInitialization();
            #endregion

        }

        public int Order
        {
            get { return 10; }
        }

        /// <summary>
        /// 日志配置初始化
        /// </summary>
        private void Log4Itialize()
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Config\Log4Net.config");
            if (!System.IO.File.Exists(logFilePath))
            {
                logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\Log4Net.config");
            }

            XmlConfigurator.ConfigureAndWatch(new FileInfo(logFilePath));
        }
    }
}

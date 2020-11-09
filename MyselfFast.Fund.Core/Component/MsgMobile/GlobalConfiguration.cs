using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Common;
using myselfFast.Component.Email;
using myselfFast.Component.MsgMobile.qxt;

namespace myselfFast.Component.MsgMobile
{
    /**********************************************************************************
     *项目名称	：FS.Component.MsgMobile
     *项目描述  ：
     *类名称    ：GlobalConfiguration
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : GlobalConfiguration
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/11 23:13:38
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/

    /// <summary>
    /// 短信全局注册
    /// </summary>
    public class GlobalConfiguration
    {
        public static ISendMsgLogFactory SendMsgLogFactory { get; set; }
        public static ISendMsgEmailFactory SendMsgEmailFactory { get; set; }
        public static void  RegisterSendMsgLogFactory(ISendMsgLogFactory logFactory,ISendMsgEmailFactory emailFactory)
        {
            SendMsgLogFactory = logFactory;
            SendMsgEmailFactory = emailFactory;
        }



        /// <summary>
        /// 配置文件地址
        /// </summary>
        private static string _cofigFilePath;

        private static FileSystemWatcher _fileSystemWatcher;

        private const string FILEPATH = "MsgMobileSDKPATH";
        private const string FILENAME = "MsgMobileSDK.xml";
        static GlobalConfiguration()
        {
            //_cofigFilePath = System.Configuration.ConfigurationManager.AppSettings[FILEPATH];
            if (!System.AppDomain.CurrentDomain.BaseDirectory.EndsWith("\\"))
            {
                _cofigFilePath = System.AppDomain.CurrentDomain.BaseDirectory + @"\App_Data\Config\";
            }
            else
            {
                _cofigFilePath = System.AppDomain.CurrentDomain.BaseDirectory + @"App_Data\Config\";
            }
            _fileSystemWatcher = new FileSystemWatcher(_cofigFilePath);
            _fileSystemWatcher.WaitForChanged(WatcherChangeTypes.Changed, 10000);
            _fileSystemWatcher.Changed += _fileSystemWatcher_Changed;
            _fileSystemWatcher.EnableRaisingEvents = true;
            //测试初始化数据
            ConfigInitialization();
        }

        static void _fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            //文件内容变更，重新加载
            ConfigInitialization();
        }

        private static QxtConfigration qxtConfigration;
        /// <summary>
        /// 全局配置项
        /// </summary>
        public static QxtConfigration Configuration
        {
            get
            {
                if (qxtConfigration == null)
                {
                    qxtConfigration = new QxtConfigration();
                }
                return qxtConfigration;
            }
            private set { qxtConfigration = value; }
        }
        /// <summary>
        /// 配置数据初始化
        /// </summary>
        public static void ConfigInitialization()
        {
            string filePath = _cofigFilePath + FILENAME;
            if (!System.IO.File.Exists(filePath))
            {
                throw new FileNotFoundException("短信服务组件配置文件不存在！");
            }

            Configuration = (QxtConfigration)SerializeHelper.Load(typeof(QxtConfigration), filePath);
        }

    }

}

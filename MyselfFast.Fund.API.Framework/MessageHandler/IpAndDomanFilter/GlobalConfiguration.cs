using myselfFast.Fund.Core.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace myselfFast.Fund.API.Framework.MessageHandler.IpAndDomanFilter
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.MessageHandler.IpAndDomanFilter
     *项目描述  ：
     *类名称    ：GlobalConfiguration
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : GlobalConfiguration
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/15 0:14:21
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static class GlobalConfiguration
    {
        /// <summary>
        /// 配置文件地址
        /// </summary>
        private static string _cofigFilePath;

        private static FileSystemWatcher _fileSystemWatcher;

        private const string FILEPATH = "IPANDDOMAINFILTERPATH";
        private const string FILENAME = "IPANDDOMAINCOMPONENT.xml";
        static GlobalConfiguration()
        {
            //_cofigFilePath = System.Configuration.ConfigurationManager.AppSettings[FILEPATH];
            _cofigFilePath = System.AppDomain.CurrentDomain.BaseDirectory + @"App_Data\Config\";
            _fileSystemWatcher = new FileSystemWatcher(_cofigFilePath);
            _fileSystemWatcher.Changed += _fileSystemWatcher_Changed;
            //测试初始化数据
            ConfigInitialization();
        }

        static void _fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            //文件内容变更，重新加载
            ConfigInitialization();
        }

        private static IpAndDomainConfiguration ipAndDomainConfiguration;
        /// <summary>
        /// 全局配置项
        /// </summary>
        public static IpAndDomainConfiguration Configuration
        {
            get
            {
                if (ipAndDomainConfiguration == null)
                {
                    ipAndDomainConfiguration = new IpAndDomainConfiguration();
                }
                return ipAndDomainConfiguration;
            }
            private set { ipAndDomainConfiguration = value; }
        }
        /// <summary>
        /// 配置数据初始化
        /// </summary>
        public static void ConfigInitialization()
        {
            string filePath = _cofigFilePath + FILENAME;
            if (!System.IO.File.Exists(filePath))
            {
                throw new FileNotFoundException("IP和域名过滤组件配置文件不存在！");
            }

            Configuration = (IpAndDomainConfiguration)SerializeHelper.Load(typeof(IpAndDomainConfiguration), filePath);
        }

    }
}

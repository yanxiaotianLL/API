using myselfFast.Fund.Core.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDebugTool.Model;

namespace WebApiDebugTool.Configs
{
    public  class FSGlobalConfiguration
    {
        /// <summary>
        /// 配置文件地址
        /// </summary>
        private static string _cofigFilePath;

        private static FileSystemWatcher _fileSystemWatcher;

        private const string FILEPATH = "WebApiDebugTool";
        private const string FILENAME = "WebApiDebugTool.xml";
        static FSGlobalConfiguration()
        {
            //_cofigFilePath = System.Configuration.ConfigurationManager.AppSettings[FILEPATH];
            _cofigFilePath = System.AppDomain.CurrentDomain.BaseDirectory + @"Config\";
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

        private static WebApiToolConfigModel fsConfiguration;
        /// <summary>
        /// 全局配置项
        /// </summary>
        public static WebApiToolConfigModel Configuration
        {
            get
            {
                if (fsConfiguration == null)
                {
                    fsConfiguration = new WebApiToolConfigModel();
                }
                return fsConfiguration;
            }
            private set { fsConfiguration = value; }
        }
        /// <summary>
        /// 配置数据初始化
        /// </summary>
        public static void ConfigInitialization()
        {
            string filePath = _cofigFilePath + FILENAME;
            if (!System.IO.File.Exists(filePath))
            {
                throw new FileNotFoundException("FS项目全局配置文件不存在！");
            }

            Configuration = (WebApiToolConfigModel)SerializeHelper.Load(typeof(WebApiToolConfigModel), filePath);
        }

    }
}
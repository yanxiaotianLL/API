using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Common;

namespace myselfFast.Fund.Core.Configuration
{
    /**********************************************************************************
     *项目名称	：FS.Config
     *项目描述  ：
     *类名称    ：FSGlobalConfiguration
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : FSGlobalConfiguration
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/18 21:41:20
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
     public  class FSGlobalConfiguration
    {
    /// <summary>
        /// 配置文件地址
        /// </summary>
        private static string _cofigFilePath;

        private static FileSystemWatcher _fileSystemWatcher;

        private const string FILEPATH = "FSGlobalConfiguration";
        private const string FILENAME = "FSGlobalConfiguration.xml";
        static FSGlobalConfiguration()
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
            
            _fileSystemWatcher = new FileSystemWatcher(_cofigFilePath,"*.xml");
            
            _fileSystemWatcher.WaitForChanged(WatcherChangeTypes.Changed, 10000);
            _fileSystemWatcher.Changed += _fileSystemWatcher_Changed;
            _fileSystemWatcher.EnableRaisingEvents = true;
            //测试初始化数据
            //ConfigInitialization();
        }

        static void _fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            //文件内容变更，重新加载
            ConfigInitialization();
        }

        private static FSConfiguration fsConfiguration;
        /// <summary>
        /// 全局配置项
        /// </summary>
        public static FSConfiguration Configuration
        {
            get
            {
                if (fsConfiguration == null)
                {
                    fsConfiguration = new FSConfiguration();
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

            Configuration = (FSConfiguration)SerializeHelper.Load(typeof(FSConfiguration), filePath);
        }
      
    }
}

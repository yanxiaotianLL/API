using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Component.Logging;
using log4net.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://msdn.microsoft.com/zh-cn/library/microsoft.visualstudio.testtools.unittesting.classinitializeattribute(v=vs.80).aspx
namespace myselfFast.Fund.Core.Test.Compoent.Logging
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Test.Compoent.Logging
     *项目描述  ：
     *类名称    ：LoggerTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : LoggerTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-25 9:36:37
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 日志记录appender测试
    /// </summary>
    [TestClass]
    public  class LoggerTest
    {
        [TestInitialize]
        public void Init()
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Config\Log4Net.config");
            if (!System.IO.File.Exists(logFilePath))
            {
                logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\Log4Net.config");
            }

            XmlConfigurator.ConfigureAndWatch(new FileInfo(logFilePath));
        }
        /// <summary>
        /// 作为服务提供方的api访问记录
        /// </summary>
        [TestMethod]
        public void TestApiInputLogEntityLogInfo()
        {
            //log4net.ILog logger = log4net.LogManager.GetLogger("ApiInputLogEntityLogger");
            ILoggerProviderFactory loggerProviderFactory = new LoggerProviderFactory();
            var logger = loggerProviderFactory.CreateLogger(LoggerType.ApiInputLogEntity);
            myselfFast.Fund.Core.Component.Logging.ApiInputLogEntity logEntity = new Core.Component.Logging.ApiInputLogEntity()
            {
                AccountName = "AccountName",
                AccountType = "AccountType",
                Action = "index",
                Controller = "home",
                Expire = 100,
                HttpMethod = "POST",
                Ip = "127.0.0.1",
                OriginalString = "OriginalString",
                Region = "admin",
                RequestContent = "RequestContent",
                RequestTime = DateTime.Now,
                Sign = "RequestUri",
                ResponseContent = "ResponseContent"
            };

            for (int i = 0; i < 100; i++)
            {
                logger.Info(this,logEntity);
            }
        }
        /// <summary>
        /// 作为服务提供方的api访问记录
        /// </summary>
        [TestMethod]
        public void TestApiInputLogEntityLogError()
        {
            //log4net.ILog logger = log4net.LogManager.GetLogger("ApiInputLogEntityLogger");
            ILoggerProviderFactory loggerProviderFactory = new LoggerProviderFactory();
            var logger = loggerProviderFactory.CreateLogger(LoggerType.ApiInputLogEntity);
            myselfFast.Fund.Core.Component.Logging.ApiInputLogEntity logEntity = new Core.Component.Logging.ApiInputLogEntity()
            {
                AccountName = "AccountName",
                AccountType = "AccountType",
                Action = "index",
                Controller = "home",
                Expire = 100,
                HttpMethod = "POST",
                Ip = "127.0.0.1",
                OriginalString = "OriginalString",
                Region = "admin",
                RequestContent = "RequestContent",
                RequestTime = DateTime.Now,
                Sign = "RequestUri",
                ResponseContent = "ResponseContent"
            };
            try
            {
                int d = 0;
                int oo = 1 / d;

            }
            catch (Exception ex)
            {
                for (int i = 0; i < 10; i++)
                {
                    logger.Error(this,logEntity,ex);
                }
            }
           
        }
        /// <summary>
        /// 普通记录日志对象
        /// </summary>
        [TestMethod]
        public void TestLogEntityInfo()
        {
            //log4net.ILog logger = log4net.LogManager.GetLogger("LogEntityLogger");          
            ILoggerProviderFactory loggerProviderFactory = new LoggerProviderFactory();
            var logger = loggerProviderFactory.CreateLogger(LoggerType.LogEntity);

            myselfFast.Fund.Core.Component.Logging.LogEntity logEntity = new Core.Component.Logging.LogEntity();
            logEntity.Code = "1011";
            logEntity.Content = "订单编号不正确";
            logEntity.ModuleName = "订单中心";
            logEntity.SystemName = "myselfFast.Fund.Admin";
            logEntity.Name = "daxiaohuo";
            for (int i = 0; i < 100; i++)
            {
                logger.Info(this,logEntity);
            }
        }
        [TestMethod]
        public void TestLogEntityError()
        {
            //log4net.ILog logger = log4net.LogManager.GetLogger("LogEntityLogger");
            ILoggerProviderFactory loggerProviderFactory = new LoggerProviderFactory();
            var logger = loggerProviderFactory.CreateLogger(LoggerType.LogEntity);
            myselfFast.Fund.Core.Component.Logging.LogEntity logEntity = new Core.Component.Logging.LogEntity();
            logEntity.Code = "1011";
            logEntity.Content = "订单编号不正确";
            logEntity.ModuleName = "订单中心";
            logEntity.SystemName = "myselfFast.Fund.Admin";
            logEntity.Name = "daxiaohuo";
            try
            {
                int d = 0;
                int oo = 1 / d;

            }
            catch (Exception ex)
            {
                for (int i = 0; i < 10; i++)
                {
                    logger.Error(this,logEntity, ex);
                }
            }
        }
        [TestMethod]
        public void TestApiOutputLogEntityInfo()
        {
            //log4net.ILog logger = log4net.LogManager.GetLogger("ApiOutputLogEntityLogger");
            ILoggerProviderFactory loggerProviderFactory = new LoggerProviderFactory();
            var logger = loggerProviderFactory.CreateLogger(LoggerType.ApiOutputLogEntity);
            ApiOutputLogEntity logEntity = new ApiOutputLogEntity() {
                AccountName = "AccountName",
                AccountType = "AccountType",
                Expire = 300,
                HttpMethod = "GET",
                Method = "getEmpBasic",
                Module = "补医保",
                Region = "补医保",
                RequestContent = "RequestContent",
                RequestTime = DateTime.Now,
                RequestUri = "RequestUri",
                ResponseContent = "ResponseContent"
                
            };
            for (int i = 0; i < 100; i++)
            {
                logger.Info(this,logEntity);
            }
        }
        [TestMethod]
        public void TestApiOutputLogEntityError()
        {
            //log4net.ILog logger = log4net.LogManager.GetLogger("ApiOutputLogEntityLogger");
            ILoggerProviderFactory loggerProviderFactory = new LoggerProviderFactory();
            var logger = loggerProviderFactory.CreateLogger(LoggerType.ApiOutputLogEntity);
            ApiOutputLogEntity logEntity = new ApiOutputLogEntity()
            {
                AccountName = "AccountName",
                AccountType = "AccountType",
                Expire = 300,
                //HttpMethod = "GET",
                //Method = "getEmpBasic",
                //Module = "补医保",
                Region = "补医保",
                RequestContent = "RequestContent",
                RequestTime = DateTime.Now,
                RequestUri = "RequestUri",
                ResponseContent = "ResponseContent"

            };
            try
            {
                int d = 0;
                int oo = 1 / d;

            }
            catch (Exception ex)
            {
                for (int i = 0; i < 10; i++)
                {
                    logger.Error(this,logEntity, ex);
                }
            }
        }
    }
}

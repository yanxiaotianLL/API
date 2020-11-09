using FescoFast.Fund.Core.Domain.JiCai;
using FescoFast.Fund.Core.Infrastructure;
using FescoFast.Fund.Services.JiCai;
using FescoFast.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using log4net.Config;
using NewSystem.SDK.Interfaces;
using NewSystem.SDK.Entities.Request.FileService;
using FescoFast.Fund.Core.Common;
using FescoFast.Component.Logging;

namespace FescoFast.Fund.Services.Test.JiCai
{
    /**********************************************************************************
     *项目名称	：FescoFast.Fund.Services.Test.JiCai
     *项目描述  ：
     *类名称    ：JiCaiTaskServiceTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : JiCaiTaskServiceTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-02-06 15:37:49
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public  class JiCaiTaskServiceTest
    {
        private IJiCaiTaskService jiCaiTaskService;
        private IBaseService<T_JC_File> jiCaiFileService;
        IFileDownService fileDownService;
        [TestInitialize]
        public void Init()
        {
            LoggerProviderFactory.LogInit();
            EngineContext.Initialize(true);

            NewSystem.SDK.Config.GlobalConfiguration.Configuration.RegisterLoggerFactory(new FescoFast.Fund.Api.Infrastructure.NewSdk.SDKLoggerFactory());
            jiCaiTaskService = EngineContext.Current.Resolve<IJiCaiTaskService>();
            jiCaiFileService = EngineContext.Current.Resolve<IBaseService<T_JC_File>>();
            fileDownService = EngineContext.Current.Resolve<IFileDownService>();
            //string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Config\Log4Net.config");
            //if (!System.IO.File.Exists(logFilePath))
            //{
            //    logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\Log4Net.config");
            //}

            //XmlConfigurator.ConfigureAndWatch(new FileInfo(logFilePath));
        }
        [TestMethod]
        public void TestTaskInit()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
           
            T_JC_Task task = new T_JC_Task {
                Address = "上海市",
                Address_ID = "755699",
                Description = "上海市",
                TaskType = 1,
                CollectProduct = 0,
                CollectlType = "A",
                OrderID = "",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(23),
                IsDelete = false,
                CreateTime = DateTime.Now,
                WageAccuracy = 0,
                IsForceDefault = true,
                NeedCollectTable = false,
                UpdateTime = DateTime.Now,
                 ShiKaiRate = "",
                NotShiKaiRate = "7+7"


                //Address = "北京-B类-整数2",
                //Address_ID = "752254",
                //Description = "北京-B类-整数",
                //TaskType = 0,
                //CollectProduct = 0,
                //CollectlType = "B",
                //OrderID = "",
                //StartTime = DateTime.Now,
                //EndTime = DateTime.Now.AddDays(23),
                //IsDelete = false,
                //CreateTime = DateTime.Now,
                //WageAccuracy = 1,
                //IsForceDefault = true,
                //NeedCollectTable = false,
                //UpdateTime = DateTime.Now,
                //ShiKaiRate = "12+8,11+11,12+7",
                //NotShiKaiRate = "20+8,7+7,12+12,10+8,10+10,8+8,10+7"




                //Address = "长春市",
                //Address_ID = "2110329",
                //Description = "长春市",
                //TaskType = 0,
                //CollectProduct = 0,
                //CollectlType = "A",
                //OrderID = "",
                //StartTime = DateTime.Now,
                //EndTime = DateTime.Now.AddDays(23),
                //IsDelete = false,
                //CreateTime = DateTime.Now,
                //WageAccuracy = 0,
                //IsForceDefault = false,
                //NeedCollectTable = true,
                //UpdateTime = DateTime.Now,
                //ShiKaiRate = "12+8,11+11,12+7",
                //NotShiKaiRate = "20+8,7+7,12+12,10+8,10+10,8+8,10+7"
                
            };
            //添加任务
            jiCaiTaskService.AddEntity(task);
            //添加文件
            var taskFiles = new List<T_JC_File>() { 
                 new T_JC_File()
                {
                    //FileID = "生数测试2018-12-26【广州】",//不包括后最
                    //FileName = "生数测试2018-12-26【广州】.xlsx",//包括后缀名称
                    //CreateTime = DateTime.Now,
                    //FileType = "0",//0  数据文件，1 政策文件
                    //IsDelete = false,
                    //TaskId = task.Id                

                    FileID = "上海数据",//不包括后最
                    FileName = "上海数据.xlsx",//包括后缀名称
                    CreateTime = DateTime.Now,
                    FileType = "0",//0  数据文件，1 政策文件
                    IsDelete = false,
                    TaskId = task.Id     

                }
                //, new T_JC_File()
                //{
                //    //添加政策文件
                //    FileID = "政策文件测试版",//不包括后最
                //    FileName = "政策文件测试版.zip",//包括后缀名称
                //    CreateTime = DateTime.Now,
                //    FileType = "1",//0  数据文件，1 政策文件
                //    IsDelete = false,
                //    TaskId = task.Id     

                //}
            };
            jiCaiFileService.AddEntitys(taskFiles);
            //数据入库操作
            jiCaiTaskService.TaskInitForTest();
            sw.Stop();
            long time = sw.ElapsedMilliseconds;
            
        }
        [TestMethod]
        public void TestGetPageList()
        {
            //var task = jiCaiTaskService.GetPageList(1, 10, "ywy1052",null, null,null,null);
            //Assert.IsNotNull(task);
        }
        [TestMethod]
         public void TestGetAddressListBySendLoginName()
         {
            //var addressLists = jiCaiTaskService.GetAddressListBySendLoginName("ywy1052",null);
            //Assert.IsNotNull(addressLists);
         }
         [TestMethod]
        public void TestDownFileByFileID()
        {
            string filePath = "";
            Stream stream = fileDownService.GetErRecordMatById(new GetErRecordDataByIdRequestModel()
            {
                fileId = "6E819BF7FBD0584AE053DF4B000A310B"
            });
            filePath = AppDomain.CurrentDomain.BaseDirectory+ "/566.xlsx";


            long length = stream.Length;
            Stream fileDes = new FileStream(filePath, FileMode.CreateNew);
            NewSystem.SDK.Common.StreamHelper.StreamCopy(stream, fileDes);
             //string path = AppDomain.CurrentDomain.BaseDirectory +"\\"+ DateTime.Now.Year+".xslx";
             //using(Stream stream = new FileStream(path,FileMode.Create)){
             //    jiCaiTaskService.DownFileByFileID(stream, 103);
             //}
        }
        [TestMethod]
         public void TestSendEmailToAdmin()
         {
            string str =   CryptographyHelper.Encrypt("fesco2667@^^&", "sdfds#*&Rkd");


             jiCaiTaskService.SendEmailToAdmin(new T_JC_Task { Id = 76, StartTime = DateTime.Now.AddMonths(-1),EndTime = DateTime.Now.AddMonths(2),Address = "北京市" });
         }
         [TestMethod]
        public void TestGetTaskDataById()
        {
           jiCaiTaskService.TaskDataCallBack();
             
        }
    }
}

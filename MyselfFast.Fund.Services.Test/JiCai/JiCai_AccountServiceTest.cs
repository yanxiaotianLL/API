using FescoFast.Fund.Core.Component.Office.xls;
using FescoFast.Fund.Core.Infrastructure;
using FescoFast.Fund.Services.JiCai;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FescoFast.Fund.Services.Test.JiCai
{
    /**********************************************************************************
     *项目名称	：FescoFast.Fund.Services.Test.JiCai
     *项目描述  ：
     *类名称    ：JiCai_AccountServiceTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : JiCai_AccountServiceTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-03-14 0:18:19
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public class JiCai_AccountServiceTest
    {
        IJiCai_AccountService jiCaiAccountService = null;
        private IDataItemService dataItemService;
        private IT_JC_TaskUnitService taskUnitService;
        private IJiCaiTaskService taskService;
        [TestInitialize]
        public void Init()
        {
            EngineContext.Initialize(true);
            dataItemService = EngineContext.Current.Resolve<IDataItemService>();
            taskUnitService = EngineContext.Current.Resolve<IT_JC_TaskUnitService>();
            taskService = EngineContext.Current.Resolve<IJiCaiTaskService>();
            jiCaiAccountService = EngineContext.Current.Resolve<IJiCai_AccountService>();
        }
        [TestMethod]
        public void TestGetPageList()
        {
            //var list = jiCaiAccountService.GetPageList(1, 20, "", "", "", "", "", "", "", "", "", "", "");
        }
        [TestMethod]
        public void TestGetAddress()
        {
            string msg = string.Empty;
            //var address = jiCaiAccountService.GetAddress("testlogin123", ref msg);
        }
        [TestMethod]
        public void TestExport() {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "/exprt.xlsx";
            using(Stream stream = new FileStream(filePath,FileMode.CreateNew)){
                //jiCaiAccountService.Export(stream, "testlogin");
            }
        }
        [TestMethod]
        public void TestGetPageListByTask()
        {
            //var accounts = jiCaiAccountService.GetPageListByTask(1, 50, "", "", "", "", "", "", "", "", "", "", null, 59);
            //Assert.IsNotNull(accounts);
        }     
        
       
         [TestMethod]
         public void TestExportToXlsx()
         {
             int taskId = 167;
             string path = AppDomain.CurrentDomain.BaseDirectory +"\\"+ Guid.NewGuid().ToString()+".xlsx";
             Stream stream = new FileStream(path, FileMode.Create);
             taskUnitService.HR_ExportJiCaiTable(stream, 43467, taskId);
         }
         [TestMethod]
         public void TestIxportToXlsx()
         {
             int taskId = 167;
             string path = AppDomain.CurrentDomain.BaseDirectory + "\\b45c6050-14bd-4f76-928c-51589e34d353.xlsx";
             Stream stream = new FileStream(path, FileMode.Open);
             dataItemService.HR_Import(stream, "中文", taskId, taskId);
         }
    }
}

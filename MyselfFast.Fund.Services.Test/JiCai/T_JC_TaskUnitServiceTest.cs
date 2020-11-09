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
     *类名称    ：T_JC_TaskUnitServiceTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : T_JC_TaskUnitServiceTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-03-06 12:04:52
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public  class T_JC_TaskUnitServiceTest
    {
        private IT_JC_TaskUnitService jiCaiTaskUnitService;

        [TestInitialize]
        public void Init()
        {
            EngineContext.Initialize(true);
            jiCaiTaskUnitService = EngineContext.Current.Resolve<IT_JC_TaskUnitService>();
        }
        [TestMethod]
        public void TestGetPageList()
        {
            string sendLoginName = "ywy763";
            int taskId = 51;
            //var unitList = jiCaiTaskUnitService.GetPageList(1, 20, "", "", "", "", "", "", "", "", "", sendLoginName, "", "",taskId);        
          
        }
       
        [TestMethod]
        public void TestExportToExcel()
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "/TestExportToExcel.xlsx";
            using(Stream stream = new  FileStream(path,FileMode.OpenOrCreate)){
                string sendLoginName = "ywy763";
                int taskId = 51;
                //jiCaiTaskUnitService.Export(stream, "", "", "", "", "", "", "", "", "", sendLoginName, "", "", taskId);
            }
            
        }
        [TestMethod]
        public void TestExportJiCaiTable()
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "/TestExportJiCaiTable.xlsx";
            using (Stream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                string sendLoginName = "ywy763";
                int taskId = 51;
                jiCaiTaskUnitService.ExportJiCaiTable(stream, null, sendLoginName, taskId, null,"");
            }
        }
    }
}

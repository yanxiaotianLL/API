using myselfFast.Fund.Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Test.Coomon
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Test.Coomon
     *项目描述  ：
     *类名称    ：CSVHelperTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : CSVHelperTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-03-03 18:25:38
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public  class CSVHelperTest
    {
        [TestMethod]
        public void TestXsxlToCSV()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string filePath = System.AppDomain.CurrentDomain.BaseDirectory + "/TaskFile/6E81335460484425E053DF4B000A79B5.xlsx";
            CSVHelperTwo.XLSSavesaCSV(filePath);
            sw.Stop();
            long time = sw.ElapsedMilliseconds;

        }
        [TestMethod]
        public void TestCSVToXsx()
        {
            string dataItemfilePath = System.AppDomain.CurrentDomain.BaseDirectory + "/TaskFile/1.csv";
            CSVHelperTwo.CSVSavesaXLS(dataItemfilePath);
        }
    }
}

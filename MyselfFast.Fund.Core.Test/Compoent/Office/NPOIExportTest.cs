using FescoFast.Collect.Core.Component.Office;
using FescoFast.Collect.Core.Component.Office.xls;
using FescoFast.Collect.Core.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FescoFast.Collect.Core.Test.Compoent.Office
{
    /**********************************************************************************
     *项目名称	：FescoFast.Collect.Core.Test.Compoent.Office
     *项目描述  ：
     *类名称    ：NPOIExportTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : NPOIExportTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-21 16:38:40
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public  class NPOIExportTest
    {
        [TestMethod]
        public void TestExport()
        {
             DataSet ds = new DataSet();
             DataTable dt = new DataTable("测试sheet1");
             dt.Columns.Add("first");
             dt.Columns.Add("second");
             dt.Columns.Add("three");
             dt.Columns.Add("four");
             var row1= dt.NewRow();
                row1[0] = "f0";
                row1[1] = "s0";
                row1[2] = "t0";
                row1[3] = "f0";
                dt.Rows.Add(row1);
            var row2= dt.NewRow();
                row2[0] = "f1";
                row2[1] = "s1";
                row2[2] = "t1";
                row2[3] = "f1";
                dt.Rows.Add(row2);
            var row3= dt.NewRow();
                row3[0] = "f2";
                row3[1] = "s2";
                row3[2] = "t2";
                row3[3] = "f2";
                dt.Rows.Add(row3);
             ds.Tables.Add(dt);

             DataTable dt2 = new DataTable("测试sheet11");
             dt2.Columns.Add("first");
             dt2.Columns.Add("second");
             dt2.Columns.Add("three");
             dt2.Columns.Add("four");
             var row11 = dt2.NewRow();
             row11[0] = "f0";
             row11[1] = "s0";
             row11[2] = "t0";
             row11[3] = "f0";
             dt2.Rows.Add(row11);
             var row21 = dt2.NewRow();
             row21[0] = "f1";
             row21[1] = "s1";
             row21[2] = "t1";
             row21[3] = "f1";
             dt2.Rows.Add(row21);
             var row31 = dt2.NewRow();
             row31[0] = "f2";
             row31[1] = "s2";
             row31[2] = "t2";
             row31[3] = "f2";
             dt2.Rows.Add(row31);
             ds.Tables.Add(dt2);

            //string path = System.AppDomain.CurrentDomain.BaseDirectory + "/Export1.xlsx";
            //using( FileStream  fs = new FileStream(path,FileMode.OpenOrCreate)){
            //    NpoiExportHelper.Export(ds,fs);
            //}
             
        }
         [TestMethod]
        public void TestListExport()
        {
            ExportModleList<T_Article> lists = new ExportModleList<T_Article>();
            Dictionary<string, string> dics = new Dictionary<string, string>();
            dics.Add("AdminName", "管理员名称");
            dics.Add("Content", "内容");
            dics.Add("CreateTime", "创建时间");
            dics.Add("Description", "描述");
            
            lists.NpoiExportModles.Add(new ExportModle<T_Article>
            {
                SheetName = "object test sheet",
                Title = "tile test object",
                Propertys = dics,
                DataList = new List<T_Article>()
                {
                    new T_Article{
                        AdminName = "adminname",
                        Content = "content",
                        CreateTime = DateTime.Now,
                        Description = "liuyong"
},new T_Article{
                        AdminName = "adminname",
                        Content = "content",
                        CreateTime = DateTime.Now,
                        Description = "liuyong"
},
new T_Article{
                        AdminName = "adminname",
                        Content = "content",
                        CreateTime = DateTime.Now,
                        Description = "liuyong"
},
new T_Article{
                        AdminName = "adminname",
                        Content = "content",
                        CreateTime = DateTime.Now,
                        Description = "liuyong"
}
                }
            });
             string path = System.AppDomain.CurrentDomain.BaseDirectory + "/Export1.xlsx";
             using( FileStream  fs = new FileStream(path,FileMode.OpenOrCreate)){
                 ExportObjectHelper.Export<T_Article>(lists, fs);
            }
           
        }
    }
}

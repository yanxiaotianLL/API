using FescoFast.Fund.Core.Component.Office.OleDb;
using FescoFast.Fund.Core.Domain.JiCai;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FescoFast.Fund.Core.Test.Compoent.Office
{
    /**********************************************************************************
     *项目名称	：FescoFast.Fund.Core.Test.Compoent.Office
     *项目描述  ：
     *类名称    ：OleDbHelperTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : OleDbHelperTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-02-06 23:29:19
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]  
    public  class OleDbHelperTest
    {
        public FescoFast.Fund.Core.Component.Office.OleDb.OleDbHelper.FileData TestFileData;
        [TestMethod]
        public void TestExcelRead()
        {
            string filePath = System.AppDomain.CurrentDomain.BaseDirectory + "/TaskFile/生数测试2018-12-25.xlsx";

            TestFileData += FileData;
            OleDbHelper.ReadExcelToDataReader(filePath, 0, "业务客户编号", TestFileData,null);
        }
        [TestMethod]
        public void TestExcelToDataTable()
        {
            string filePath = System.AppDomain.CurrentDomain.BaseDirectory + "/TaskFile/生数测试2018-12-25.xlsx";
            string sql = string.Format("SELECT DISTINCT [业务客户编号] FROM [{0}]", "Sheet1$"); //查询字符串
            DataTable dt = OleDbHelper.ReadExcelToDataTable(filePath, 0, sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sql = string.Format("SELECT * FROM [{0}] WHERE [业务客户编号] = '{1}'", "Sheet1$",dt.Rows[i][0].ToString()); //查询字符串
                DataTable dtt = OleDbHelper.ReadExcelToDataTable(filePath, 0, sql);
            }

        }
        public void FileData(OleDbDataReader reader,T_JC_Task task)
        {

            int count = 0;
            string c1;
            string c2;
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    T_JC_DataItem item = OleDbHelper.MapperToEntity<T_JC_DataItem>(reader);
                    Console.WriteLine("ID={0},region={1},department={2},name={3},phone1={4}", reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                    Console.WriteLine(1);
                    count++;
                }
                break;
            }
        }
    }
}

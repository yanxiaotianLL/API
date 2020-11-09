using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Component.Office.xls
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Component.Office
     *项目描述  ：
     *类名称    ：NpoiExportHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : NpoiExportHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-21 15:27:00
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static  class ExportDataTableHelper
    {
       
        /// <summary>
        /// 导出数据到excel
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="stream"></param>
        public static void Export(DataSet dataSet,Stream stream)
        {
            if (dataSet == null) { throw new ArgumentNullException("dataSet不能为空！"); }
            if (dataSet.Tables == null || dataSet.Tables.Count <= 0) { throw new ArgumentNullException("dataSet.Tables不能为空！"); }
            //创建workbook
            var workBook = NpoiHelper.CreateWorkBook();
            foreach (DataTable t in dataSet.Tables)
            {
                var sheet = workBook.CreateSheet(t.TableName);
                //NpoiHelper.FileDataToSheet(workBook, t, sheet, "");
            }
            workBook.Write(stream);
        }
        /// <summary>
        /// 导出数据到excel
        /// </summary>
        /// <param name="dataTalbe"></param>
        /// <param name="stream"></param>
        /// <param name="title"></param>
        /// <param name="sheetName"></param>
        public static void Export(DataTable dataTalbe, Stream stream, string title, string sheetName)
        {
            //创建workbook
            var workBook = NpoiHelper.CreateWorkBook();
            if (dataTalbe != null)
            {
                var sheet = workBook.CreateSheet(sheetName);
                //NpoiHelper.FileDataToSheet(workBook, dataTalbe, sheet, title);
                workBook.Write(stream);
            }
           
        }
        /// <summary>
        /// 导出数据到excel
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="filePath"></param>
        public static void Export(DataSet dataSet, string filePath)
        {
            if (dataSet == null) { throw new ArgumentNullException("dataSet不能为空！"); }
            if (dataSet.Tables == null || dataSet.Tables.Count <= 0) { throw new ArgumentNullException("dataSet.Tables不能为空！"); }
            //创建workbook
            var workBook = NpoiHelper.CreateWorkBook();
            foreach (DataTable t in dataSet.Tables)
            {
                var sheet = workBook.CreateSheet(t.TableName);
                //NpoiHelper.FileDataToSheet(workBook, t, sheet, "");
            }
            using(FileStream fs = new FileStream(filePath,FileMode.OpenOrCreate)){
               
                workBook.Write(fs);
            }
        }
        /// <summary>
        /// 导出数据到excel
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="title"></param>
        /// <param name="sheetName"></param>
        /// <param name="filePath"></param>
        public static void Export(DataTable dataTable, string title, string sheetName, string filePath)
        {
            //创建workbook
            var workBook = NpoiHelper.CreateWorkBook();
            if (dataTable != null)
            {
                var sheet = workBook.CreateSheet(sheetName);
                //NpoiHelper.FileDataToSheet(workBook, dataTable, sheet, title);
               
            }
            using(FileStream fs = new FileStream(filePath,FileMode.OpenOrCreate)){
                 workBook.Write(fs);
            }
        }
        
       
    
    }
}

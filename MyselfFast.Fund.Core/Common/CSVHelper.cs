using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace myselfFast.Fund.Core.Common
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Common
     *项目描述  ：
     *类名称    ：CSVHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : CSVHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-03-03 18:12:56
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class CSVHelper
    {
        /// <returns>返回转换后的Xls文件名</returns>
        public static string CSVSaveasXLS(string FilePath)
        {
            QuertExcel();
            string _NewFilePath = "";

            Excel.Application excelApplication;
            Excel.Workbooks excelWorkBooks = null;
            Excel.Workbook excelWorkBook = null;
            Excel.Worksheet excelWorkSheet = null;

            try
            {
                excelApplication = new Excel.ApplicationClass();
                excelWorkBooks = excelApplication.Workbooks;
                excelWorkBook = ((Excel.Workbook)excelWorkBooks.Open(FilePath, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value));
                excelWorkSheet = (Excel.Worksheet)excelWorkBook.Worksheets[1];
                excelApplication.Visible = false;
                excelApplication.DisplayAlerts = false;
                _NewFilePath = FilePath.Replace(".csv", ".xls");
                excelWorkBook.SaveAs(_NewFilePath, Excel.XlFileFormat.xlAddIn, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                excelWorkBook.Close();
                QuertExcel();
                // ExcelFormatHelper.DeleteFile(FilePath);
                //可以不用杀掉进程QuertExcel();


                GC.Collect(System.GC.GetGeneration(excelWorkSheet));
                GC.Collect(System.GC.GetGeneration(excelWorkBook));
                GC.Collect(System.GC.GetGeneration(excelApplication));

            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }

            finally
            {
                GC.Collect();
            }

            return _NewFilePath;
        }



        /// <summary>
        /// 将xls文件转换为csv文件
        /// </summary>
        /// <param name="FilePath">文件全路路径</param>
        /// <returns>返回转换后的csv文件名</returns>
        public static string XLSSavesaCSV(string FilePath)
        {
            QuertExcel();
            string _NewFilePath = "";

            Excel.Application excelApplication;
            Excel.Workbooks excelWorkBooks = null;
            Excel.Workbook excelWorkBook = null;
            Excel.Worksheet excelWorkSheet = null;

            try
            {
                excelApplication = new Excel.ApplicationClass();
                excelWorkBooks = excelApplication.Workbooks;
                excelWorkBook = ((Excel.Workbook)excelWorkBooks.Open(FilePath, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value));
                excelWorkSheet = (Excel.Worksheet)excelWorkBook.Worksheets[1];
                excelApplication.Visible = false;
                excelApplication.DisplayAlerts = false;
                _NewFilePath = FilePath.Replace(".xlsx", ".csv");

                // excelWorkSheet._SaveAs(FilePath, Excel.XlFileFormat.xlCSVWindows, Missing.Value, Missing.Value, Missing.Value,Missing.Value,Missing.Value, Missing.Value, Missing.Value);
                excelWorkBook.SaveAs(_NewFilePath, Excel.XlFileFormat.xlCSV, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                QuertExcel();
                //ExcelFormatHelper.DeleteFile(FilePath);
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            return _NewFilePath;
        }



        /// <summary>
        /// 删除一个指定的文件
        /// </summary>
        /// <param name="FilePath">文件路径</param>
        /// <returns></returns>
        public static bool DeleteFile(string FilePath)
        {
            try
            {
                bool IsFind = File.Exists(FilePath);
                if (IsFind)
                {
                    File.Delete(FilePath);
                }
                else
                {
                    throw new IOException("指定的文件不存在");
                }
                return true;
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }

        }


        /// <summary>
        /// 执行过程中可能会打开多个EXCEL文件 所以杀掉
        /// </summary>
        private static void QuertExcel()
        {
            Process[] excels = Process.GetProcessesByName("EXCEL");
            foreach (var item in excels)
            {
                item.Kill();
            }
        }

    }
}

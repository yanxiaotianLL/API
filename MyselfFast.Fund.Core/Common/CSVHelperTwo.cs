using myselfFast.Fund.Core.Common;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Common.Extensions;

namespace myselfFast.Fund.Core.Common
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Common
     *项目描述  ：
     *类名称    ：CSVHelperTwo
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : CSVHelperTwo
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-03-03 18:39:17
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class CSVHelperTwo
    {
               /// <summary>
        /// 将xls文件转换为csv文件
        /// </summary>
        /// <param name="FilePath">文件全路路径</param>
        /// <returns>返回转换后的csv文件名</returns>
        public static void XLSSavesaCSV(string FilePath)
        {
            string _NewFilePath = "";
            _NewFilePath = FilePath.Replace(".xlsx", ".csv");
            Workbook workbook = new Workbook();
            //Stream stream = new FileStream(FilePath,FileMode.Open);

            workbook.LoadFromFile(FilePath);
            
            //获取第一张工作表 
            Worksheet sheet = workbook.Worksheets[0];

            CellRange[] rangesEnters = sheet.FindAllString("\r\n", false, false);

            foreach (CellRange range in rangesEnters)
            {

                range.Text = "";               

            }
            CellRange[] rangesEnter = sheet.FindAllString("\n", false, false);

            foreach (CellRange range in rangesEnter)
            {

                range.Text = "";

            }
            CellRange[] ranges = sheet.FindAllString(",", false, false);

            foreach (CellRange range in ranges)
            {

                range.Text = ".";

            }
            //保存为csv格式
            sheet.SaveToFile(_NewFilePath, ",", Encoding.Default); 
        }
        /// <summary>
        /// 将xls文件转换为csv文件
        /// </summary>
        /// <param name="FilePath">文件全路路径</param>
        /// <returns>返回转换后的csv文件名</returns>
        public static string CSVSavesaXLS(string FilePath, int row, int column)
        {
            string _NewFilePath = "";
            _NewFilePath = FilePath.Replace(".csv", ".xlsx");
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(FilePath, "\t",row,column);
           
            //保存为csv格式
            workbook.SaveToFile(_NewFilePath, ExcelVersion.Version2007);
            return _NewFilePath;
        }
        /// <summary>
        /// 将xls文件转换为csv文件
        /// </summary>
        /// <param name="FilePath">文件全路路径</param>
        /// <returns>返回转换后的csv文件名</returns>
        public static string CSVSavesaXLS(string FilePath)
        {
            string _NewFilePath = "";
            _NewFilePath = FilePath.Replace(".csv", ".xlsx");
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(FilePath, "\t");

            //保存为csv格式
            workbook.SaveToFile(_NewFilePath, ExcelVersion.Version2007);
            return _NewFilePath;
        }
       /// <summary>
        /// 导出数据表到csv文件
       /// </summary>
       /// <param name="stream"></param>
       /// <param name="dic">csv列名：表列名称</param>
       /// <param name="dt"></param>
        public static void ExportDataTableToCSV(Stream stream,Dictionary<string,string> dic, System.Data.DataTable dt)
        {

            StreamWriter sw = new StreamWriter(stream, System.Text.Encoding.UTF8);          
            //构建表头
            foreach (var item in dic)
            {
                sw.Write(DelQuota(item.Key));
                sw.Write("\t");
            }
            //sw.WriteLine("");
            //Table body
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                foreach (var item in dic)
                {
                    var value = dt.Rows[i][item.Value].ToString() == "" ? string.Empty : dt.Rows[i][item.Value].ToString();
                    sw.Write(DelQuota(value));
                    //sw.Write(DelQuota(value));
                    sw.Write("\t");
                }
                //sw.WriteLine("");
            }
            sw.Flush();
            sw.Close();
           
        }
        /// <summary>
        /// 导出数据表到csv文件
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="dic">csv列名：表列名称</param>
        /// <param name="dt"></param>
        public static void ExportDataListToCSV<T>(Stream stream, Dictionary<string, String> dic, List<T> data)
        {
            //ReflectionUtil.GetObjectPropertyValue<T>(dataList[j], keys.ElementAt(i-1).Value);

            StreamWriter sw = new StreamWriter(stream, System.Text.Encoding.UTF8);
            //构建表头
            foreach (var item in dic)
            {
                string k = item.Key;
                sw.Write(k);
                sw.Write("\t");
            }
            sw.WriteLine("");
            //Table body

            foreach(var items in data){
                foreach (var item in dic)
                {
                    if (item.Value == "IsNeedCollectTable")
                    {
                        string v = ReflectionUtil.GetObjectPropertyValue<T>(items, item.Value).ToString();
                        string vf = v == "true" ? "yes" : "no";
                        sw.Write(vf);
                        sw.Write("\t");
                    }
                    else
                    {
                        sw.Write(ReflectionUtil.GetObjectPropertyValue<T>(items, item.Value).ToString());
                        sw.Write("\t");
                    }
                    
                }
                sw.WriteLine("");
            }
           
            sw.Flush();
            sw.Close();

        }

        /// <summary>
        /// Delete special symbol
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string DelQuota(string str)
        {
            string result = str;
            string[] strQuota = { "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "`", ";", "'", ",", ".", "/", ":", "/,", "<", ">", "?" };
            for (int i = 0; i < strQuota.Length; i++)
            {
                if (result.IndexOf(strQuota[i]) > -1)
                    result = result.Replace(strQuota[i], "");
            }
            return result;
        }


    }
}

using myselfFast.Fund.Core.Common;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Component.Office.xls
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Component.Office
     *项目描述  ：
     *类名称    ：NpoiHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : NpoiHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-21 14:54:49
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// NPOI辅助工具类
    /// </summary>
    public static  class NpoiHelper
    {
       

        /// <summary>
        /// 将excle输出到文件
        /// </summary>
        /// <param name="workBook"></param>
        /// <param name="filePath"></param>
        public static void WriteFile(XSSFWorkbook workBook, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                workBook.Write(fs);
                fs.Flush();
            }
        }
        /// <summary>
        /// 从excel文件创建WorkBook
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static XSSFWorkbook ReadFile(string filePath)
        {
            XSSFWorkbook workBook;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                workBook = new XSSFWorkbook(fs);
                CreateWorkBook(workBook);
            }
            return workBook;
        }
        /// <summary>
        /// 创建表格
        /// </summary>
        /// <param name="company"></param>
        /// <param name="subject"></param>
        public static XSSFWorkbook CreateWorkBook(string company = "myself", string subject = "myself专属文档")
        {
            var workbook = new XSSFWorkbook();
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = company;

            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            //si.Subject = subject;
            //workbook. = dsi;
            //workbook.SummaryInformation = si;
            return workbook;
        }
        /// <summary>
        /// 创建表格(兼容03和07)
         /// <param name="stream"></param>
         /// <returns></returns>
         public static IWorkbook CreateWorkbook(Stream stream) 
         {
             try 
             {
                return new XSSFWorkbook(stream); //07
             }
             catch
             {
                return new HSSFWorkbook(stream); //03
             }
            
         }
        
       
        /// <summary>
        /// 创建表格
        /// </summary>
        /// <param name="company"></param>
        /// <param name="subject"></param>
        /// <returns></returns>
        public static void CreateWorkBook(XSSFWorkbook workbook, string company = "myself", string subject = "myself专属文档")
        {

            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = company;

            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = subject;
            //workbook.DocumentSummaryInformation = dsi;
            //workbook.SummaryInformation = si;

        }
       
        #region 有泛型对象列表导出
        /// <summary>
        /// 填充数据列表到sheet
        /// </summary>
        public static void FileDataToSheet<T>(XSSFWorkbook workbook, ExportModle<T> dataList, ISheet sheet)
             where T : class
        {
            //填充大标题
            FileDataTitleToSheet(workbook, dataList, sheet);
            //填充表头数据
            FileDataHeadToSheet(workbook, dataList, sheet);
            //填充表数据
            if (dataList != null && dataList.DataList.Count > 0)
            {
                FileDataToSheet<T>(workbook,sheet,dataList);
            }

        }
        /// <summary>
        /// 填充标题
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="dt"></param>
        /// <param name="sheet"></param>
        /// <param name="title"></param>
        public static void FileDataTitleToSheet<T>(XSSFWorkbook workbook, ExportModle<T> dataList, ISheet sheet)
            where T:class
        {
            //填充表头部分
            int count = dataList.Propertys.Count;
            var row = sheet.CreateRow(0);
            var cell = row.CreateCell(0);
            //设置单元格值
            cell.SetCellValue(dataList.Title);
            //设置单元格样式
            cell.CellStyle = NpoiHelper.CreateTileCellStyle(workbook, sheet, 24);
            //合并单元格
            CellRangeAddress cras = new CellRangeAddress(0, 0, 0, count - 1);
            sheet.AddMergedRegion(cras);
        }
        /// <summary>
        /// 填充表头数据
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="dt"></param>
        /// <param name="sheet"></param>
        public static void FileDataHeadToSheet<T>(XSSFWorkbook workbook, ExportModle<T> dataList, ISheet sheet)
             where T : class
        {
            //填充表头
            if (dataList.Propertys.Count > 0)
            {
                var row = sheet.CreateRow(1);
               
                int index = 0;
                foreach(var key in dataList.Propertys){
                     var cell = row.CreateCell(index);
                    //设置单元格样式
                    cell.CellStyle = NpoiHelper.CreateHeadCellStyle(workbook, sheet, 11);
                    cell.SetCellValue(dataList.Propertys[key.Key]);
                    //添加注释，用于导入识别
                    var commonet = CreateComment(sheet,key.Key, "myself Team");
                    cell.CellComment = commonet;
                    index++;
                }
            }
        }
        /// <summary>
        /// 填充表数据
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="data"></param>
        /// <param name="sheet"></param>
        public static void FileDataToSheet<T>(XSSFWorkbook workbook, ISheet sheet, ExportModle<T> dataList)
             where T : class
        {
            for (int i = 0; i < dataList.DataList.Count; i++)
            {
                var row = sheet.CreateRow(i+2);

                int j = 0;
                foreach (var key in dataList.Propertys)
                {
                    var cell = row.CreateCell(j);
                    //设置单元格样式
                    //cell.CellStyle = cell.CellStyle = NpoiHelper.CreateDataCellStyle(workbook, sheet, 11);
                    //设置单元格数据样式
                    ReflectionUtil.GetObjectPropertyValue<T>(dataList.DataList[i], key.Key);
                    var value = ReflectionUtil.GetObjectPropertyValue<T>(dataList.DataList[i], key.Key);
                    cell.SetCellValue(value == null?"" :value);
                    j++;
                }
               
            }
           

        }
        #endregion
        /*
        #region 有泛型对象列表导出
        /// <summary>
        /// 填充数据列表到sheet
        /// </summary>
        public static void FileDataToSheet<T>(XSSFWorkbook workbook, ExportModle<T> dataList, ISheet sheet)
             where T : class
        {
            //填充大标题
            FileDataTitleToSheet(workbook, dataList, sheet);
            //填充表头数据
            FileDataHeadToSheet(workbook, dataList, sheet);
            //填充表数据
            if (dataList != null && dataList.DataList.Count > 0)
            {
                FileDataToSheet<T>(workbook, sheet, dataList);
            }

        }
        /// <summary>
        /// 填充标题
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="dt"></param>
        /// <param name="sheet"></param>
        /// <param name="title"></param>
        public static void FileDataTitleToSheet<T>(XSSFWorkbook workbook, ExportModle<T> dataList, ISheet sheet)
            where T : class
        {
            //填充表头部分
            int count = dataList.Propertys.Count;
            var row = sheet.CreateRow(0);
            var cell = row.CreateCell(0);
            //设置单元格值
            cell.SetCellValue(dataList.Title);
            //设置单元格样式
            cell.CellStyle = NpoiHelper.CreateTileCellStyle(workbook, sheet, 24);
            //合并单元格
            CellRangeAddress cras = new CellRangeAddress(0, 0, 0, count - 1);
            sheet.AddMergedRegion(cras);
        }
        /// <summary>
        /// 填充表头数据
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="dt"></param>
        /// <param name="sheet"></param>
        public static void FileDataHeadToSheet<T>(XSSFWorkbook workbook, ExportModle<T> dataList, ISheet sheet)
             where T : class
        {
            //填充表头
            if (dataList.Propertys.Count > 0)
            {
                var row = sheet.CreateRow(1);

                int index = 0;
                foreach (var key in dataList.Propertys)
                {
                    var cell = row.CreateCell(index);
                    //设置单元格样式
                    cell.CellStyle = cell.CellStyle = NpoiHelper.CreateHeadCellStyle(workbook, sheet, 11);
                    cell.SetCellValue(dataList.Propertys[key.Key]);
                    //添加注释，用于导入识别
                    var commonet = CreateComment(sheet, key.Key, "myself Team");
                    cell.CellComment = commonet;
                    index++;
                }
            }
        }
        /// <summary>
        /// 填充表数据
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="data"></param>
        /// <param name="sheet"></param>
        public static void FileDataToSheet<T>(XSSFWorkbook workbook, ISheet sheet, ExportModle<T> dataList)
             where T : class
        {
            for (int i = 0; i < dataList.DataList.Count; i++)
            {
                var row = sheet.CreateRow(i + 2);

                int j = 0;
                foreach (var key in dataList.Propertys)
                {
                    var cell = row.CreateCell(j);
                    //设置单元格样式
                    cell.CellStyle = cell.CellStyle = NpoiHelper.CreateDataCellStyle(workbook, sheet, 11);
                    //设置单元格数据样式
                    ReflectionUtil.GetObjectPropertyValue<T>(dataList.DataList[i], key.Key);
                    cell.SetCellValue(ReflectionUtil.GetObjectPropertyValue<T>(dataList.DataList[i], key.Key));
                    j++;
                }

            }


        }
        #endregion

        #region 从dataset导出

        /// <summary>
        /// 填充数据到sheet
        /// </summary>
        public static void FileDataToSheet(XSSFWorkbook workbook, DataTable dt, ISheet sheet, string title)
        {
            //填充大标题
            FileDataTitleToSheet(workbook, dt, sheet, title);
            //填充表头数据
            FileDataHeadToSheet(workbook, dt, sheet);
            //填充表数据
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    FileDataToSheet(workbook, sheet, dt.Rows[i], i + 2);
                }
            }

        }
        /// <summary>
        /// 填充表数据
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="dr"></param>
        /// <param name="sheet"></param>
        public static void FileDataToSheet(XSSFWorkbook workbook, ISheet sheet, DataRow dr, int rowIndex)
        {

            var row = sheet.CreateRow(rowIndex);
            for (int i = 0; i < dr.Table.Columns.Count; i++)
            {
                var cell = row.CreateCell(i);
                //设置单元格样式
                cell.CellStyle = cell.CellStyle = NpoiHelper.CreateDataCellStyle(workbook, sheet, 11);
                //设置单元格数据样式
                cell.SetCellValue(dr[i].ToString());
            }

        }
        /// <summary>
        /// 填充表头数据
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="dt"></param>
        /// <param name="sheet"></param>
        public static void FileDataHeadToSheet(XSSFWorkbook workbook, DataTable dt, ISheet sheet)
        {
            //填充表头
            if (dt.Columns.Count > 0)
            {
                var row = sheet.CreateRow(1);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    var cell = row.CreateCell(i);
                    //设置单元格样式
                    cell.CellStyle = cell.CellStyle = NpoiHelper.CreateHeadCellStyle(workbook, sheet, 11);
                    cell.SetCellValue(dt.Columns[i].ColumnName);

                }
            }
        }
        /// <summary>
        /// 填充标题
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="dt"></param>
        /// <param name="sheet"></param>
        /// <param name="title"></param>
        public static void FileDataTitleToSheet(XSSFWorkbook workbook, DataTable dt, ISheet sheet, string title)
        {
            //填充表头部分
            int count = dt.Columns.Count;
            var row = sheet.CreateRow(0);
            var cell = row.CreateCell(0);
            //设置单元格值
            cell.SetCellValue(string.IsNullOrWhiteSpace(title) ? sheet.SheetName : title);
            //设置单元格样式
            cell.CellStyle = NpoiHelper.CreateTileCellStyle(workbook, sheet, 24);
            //合并单元格
            CellRangeAddress cras = new CellRangeAddress(0, 0, 0, count - 1);
            sheet.AddMergedRegion(cras);
        } 
        #endregion
        */
        #region 通用方法抽取
        /// <summary>
        /// 设置全部单元格边框
        /// </summary>
        /// <param name="style"></param>
        public static void SetBorderForAll(ICellStyle style)
        {
            //设置边框
            style.BorderBottom = BorderStyle.Thin;

            style.BorderLeft = BorderStyle.Thin;

            style.BorderRight = BorderStyle.Thin;

            style.BorderTop = BorderStyle.Thin;
        }
        /// <summary>
        /// 设置单元格Tile样式
        /// </summary>
        public static ICellStyle CreateTileCellStyle(XSSFWorkbook workbook, ISheet sheet, double fontHeight)
        {
            //单元格样式定义
            ICellStyle style = workbook.CreateCellStyle();
            //居中设置
            style.Alignment = HorizontalAlignment.Center;
            style.VerticalAlignment = VerticalAlignment.Center;
            //字体设置
            IFont font = workbook.CreateFont();
            font.FontHeight = fontHeight;
            font.Boldweight = (short)FontBoldWeight.Bold;
            style.SetFont(font);
            //设置背景颜色
            //style.FillForegroundColor = HSSFColor.BlueGrey.Index;
            //style.FillPattern = FillPattern.SolidForeground;
            //设置边框
            NpoiHelper.SetBorderForAll(style);
            return style;
        }
        /// <summary>
        /// 设置单元格Tile样式
        /// </summary>
        public static ICellStyle CreateTileCellStyle(XSSFWorkbook workbook, ISheet sheet, double fontHeight,short colorIndex)
        {
            //单元格样式定义
            ICellStyle style = workbook.CreateCellStyle();
            //居中设置
            style.Alignment = HorizontalAlignment.Center;
            style.VerticalAlignment = VerticalAlignment.Center;
            //字体设置
            IFont font = workbook.CreateFont();
            font.FontHeight = fontHeight;
            font.Boldweight = (short)FontBoldWeight.Bold;
            style.SetFont(font);
            //设置背景颜色
            style.FillForegroundColor = colorIndex;
            style.FillPattern = FillPattern.SolidForeground;
            //设置边框
            NpoiHelper.SetBorderForAll(style);
            return style;
        }
        /// <summary>
        /// 设置单元格Tile样式
        /// </summary>
        public static ICellStyle CreateHeadCellStyle(IWorkbook workbook, ISheet sheet, double fontHeight)
        {
            //单元格样式定义
            ICellStyle style = workbook.CreateCellStyle();
            //居中设置
            style.Alignment = HorizontalAlignment.Center;
            style.VerticalAlignment = VerticalAlignment.Center;
            //字体设置
            IFont font = workbook.CreateFont();
            font.FontHeight = fontHeight;
            font.Boldweight = (short)FontBoldWeight.Bold; ;
            style.SetFont(font);
            //设置背景颜色
            style.FillForegroundColor = HSSFColor.BlueGrey.Index; ;
            style.FillPattern = FillPattern.SolidForeground;
            //设置边框
            NpoiHelper.SetBorderForAll(style);
            return style;
        }
        /// <summary>
        /// 设置单元格Tile样式
        /// </summary>
        public static ICellStyle CreateDataCellStyle(XSSFWorkbook workbook, ISheet sheet, double fontHeight)
        {
            //单元格样式定义
            ICellStyle style = workbook.CreateCellStyle();
            ////居中设置
            //style.Alignment = HorizontalAlignment.Center;
            //style.VerticalAlignment = VerticalAlignment.Center;
            //NpoiHelper.SetBorderForAll(style);
            return style;
        }

        /// <summary>
        /// 创建批注
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="comentContent"></param>
        /// <returns></returns>
        public static IComment CreateComment(ISheet sheet, string comentContent, string author = "myself Team")
        {
            if (sheet == null)
            {
                throw new ArgumentNullException("sheet不能为空");
            }
            IDrawing patr = sheet.CreateDrawingPatriarch();
            IComment comment = patr.CreateCellComment(new XSSFClientAnchor(0, 0, 0, 0, 1, 2, 4, 4));
            comment.String = new XSSFRichTextString(comentContent);
            comment.Author = author;
            return comment;

        } 
        #endregion

        /// <summary>
        /// 根据系统颜色值，计算NPOI颜色值
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="SystemColour"></param>
        /// <returns></returns>
        public static short GetXLColour(HSSFWorkbook workbook, System.Drawing.Color SystemColour)
        {
            short s = 0;
            HSSFPalette XlPalette = workbook.GetCustomPalette();
            HSSFColor XlColour = XlPalette.FindColor(SystemColour.R, SystemColour.G, SystemColour.B);
            if (XlColour == null)
            {
                if (NPOI.HSSF.Record.PaletteRecord.STANDARD_PALETTE_SIZE < 255)
                {
                    if (NPOI.HSSF.Record.PaletteRecord.STANDARD_PALETTE_SIZE < 64)
                    {
                        //NPOI.HSSF.Record.PaletteRecord.STANDARD_PALETTE_SIZE = 64;
                        //NPOI.HSSF.Record.PaletteRecord.STANDARD_PALETTE_SIZE += 1;
                        XlColour = XlPalette.AddColor(SystemColour.R, SystemColour.G, SystemColour.B);
                    }
                    else
                    {
                        XlColour = XlPalette.FindSimilarColor(SystemColour.R, SystemColour.G, SystemColour.B);
                    }

                    s = XlColour.Indexed;
                }

            }
            else
                s = XlColour.Indexed;

            return s;
        }
        /// <summary>
        /// 获取单元格值
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        public static string GetCellValue(ICell cell)
        {

            string reslut = string.Empty;
            if (cell == null)
            {
                return reslut;
            }
            var type = cell.CellType;
            switch (type)
            {
                case CellType.Boolean:
                    reslut = cell.BooleanCellValue.ToString();
                    break;
                case CellType.Numeric:
                    reslut = cell.NumericCellValue.ToString();
                    break;
                case CellType.String:
                    reslut = cell.StringCellValue;
                    break;
                default:
                    break;
            }
            return reslut;
        }

    }
}

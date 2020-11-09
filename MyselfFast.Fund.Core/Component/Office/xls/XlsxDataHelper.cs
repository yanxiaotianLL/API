using myselfFast.Fund.Core.Common;
using NPOI.HSSF.UserModel;
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
     *项目名称	：myselfFast.Fund.Core.Component.Office.xls
     *项目描述  ：
     *类名称    ：ImportToListHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ImportToListHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-04-09 15:31:35
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 将excel中的数据导入到泛型结合对象中
    /// </summary>
    public static class XlsxDataHelper
    {
        #region 将excel表数据导入到泛型列表
        /// <summary>
        /// 将excel表数据导入到泛型列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath">excel文件路径</param>
        /// <param name="keys">属性对应集合</param>
        /// <returns></returns>

        public static List<T> ImportToList<T>(string filePath, Dictionary<string, string> keys, int titleIndex = 0)
            where T : class,new()
        {
            if (!System.IO.File.Exists(filePath))
            {
                throw new ArgumentException("filePath路径下文件不存在");
            }
            if (keys == null || keys.Count <= 0)
            {
                throw new ArgumentNullException("keys不能为空");
            }
            return XlsxDataHelper.ImportToList<T>(new FileStream(filePath, FileMode.Open), keys, titleIndex);

        }
        /// <summary>
        /// 将excel表数据导入到泛型列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream">excel文件路径</param>
        /// <param name="keys">属性对应集合</param>
        /// <returns></returns>
        public static List<T> ImportToList<T>(Stream stream, Dictionary<string, string> keys, int titleIndex = 0)
            where T : class,new()
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream流不能为空");
            }
            if (keys == null || keys.Count <= 0)
            {
                throw new ArgumentNullException("keys不能为空");
            }

            //加载excel数据到内存
            var workBook = NpoiHelper.CreateWorkbook(stream);
            var sheet = workBook.GetSheetAt(0);

            //用于记录excel表格中的列序号与keys键对应关系
            Dictionary<int, string> dataDic = new Dictionary<int, string>();
            List<T> listResult = new List<T>();
            //通过第一行标题行，确定dataDic的对应关系
            var rowFirst = sheet.GetRow(titleIndex);
            for (int i = 0; i < rowFirst.Cells.Count; i++)
            {
                var cell = rowFirst.GetCell(i);
                var str = NpoiHelper.GetCellValue(cell);
                if (keys.Keys.Contains(str))
                {
                    dataDic.Add(i, keys[str]);
                }
            }
            //遍历数据通过反射将数据映射到实体
            IRow row;
            T data;
            for (int i = titleIndex + 1; i <= sheet.LastRowNum; i++)
            {
                data = new T();
                row = sheet.GetRow(i);
                ICell cell;
                string cellValue;
                for (int j = 0; j < rowFirst.Cells.Count; j++)
                {
                    cell = row.GetCell(j);
                    cellValue = NpoiHelper.GetCellValue(cell);
                    ReflectionUtil.SetPropertyValue(data, dataDic[j], cellValue);

                }
                listResult.Add(data);
            }
            return listResult;

        }
        #endregion

        #region 将数据导出到excel表数据
        /// <summary>
        /// 将数据导出到excel表数据
        /// </summary>
        /// <param name="dataList">待导出数据列表</param>
        /// <param name="keys">字段、excel</param>
        /// <param name="stream"></param>
        /// <param name="titleIndex"></param>
        public static void ExportDataTableToXlsx(DataTable dataList, Dictionary<string, string> keys, Stream stream, string templeteFilePath, string sheetName, int titleIndex = 0)
        {
            if (dataList == null || dataList.Rows.Count <= 0)
            {
                throw new ArgumentNullException("dataList不能为空");
            }
            if (keys == null || keys.Count <= 0)
            {
                throw new ArgumentNullException("keys不能为空");
            }
            if (stream == null)
            {
                throw new ArgumentNullException("stream不能为空");
            }
            //创建workbook
            var workBook = string.IsNullOrEmpty(templeteFilePath) ? NpoiHelper.CreateWorkBook() : NpoiHelper.CreateWorkbook(new FileStream(templeteFilePath, FileMode.Open));
            var workSheet = string.IsNullOrEmpty(sheetName) ? workBook.CreateSheet() : workBook.CreateSheet(sheetName);
            IRow row = workSheet.CreateRow(titleIndex);
            ICell cell;
            //创建表头
            for (int i = 0; i < keys.Count; i++)
            {
                cell = row.CreateCell(i, CellType.String);
                cell.SetCellValue(keys.ElementAt(i).Key);
                cell.CellStyle = NpoiHelper.CreateHeadCellStyle(workBook, (ISheet)workSheet, 11);
            }

            string dataValue = string.Empty;
            //遍历数据集
            for (int j = 0; j < dataList.Rows.Count; j++)
            {
                row = workSheet.CreateRow(j + titleIndex + 1);
                for (int i = 0; i < keys.Count; i++)
                {
                    //dataValue = ReflectionUtil.GetObjectPropertyValue<T>(dataList[j], keys.ElementAt(i).Value);
                    dataValue = dataList.Rows[j][keys.ElementAt(i).Value].ToString();
                    cell = row.CreateCell(i, CellType.String);
                    cell.SetCellValue(dataValue);
                }
            }
            workBook.Write(stream);

        }
        /// <summary>
        /// 将数据导出到excel表数据
        /// </summary>
        /// <param name="dataList">待导出数据列表</param>
        /// <param name="keys">字段、excel</param>
        /// <param name="stream"></param>
        /// <param name="titleIndex"></param>
        public static void ExportToXlsx<T>(List<T> dataList, Dictionary<string, string> keys, Stream stream, string templeteFilePath, string sheetName, int titleIndex = 0)
        {
            if (dataList == null || dataList.Count <= 0)
            {
                throw new ArgumentNullException("dataList不能为空");
            }
            if (keys == null || keys.Count <= 0)
            {
                throw new ArgumentNullException("keys不能为空");
            }
            if (stream == null)
            {
                throw new ArgumentNullException("stream不能为空");
            }
            //创建workbook
            var workBook = string.IsNullOrEmpty(templeteFilePath) ? NpoiHelper.CreateWorkBook() : NpoiHelper.CreateWorkbook(new FileStream(templeteFilePath, FileMode.Open));
            var workSheet = string.IsNullOrEmpty(sheetName) ? workBook.CreateSheet() : workBook.CreateSheet(sheetName);
            IRow row = workSheet.CreateRow(titleIndex);
            ICell cell;
            //创建表头
            for (int i = 0; i < keys.Count; i++)
            {
                cell = row.CreateCell(i, CellType.String);
                cell.SetCellValue(keys.ElementAt(i).Key);
                cell.CellStyle = NpoiHelper.CreateHeadCellStyle(workBook, (ISheet)workSheet, 11);
            }

            string dataValue = string.Empty;
            //遍历数据集
            for (int j = 0; j < dataList.Count; j++)
            {
                row = workSheet.CreateRow(j + titleIndex + 1);
                for (int i = 0; i < keys.Count; i++)
                {
                    dataValue = ReflectionUtil.GetObjectPropertyValue<T>(dataList[j], keys.ElementAt(i).Value);
                    cell = row.CreateCell(i, CellType.String);
                    cell.SetCellValue(dataValue);
                }
            }
            workBook.Write(stream);

        }
      
        /// <summary>
        /// 将数据导出到excel表数据
        /// </summary>
        /// <param name="dataList">待导出数据列表</param>
        /// <param name="keys">字段、excel</param>
        /// <param name="stream"></param>
        /// <param name="titleIndex"></param>
        public static void ExportToXlsx<T>(List<T> dataList, Dictionary<string, string> keys, string saveFilePath, string templeteFilePath, string sheetName, int titleIndex = 0)
        {
            if (saveFilePath == null)
            {
                throw new ArgumentNullException("saveFilePath不能为空");
            }
            Stream stream = new FileStream(saveFilePath, FileMode.CreateNew);
            ExportToXlsx<T>(dataList, keys, stream, templeteFilePath, sheetName, titleIndex);
        }


        #endregion



        #region 定制部分
        /// <summary>
        /// 将数据导出到excel表数据--签收单
        /// </summary>
        /// <param name="dataList">待导出数据列表</param>
        /// <param name="keys">字段、excel</param>
        /// <param name="stream"></param>
        /// <param name="titleIndex"></param>
        public static void ExportToXlsxForSign<T>(List<T> dataList, Dictionary<string, string> keys, Stream stream, string sheetName, string title, int[] titleWidth, string submitMan, string signMan, string signDate, int titleIndex = 0)
        {
            if (dataList == null || dataList.Count <= 0)
            {
                throw new ArgumentNullException("dataList不能为空");
            }
            if (keys == null || keys.Count <= 0)
            {
                throw new ArgumentNullException("keys不能为空");
            }
            if (stream == null)
            {
                throw new ArgumentNullException("stream不能为空");
            }




            //创建workbook
            var workBook = NpoiHelper.CreateWorkBook();
            var workSheet = string.IsNullOrEmpty(sheetName) ? workBook.CreateSheet() : workBook.CreateSheet(sheetName);
            workSheet.DefaultRowHeight = 30 * 20;
            //workSheet.DefaultColumnWidth
            #region 创建大标题行
            //创建标题行
            IRow bigTitleRow = workSheet.CreateRow(0);
            var bigTitleCell = bigTitleRow.CreateCell(0);
            //设置单元格值
            bigTitleCell.SetCellValue(title);
            //设置单元格样式
            bigTitleCell.CellStyle = CreateTileCellStyle(workBook, workSheet, 18);
            //合并单元格
            CellRangeAddress cras = new CellRangeAddress(0, 0, 0, keys.Count - 1);
            workSheet.AddMergedRegion(cras);

            #endregion


            #region 创建表头
            IRow row = workSheet.CreateRow(titleIndex);
            ICell cell;

            var cellStyle = CreateTileCellStyle(workBook, workSheet);

            //创建表头
            for (int i = 0; i < keys.Count; i++)
            {
                cell = row.CreateCell(i, CellType.String);
                cell.SetCellValue(keys.ElementAt(i).Key);
                cell.CellStyle = cellStyle;
                workSheet.SetColumnWidth(i, titleWidth[i] * 256);

            }
            #endregion

            #region 创建数据表
            string dataValue = string.Empty;
            var dataCellStyle = CreateDataCellStyle(workBook, workSheet);
            //遍历数据集
            for (int j = 0; j < dataList.Count; j++)
            {
                row = workSheet.CreateRow(j + titleIndex + 1);
                for (int i = 0; i < keys.Count; i++)
                {
                    dataValue = ReflectionUtil.GetObjectPropertyValue<T>(dataList[j], keys.ElementAt(i).Value);
                    cell = row.CreateCell(i, CellType.String);
                    cell.SetCellValue(dataValue == null ? "" : dataValue.ToString());
                    cell.CellStyle = dataCellStyle;
                }
            }
            #endregion

            #region 签名区域填充

            var signCellStyle = CreateSignCellStyle(workBook, workSheet);


            var rowOne = workSheet.CreateRow(dataList.Count + titleIndex + 2);
            cell = rowOne.CreateCell(keys.Count - 2, CellType.String);

            cell.SetCellValue(string.Format("提交人:{0}", submitMan));
            cell.CellStyle = signCellStyle;

            var rowTwo = workSheet.CreateRow(dataList.Count + titleIndex + 3);
            cell = rowTwo.CreateCell(keys.Count - 2, CellType.String);
            cell.SetCellValue(string.Format("签收人:{0}", signMan));
            cell.CellStyle = signCellStyle;

            var rowThree = workSheet.CreateRow(dataList.Count + titleIndex + 4);
            cell = rowThree.CreateCell(keys.Count - 2, CellType.String);
            cell.SetCellValue(string.Format("签收日期:{0}", signDate));
            cell.CellStyle = signCellStyle;
            #endregion

            workBook.Write(stream);
        }

        /// <summary>
        /// 补充采集定制导出方法（锁定指定列）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="stream"></param>
        /// <param name="lockCol"></param>
        public static void ExportToXlsxForReSign<T>(ExportModleList<T> list, Stream stream, List<string> lockCol, int[] titleWidth)
            where T : class
        {
            if (list == null)
                throw new ArgumentNullException("list不能为空");
            if (stream == null)
                throw new ArgumentNullException("stream不能为空");

            var NpoiExportModle = list.NpoiExportModles[0];

            //创建workbook
            var workBook = NpoiHelper.CreateWorkBook();
            var workSheet = string.IsNullOrEmpty(NpoiExportModle.SheetName) ? workBook.CreateSheet() : workBook.CreateSheet(NpoiExportModle.SheetName);
            workSheet.DefaultRowHeight = 30 * 20;
            workSheet.ProtectSheet("1");

            var tableCol = NpoiExportModle.Propertys;
            var fillData = NpoiExportModle.DataList;

            #region 创建标题

            //创建标题行
            IRow bigTitleRow = workSheet.CreateRow(0);
            var bigTitleCell = bigTitleRow.CreateCell(0);
            //设置单元格值
            bigTitleCell.SetCellValue(NpoiExportModle.Title);
            //设置单元格样式
            bigTitleCell.CellStyle = CreateTileCellStyle(workBook, workSheet, 18);
            //合并单元格
            CellRangeAddress cras = new CellRangeAddress(0, 0, 0, tableCol.Count - 1);
            workSheet.AddMergedRegion(cras);
            #endregion

            #region 创建表头
            IRow row = workSheet.CreateRow(1);
            ICell cell;

            var cellStyle = CreateTileCellStyle(workBook, workSheet);

            //创建表头
            for (int i = 0; i < tableCol.Count; i++)
            {
                cell = row.CreateCell(i, CellType.String);
                cell.SetCellValue(tableCol.ElementAt(i).Value);
                cell.CellStyle = cellStyle;
                //添加注释，用于导入识别
                var commonet = NpoiHelper.CreateComment(workSheet, tableCol.ElementAt(i).Key, "myself Team");
                cell.CellComment = commonet;

                if (titleWidth.Count() > 0)
                    workSheet.SetColumnWidth(i, titleWidth[i] * 256);
            }
            #endregion

            #region 填充数据
            string dataValue = string.Empty;
            //锁定单元格
            var dataCellStyleLocked = CreateDataCellStyle(workBook, workSheet, true);
            //不锁定单元格
            var dataCellStyleUnLocked = CreateDataCellStyle(workBook, workSheet, false);
            //遍历数据集
            for (int j = 0; j < fillData.Count; j++)
            {
                row = workSheet.CreateRow(j + 1 + 1);
                for (int i = 0; i < tableCol.Count; i++)
                {
                    dataValue = ReflectionUtil.GetObjectPropertyValue<T>(fillData[j], tableCol.ElementAt(i).Key);
                    cell = row.CreateCell(i, CellType.String);
                    cell.SetCellValue(dataValue == null ? "" : dataValue.ToString());
                    if (i < tableCol.Count - 2)
                        cell.CellStyle = dataCellStyleLocked;
                    else
                        cell.CellStyle = dataCellStyleUnLocked;

                }
            }
            #endregion

            workBook.Write(stream);
        }
        #endregion

        /// <summary>
        /// 标题区域单元格样式指定
        /// </summary>
        public static ICellStyle CreateTileCellStyle(XSSFWorkbook workbook, ISheet sheet)
        {
            //单元格样式定义
            ICellStyle style = workbook.CreateCellStyle();
            //居中设置
            style.Alignment = HorizontalAlignment.Center;
            style.VerticalAlignment = VerticalAlignment.Center;
            //字体设置
            IFont font = workbook.CreateFont();
            font.FontHeight = 11;
            font.Boldweight = (short)FontBoldWeight.Bold;
            style.SetFont(font);
            //设置背景颜色 226 239 217
            //Color color = Color.FromArgb(226,239,217);
            style.FillForegroundColor = 21;
            style.FillPattern = FillPattern.SolidForeground;
            //设置边框
            NpoiHelper.SetBorderForAll(style);
            return style;
        }
        /// <summary>
        /// 数据区域样式指定
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="sheet"></param>
        /// <param name="fontHeight"></param>
        /// <returns></returns>
        public static ICellStyle CreateDataCellStyle(IWorkbook workbook, ISheet sheet, bool isLockCell = false)
        {
            //单元格样式定义
            ICellStyle style = workbook.CreateCellStyle();
            //居中设置
            style.Alignment = HorizontalAlignment.Center;
            style.VerticalAlignment = VerticalAlignment.Center;
            //字体设置
            IFont font = workbook.CreateFont();
            font.FontHeight = 10;
            //font.Boldweight = (short)FontBoldWeight.Bold; ;
            style.SetFont(font);
            //设置背景颜色
            //style.FillForegroundColor = HSSFColor.BlueGrey.Index; ;
            //style.FillPattern = FillPattern.SolidForeground;

            //设置单元格不允许编辑
            style.IsLocked = isLockCell;


            //设置边框
            NpoiHelper.SetBorderForAll(style);
            return style;
        }
        /// <summary>
        /// 签名区域单元格样式指定
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="sheet"></param>
        /// <param name="fontHeight"></param>
        /// <returns></returns>
        public static ICellStyle CreateSignCellStyle(IWorkbook workbook, ISheet sheet)
        {
            //单元格样式定义
            ICellStyle style = workbook.CreateCellStyle();
            //居中设置
            style.Alignment = HorizontalAlignment.Left;
            style.VerticalAlignment = VerticalAlignment.Center;
            //字体设置
            IFont font = workbook.CreateFont();
            font.FontHeight = 11;
            font.Boldweight = (short)FontBoldWeight.Bold; ;
            style.SetFont(font);
            //设置背景颜色
            //style.FillForegroundColor = HSSFColor.BlueGrey.Index; ;
            //style.FillPattern = FillPattern.SolidForeground;
            //设置边框
            //NpoiHelper.SetBorderForAll(style);
            return style;
        }

        /// <summary>
        /// 设置单元格Tile样式
        /// </summary>
        public static ICellStyle CreateTileCellStyle(IWorkbook workbook, ISheet sheet, double fontHeight)
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

    }

}

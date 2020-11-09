using myselfFast.Fund.Core.Common;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Component.Office.xls
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Component.Office.xls
     *项目描述  ：
     *类名称    ：TianBaoDataHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : TianBaoDataHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-04-23 10:40:38
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// hr填报页面excel导入导出定制帮助类
    /// </summary>
    public static  class TianBaoDataHelper
    {
        public const string CH_TITLE = " 年度社保、公积金缴费工资基数采集表";
        public const string EN_TITLE = " Social Security and Housing Provident Fund Wage Base Data Collection Form";

        public const string CH_FILLCOMPANY = "填报单位:";
        public const string EN_FILLCOMPANY = "Name of establishment:";

        public const string CH_BUSSINESS = "业务客户编号：";
        public const string EN_BUSSINESS = "Business customer No.：";

        public const string CH_CONTNO = "商务合同编号：";
        public const string EN_CONTNO = "Business contract No.：";

        public const string CH_REGNO = "社保登记证号：";
        public const string EN_REGNO = "Social Insurance No.：";

        public const string CH_UNITNAMEPRINT = "公积金单位登记号：";
        public const string EN_UNITNAMEPRINT = "Housing Provident Fund No.：";

        #region 定制部分
        /// <summary>
        ///  将数据导出到excel表数据--采集表
       /// </summary>
       /// <typeparam name="T"></typeparam>
       /// <param name="keys">导出映射关系</param>
        ///<param name="statisticsKeys">统计列：求和</param>
       /// <param name="stream">输出流</param>
       /// <param name="sheetName">表单名称</param>
       /// <param name="title">标题</param>
       /// <param name="titleWidth">列宽</param>
       /// <param name="dataList">数据列表</param>
       /// <param name="fillCompany">填报单位</param>
       /// <param name="businessNo">业务客户编号</param>
       /// <param name="contNo">商务合同编号</param>
       /// <param name="regNo">社保登记证号</param>
       /// <param name="unitNamePrint">公积金登记证号</param>
       /// <param name="titleIndex">数据列表开始索引值</param>
        public static void ExportToXlsx<T>(Dictionary<string, string> keys,Stream stream, string sheetName, string title, int[] titleWidth, List<T> dataList, string fillCompany, string businessNo, string contNo,string regNo,string unitNamePrint,bool isChinese = true)
        {
            if (dataList == null)
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
            string sName = isChinese ? "CN" : "ENGLISH";
            var workSheet = string.IsNullOrEmpty(sheetName) ? workBook.CreateSheet(sName) : workBook.CreateSheet(sheetName + "_" + sName);
            workSheet.DefaultRowHeight = 30 * 20;
            //workSheet.DefaultColumnWidth
            #region 创建大标题行
            //创建标题行
            IRow bigTitleRow = workSheet.CreateRow(0);
            var bigTitleCell = bigTitleRow.CreateCell(0);
            var bigTileStyle = CreateTileCellStyle(workBook, workSheet, 18);
            //设置单元格值
            bigTitleCell.SetCellValue(title + (isChinese ? CH_TITLE : EN_TITLE));
            //设置单元格样式
            bigTitleCell.CellStyle = bigTileStyle;
            for (int i = 1; i <= keys.Count;i++ )
            {
                bigTitleCell = bigTitleRow.CreateCell(i);
                bigTitleCell.CellStyle = bigTileStyle;

            }
            //合并单元格
            CellRangeAddress cras = new CellRangeAddress(0, 0, 0, keys.Count);
            workSheet.AddMergedRegion(cras);
           

            var dataCellStyle = CreateDataCellStyle(workBook, workSheet);
            //创建识别标头

            //var comment = isChinese ? CreateComment(workSheet, "CN") : CreateComment(workSheet, "EN");
            //comment.Visible = true;
            //bigTitleCell.CellComment = comment;
            #endregion
            #region 填报单位行
            IRow row = workSheet.CreateRow(1);
            var bussinessCell = row.CreateCell(0);
            bussinessCell.SetCellValue(title + (isChinese ? CH_FILLCOMPANY : EN_FILLCOMPANY));
            bussinessCell.CellStyle = dataCellStyle; //样式设定
            bussinessCell.CellStyle.Alignment = HorizontalAlignment.Left;
            for (int i = 1; i <= keys.Count; i++)
            {
               
                bussinessCell = row.CreateCell(i);
                bussinessCell.CellStyle = dataCellStyle;
                //if (i == 1)
                //{
                //    bussinessCell.CellComment = comment;
                //}

            }
           
            
            CellRangeAddress crasForBussinessCell = new CellRangeAddress(1, 1, 0, keys.Count);
            workSheet.AddMergedRegion(crasForBussinessCell);
            

            #endregion
            #region 商务信息行
            row = workSheet.CreateRow(2);
            var shangwuCell = row.CreateCell(0);
            string shangwuValue = string.Format("{0}{1}     {2}{3} \r\n {4}{5}      {6}{7}", (isChinese ? CH_BUSSINESS : EN_BUSSINESS),businessNo,(isChinese ? CH_CONTNO : EN_CONTNO),contNo,(isChinese ? CH_REGNO : EN_REGNO),regNo,(isChinese ? CH_UNITNAMEPRINT : EN_UNITNAMEPRINT),unitNamePrint);
            shangwuCell.SetCellValue(shangwuValue);
            bussinessCell.CellStyle = dataCellStyle; //样式设定
            CellRangeAddress crasForShangWuCell = new CellRangeAddress(2, 2, 0, keys.Count);
            workSheet.AddMergedRegion(crasForShangWuCell);

            #endregion

            #region 创建表头
            row = workSheet.CreateRow(3);
            ICell cell;

            var cellStyle = CreateTileCellStyle(workBook, workSheet);

            //创建表头
            for (int i = 0; i <= keys.Count; i++)
            {
                cell = row.CreateCell(i, CellType.String);
                if(i==0){
                    cell.SetCellValue("序号");
                }
                else
                {
                    cell.SetCellValue(keys.ElementAt(i-1).Key);
                }
               
               
                cell.CellStyle = cellStyle;
                if(i != 0){
                    workSheet.SetColumnWidth(i, titleWidth[i - 1] * 256);
                }

            }
            #endregion

            #region 创建数据表
            string dataValue = string.Empty;
            int rowIndex = 3;
            //遍历数据集
            for (int j = 0; j < dataList.Count; j++)
            {
                row = workSheet.CreateRow(j + 3 + 1);
                rowIndex = j + 3 + 1;

                for (int i = 0; i <= keys.Count; i++)
                {
                    if(i == 0){
                        dataValue = (j + 1).ToString();
                    }
                    else
                    {
                        dataValue = ReflectionUtil.GetObjectPropertyValue<T>(dataList[j], keys.ElementAt(i-1).Value);
                    }
                  


                    if (i == 4 || i ==5)
                    {
                        cell = row.CreateCell(i, CellType.Numeric);
                        cell.SetCellValue(string.IsNullOrWhiteSpace(dataValue) ? 0 : Convert.ToDouble(dataValue));
                        cell.CellStyle = dataCellStyle;
                    }
                    else 
                    {
                        cell = row.CreateCell(i, CellType.String);
                        cell.SetCellValue(dataValue == null ? "" : dataValue.ToString());
                        cell.CellStyle = dataCellStyle;
                    }
                }
            }
            #endregion 

            #region 合计
            row = workSheet.CreateRow(rowIndex + 1);
            for (int i = 0; i <= keys.Count; i++)
            {
                cell = row.CreateCell(i, CellType.String);
                if(i == 0){
                    dataValue = "合计";
                    cell.SetCellValue(dataValue);
                }else if(i == 4){
                    dataValue = string.Format("SUM(E5:E{0})", rowIndex + 1);
                    cell.SetCellFormula(dataValue);
                }else if(i == 5){
                    dataValue = string.Format("SUM(F5:F{0})", rowIndex + 1);
                    cell.SetCellFormula(dataValue);
                }else
                {
                    dataValue = "";
                    cell.SetCellValue(dataValue);
                }      
 
                cell.CellStyle = dataCellStyle;

            }
            #endregion

            workBook.Write(stream);
        }
        /// <summary>
        /// 导出数据到内存泛型列表对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chineseKeys"></param>
        /// <param name="englishKeys"></param>
        /// <param name="stream"></param>
        /// <param name="dataTitleIndex"></param>
        /// <returns></returns>
        public static List<T> ImportXlsxToData<T>(Dictionary<string, string> chineseKeys, Dictionary<string, string> englishKeys, Stream stream,int dataTitleIndex = 3)
            where T: new()
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream流不能为空");
            }
            if (chineseKeys == null || chineseKeys.Count <= 0)
            {
                throw new ArgumentNullException("chineseKeys不能为空");
            }
            if (englishKeys == null || englishKeys.Count <= 0)
            {
                throw new ArgumentNullException("englishKeys不能为空");
            }

            Dictionary<string, string> keys = null;

            //加载excel数据到内存
            var workBook = NpoiHelper.CreateWorkbook(stream);
            var sheet = workBook.GetSheetAt(0);
            //获取comment值
            IRow row = null;
            row = sheet.GetRow(0);
            ICell cell;
            cell = row.GetCell(0);

            var comment = cell.CellComment;


            keys = chineseKeys;
            keys = sheet.SheetName.EndsWith("CN") ? chineseKeys : englishKeys;
            //用于记录excel表格中的列序号与keys键对应关系
            Dictionary<int, string> dataDic = new Dictionary<int, string>();
            List<T> listResult = new List<T>();
            //通过第一行标题行，确定dataDic的对应关系
            var rowFirst = sheet.GetRow(dataTitleIndex);
            for (int i = 0; i < rowFirst.Cells.Count; i++)
            {
                
                cell = rowFirst.GetCell(i);
                //if (i == 1)
                //{
                //    comment = cell.CellComment;
                //    //中英文模版确认
                //    //keys = (comment.String.String == "CN") ? chineseKeys : englishKeys;
                //    keys = sheet.SheetName.EndsWith("CH") ? chineseKeys : englishKeys;
                //}
                var str = NpoiHelper.GetCellValue(cell);
                if (keys.Keys.Contains(str))
                {
                    dataDic.Add(i, keys[str]);
                }
            }
         
            //遍历数据通过反射将数据映射到实体
            //IRow row;
            T data;
            for (int i = dataTitleIndex + 1; i < sheet.LastRowNum; i++)
            {
                data = new T();
                row = sheet.GetRow(i);
               
                string cellValue;
                for (int j = 0; j < rowFirst.Cells.Count; j++)
                {
                    cell = row.GetCell(j);
                    cellValue = NpoiHelper.GetCellValue(cell);
                    if (dataDic.Keys.Contains(j))
                    {
                        ReflectionUtil.SetPropertyValue(data, dataDic[j], cellValue);
                    }
                    

                }
                listResult.Add(data);
            }
            return listResult;
        }
       
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
        public static ICellStyle CreateDataCellStyle(IWorkbook workbook, ISheet sheet)
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
            style.ShrinkToFit = true;
            //style.IsLocked = true;

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

        /// <summary>
        /// 创建区分标注
        /// </summary>
        /// <returns></returns>
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
    }
}

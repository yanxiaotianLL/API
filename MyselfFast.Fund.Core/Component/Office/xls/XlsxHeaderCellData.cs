using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FescoFast.Collect.Core.Component.Office.xls
{
    /**********************************************************************************
     *项目名称	：FescoFast.Collect.Core.Component.Office.xls
     *项目描述  ：
     *类名称    ：XlsxDataModel
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : XlsxDataModel
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-04-13 12:40:49
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class XlsxSheetData
    {
        public string SheetName { get; set; }
        public int   
        public List<XlsxHeaderCellData> XlsxHeaderCellData { get; set; }
    }


    public class XlsxHeaderCellData
    {
        //excel标题列名称
        public string Key { get; set; }
        /// <summary>
        /// 对象属性名称
        /// </summary>
        public string Value { get; set; }
        //<=256
        public int Width { get; set; }
        //<=256
        public int Height { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Component.Office.xls
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Component.Office.xls
     *项目描述  ：
     *类名称    ：NpoiBaseModle
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : NpoiBaseModle
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-21 18:49:40
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 对象集合导出基类
    /// </summary>
    public  class ExportModle<T>
        where T:class
    {
        /// <summary>
        /// 标题文字
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// sheet表单名称
        /// </summary>
        public string SheetName { get; set; }
        /// <summary>
        /// 标题属性，占位符替换，用于模版导出
        /// </summary>
        public IDictionary<string, string> TitlePropertys { get; set; }
        /// <summary>
        /// 数据填充位，从0开始
        /// </summary>
        public int DataIndex { get; set; }
        /// <summary>
        /// 导出属性集合（表头）
        /// </summary>
        public IDictionary<string,string> Propertys {get;set;}
        /// <summary>
        /// 导出数据集合
        /// </summary>
        public IList<T> DataList { get; set; }
    }

    public class ExportModleList<T>
        where T:class
    {
        
        private IList<ExportModle<T>> npoiExportModles;
        public ExportModleList()
        {
            npoiExportModles = new List<ExportModle<T>>();
        }
        public IList<ExportModle<T>> NpoiExportModles { get {
            return npoiExportModles;
            }
            set { this.npoiExportModles = value; }
        }
    }
}

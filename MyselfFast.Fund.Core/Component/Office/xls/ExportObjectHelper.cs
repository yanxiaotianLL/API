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
     *类名称    ：ExportObjectHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ExportObjectHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-21 19:23:57
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static class ExportObjectHelper
    {
        /// <summary>
        /// 导出excel到流
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="stream"></param>
        public static void Export<T>(ExportModleList<T> list, Stream stream)
            where T:class
        {
            if (list == null)
            {
                throw new ArgumentNullException("list不能为空!");
            }
            if (list.NpoiExportModles == null || list.NpoiExportModles.Count <= 0)
            {
                throw new ArgumentNullException("list.NpoiExportModles不能为空!");
            }
            //创建workbook
            var workBook = NpoiHelper.CreateWorkBook();
            for (int i = 0; i < list.NpoiExportModles.Count;i++ )
            {
                //创建sheet
                var sheet = workBook.CreateSheet(list.NpoiExportModles[i].SheetName);
                NpoiHelper.FileDataToSheet<T>(workBook, list.NpoiExportModles[i], sheet);
            }
            workBook.Write(stream);
        }
        /// <summary>
        /// 导出excel到excel文件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="filePath"></param>
        public static void Export<T>(ExportModleList<T> list, string filePath)
            where T : class
        {
            if (list == null)
            {
                throw new ArgumentNullException("list不能为空!");
            }
            if (list.NpoiExportModles == null || list.NpoiExportModles.Count <= 0)
            {
                throw new ArgumentNullException("list.NpoiExportModles不能为空!");
            }
            //创建workbook
            var workBook = NpoiHelper.CreateWorkBook();
            for (int i = 0; i < list.NpoiExportModles.Count; i++)
            {
                //创建sheet
                var sheet = workBook.CreateSheet(list.NpoiExportModles[i].SheetName);
                NpoiHelper.FileDataToSheet<T>(workBook, list.NpoiExportModles[i], sheet);
            }
            using(FileStream stream = new FileStream(filePath,FileMode.OpenOrCreate)){
                workBook.Write(stream);
            }
        }
    }
}

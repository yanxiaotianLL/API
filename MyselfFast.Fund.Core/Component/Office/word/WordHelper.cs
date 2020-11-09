using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Component.Office.word
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Component.Office.word
     *项目描述  ：
     *类名称    ：WordHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : WordHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-21 23:47:48
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static class WordHelper
    {
        #region 占位符替换
        public static void PlaceholderReplace(string filePath, Stream stream, IDictionary<string, string> dics)
        {
            var doc = new Document();
            doc.LoadFromFile(filePath);
            if (dics != null && dics.Count > 0)
            {
                foreach (var keyValuePair in dics)
                {
                    doc.Replace(keyValuePair.Key, keyValuePair.Value.ToString(), false, false);
                }
            }
            doc.SaveToStream(stream, FileFormat.Docx);
        }
        public static void PlaceholderReplace(string filePath, string savePath, IDictionary<string, string> dics)
        {
            var doc = new Document();
            doc.LoadFromFile(filePath);
            if (dics != null && dics.Count > 0)
            {
                foreach (var keyValuePair in dics)
                {
                    doc.Replace(keyValuePair.Key, keyValuePair.Value.ToString(), false, false);
                }
            }
            doc.SaveToFile(savePath);
            doc.Close();
            //System.Diagnostics.Process.Start(savePath);
        }
        
        #endregion

        #region word转换为pdf  
        public static void ConverToPdf(string filePath, Stream stream)
        {
            var doc = new Document();
            doc.LoadFromFile(filePath);
            doc.SaveToStream(stream, FileFormat.PDF);
            doc.Close();
           
        }
        public static void ConverToPdf(string filePath, string saveFile)
        {
            var doc = new Document();
            doc.LoadFromFile(filePath);
            doc.SaveToFile(saveFile,FileFormat.PDF);
            doc.Close();
            //System.Diagnostics.Process.Start(saveFile);
            
        } 
        #endregion
        #region word转换为Html
        public static void ConverToHtml(string filePath, Stream stream)
        {
            var doc = new Document();
            doc.LoadFromFile(filePath);
            doc.SaveToStream(stream,FileFormat.Html);
            doc.Close();
        }
        public static void ConverToHtml(string filePath, string saveFile)
        {
            var doc = new Document();
            doc.LoadFromFile(filePath);
            using (FileStream fs = new FileStream(saveFile, FileMode.OpenOrCreate))
            {
                doc.SaveToStream(fs, FileFormat.Html);
            }
            doc.Close();
        }
        #endregion
        #region word转换为图片
        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="pageIndex">从0开始</param>
        /// <param name="pageCount"></param>
        /// <returns></returns>
        public static System.Drawing.Image[] ConverToPics(string filePath,int pageIndex,int pageCount)
        {
            if (pageIndex + 1 > pageCount)
            {
                throw new ArgumentException("pageIndex + 1 > pageCount异常");
            }
            var doc = new Document();
            doc.LoadFromFile(filePath);
            int count = doc.PageCount;
            if (pageCount + pageIndex > count)
            {
                throw new ArgumentException("pageCount + pageIndex > pageCount异常");
            }
            return doc.SaveToImages(pageIndex, pageCount, Spire.Doc.Documents.ImageType.Bitmap);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="saveFile"></param>
        /// <param name="pageIndex">从0开始</param>
        public static void ConverToPic(string filePath, string saveFile, int pageIndex)
        {
            var doc = new Document();
            doc.LoadFromFile(filePath);
            if (doc.PageCount < 1)
            {
                throw new ArgumentException("word文档不能为空");
            }
            if (pageIndex + 1 > doc.PageCount)
            {
                throw new ArgumentException("pageIndex不能大于文档页数");
            }
            var draw = doc.SaveToImages(pageIndex, 1, Spire.Doc.Documents.ImageType.Bitmap)[0];
            draw.Save(saveFile,ImageFormat.Jpeg);
        }
        public static void ConverToPic(string filePath, Stream stream, int pageIndex)
        {
            var doc = new Document();
            doc.LoadFromFile(filePath);
            if (doc.PageCount < 1)
            {
                throw new ArgumentException("word文档不能为空");
            }
            if (pageIndex + 1 > doc.PageCount)
            {
                throw new ArgumentException("pageIndex不能大于文档页数");
            }
            var draw = doc.SaveToImages(pageIndex, 1, Spire.Doc.Documents.ImageType.Bitmap)[0];
            draw.Save(stream,ImageFormat.Jpeg);
        }
          */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="saveFile"></param>
        /// <param name="pageIndex">从0开始</param>
        public static void ConverToPic(string filePath, string saveFile)
        {
            var doc = new Document();
            doc.LoadFromFile(filePath);
           
            if (doc.PageCount !=1)
            {
                throw new ArgumentException("只能对单页文档进行转换");
            }
            var draw = doc.SaveToImages(0, Spire.Doc.Documents.ImageType.Bitmap);
            draw.Save(saveFile, ImageFormat.Jpeg);
            doc.Close();
        }
        public static void ConverToPic(string filePath, Stream stream)
        {
            var doc = new Document();
            doc.LoadFromFile(filePath);
            if (doc.PageCount != 1)
            {
                throw new ArgumentException("只能对单页文档进行转换");
            }
            var draw = doc.SaveToImages(0, Spire.Doc.Documents.ImageType.Bitmap);
            draw.Save(stream, ImageFormat.Jpeg);
            doc.Close();
        }
        #endregion
    }
}

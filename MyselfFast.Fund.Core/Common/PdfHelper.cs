using ExpertPdf.HtmlToPdf;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Common
{
    /// <summary>
    /// pdf帮助类
    /// </summary>
    public class PdfHelper
    {

        /// <summary>
        /// 将图片转化成pdf页面
        /// </summary>
        /// <param name="htmlPath">html页面的物理路径</param>
        /// <param name="htmlPath">pdf文件的存放全路径</param>
        /// <returns></returns>
        public void CreatPdf(object datapath)
        {
            //设置单线程执行环境
            PdfData data = (PdfData)datapath;
            Document doc = new Document(PageSize.A4, 9, 18, 36, 36);//左右上下
            MemoryStream ms = new MemoryStream();//创建内存流
            PdfWriter writer = PdfWriter.GetInstance(doc, ms);
            //用于将html转化成图片
            HtmlToPic htmlToPicMethod = new HtmlToPic();

            bool result = false;

            try
            {

                writer.CloseStream = false;
                doc.Open();
                System.Drawing.Bitmap bitmap = null;
                htmlToPicMethod.setBitmap(data.htmlPath, out bitmap);

                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(bitmap, System.Drawing.Imaging.ImageFormat.Bmp);//生成图片
                img.ScalePercent(75);//560 630  依照比例缩放
                doc.Add(img);//图片加入文档
                writer.Flush();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                doc.Close();
                writer.Close();
            }
            using (FileStream fs = new FileStream(data.savepdfPath, FileMode.Create))
            {
                ms.Position = 0;
                byte[] bit = new byte[ms.Length];
                ms.Read(bit, 0, (int)ms.Length);//读
                fs.Write(bit, 0, bit.Length);//写
                result = true;
            }


        }
        /// <summary>
        /// 传入html生成pdf
        /// </summary>
        /// <param name="contentHtml"></param>
        public byte[] EPHtmlCreatePdf(string contentHtml)
        {
            //FileOperateHelper fh = new FileOperateHelper();
            FileStream fs = System.IO.File.Open(System.Web.HttpContext.Current.Server.MapPath("./gjjzqNewPdf.css"), FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            string scc = sr.ReadToEnd();
            StringBuilder content = new StringBuilder();
            content.AppendFormat("<!DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">  <html><head><style>{0}</style></head><body>{1}</body></html>", scc, contentHtml);
            //string content = contentHtml.Replace("<script src=\"/Esvr/Scripts/jquery-1.8.2.min.js\"></script>","<style>" + scc + "</style>");
            content = content.Replace("<img src=\"", "<img src=\"http://192.168.0.79:8610/");
            //string webServer = System.Configuration.ConfigurationManager.AppSettings["Current_Path"];
            //switch (webServer)
            //{
            //    case "helo":
            //        content = content.Replace("<img src=\"", "<img src=\"http://helotest.myself.com.cn");
            //        break;
            //    case "es":
            //        content = content.Replace("<img src=\"", "<img src=\"http://es.myself.com.cn");
            //        break;
            //    case "es36":
            //        content = content.Replace("<img src=\"", "<img src=\"http://10.0.53.10:8044");
            //        break;
            //    default:
            //        content = content.Replace("<img src=\"", "<img src=\"http://helotest.myself.com.cn");
            //        break;
            //}
            sr.Close();
            fs.Close();
            byte[] filepdf = null;
            try
            {
                filepdf = HtmlToPDF(content.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return filepdf;
        }
        /// <summary>
        /// 新版pdf插件
        /// </summary>
        /// <param name="htmlText"></param>
        /// <returns></returns>
        public byte[] HtmlToPDF(string htmlText)
        {
            MemoryStream outputStream = new MemoryStream();
            PdfConverter pdfConverter = new PdfConverter();
            pdfConverter.PdfDocumentOptions.PdfPageSize = PdfPageSize.A4;
            pdfConverter.PdfDocumentOptions.PdfCompressionLevel = PdfCompressionLevel.Normal;
            pdfConverter.PdfDocumentOptions.ShowFooter = false;
            pdfConverter.PdfDocumentOptions.LeftMargin = 36;
            pdfConverter.PdfDocumentOptions.RightMargin = 36;
            pdfConverter.PdfDocumentOptions.TopMargin = 45;
            pdfConverter.PdfDocumentOptions.BottomMargin = 15;
            pdfConverter.PdfDocumentOptions.GenerateSelectablePdf = true;
            pdfConverter.PdfDocumentOptions.JpegCompressionEnabled = true;
            pdfConverter.PdfDocumentOptions.EmbedFonts = true;
            byte[] htmlBytes = pdfConverter.GetPdfBytesFromHtmlString(htmlText);
            return htmlBytes;
        }

        /// <summary>
        /// word转PDF
        /// </summary>
        public bool WordToPDF(System.Data.DataTable dt, string Location, string templateName, string saveLocation, out string localFilePath)
        {
            var result = false;
            localFilePath = string.Empty;
            try
            {
                #region 模板赋值生成PDF

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    System.Data.DataRow dr = dt.Rows[i];
                    Aspose.Words.Document doc = new Aspose.Words.Document(Location + templateName);//加载模板
                    string fName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + "_" + dr[0] + ".doc";
                    string savePath = Location + fName;//文件保存路径
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        //根据word中的标签赋值
                        doc.Range.Bookmarks["R" + j].Text = dr[j] + "";
                    }

                    doc.Save(savePath, Aspose.Words.SaveFormat.Doc);
                    DOCConvertToPDF(savePath, savePath.Replace(".doc", ".pdf"));
                    //保存文件路径
                    localFilePath = savePath.Replace(".doc", ".pdf");
                    //删除doc文件
                    if (File.Exists(savePath))
                        File.Delete(savePath);
                }
                #endregion
                result = true;
            }
            catch (Exception ex)
            {
            }
            return result;
        }
        private bool DOCConvertToPDF(string sourcePath, string targetPath)
        {
            bool result;
            try
            {
                Aspose.Words.Document document = new Aspose.Words.Document(sourcePath);

                document.Save(targetPath, Aspose.Words.SaveFormat.Pdf);
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
    public class PdfData
    {
        public string htmlPath { get; set; }
        public string savepdfPath { get; set; }
    }
}

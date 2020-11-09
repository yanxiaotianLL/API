
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace myselfFast.Fund.Core.Common
{
    public class PdfToPicture
    {
        /// <summary>

        /// 将PDF转换为图片

        /// </summary>

        /// <param name="pdfPath">pdf文件位置</param>

        /// <param name="pageNumber">pdf文件张数</param>

        /// <param name="size">pdf文件尺寸</param>

        /// <param name="outputPath">输出图片位置与名称</param>

        public void RenderPage(string pdfPath, int pageNumber, System.Drawing.Size size, string outputPath, int dpi = 300)
        {

            using (var document = PdfiumViewer.PdfDocument.Load(pdfPath))

            using (var stream = new FileStream(outputPath, FileMode.Create))

            using (var image = GetPageImage(pageNumber, size, document, dpi))
            {

                image.Save(stream, ImageFormat.Jpeg);

            }

        }

        private static Image GetPageImage(int pageNumber, Size size, PdfiumViewer.PdfDocument document, int dpi)
        {

            return document.Render(pageNumber - 1, size.Width, size.Height, dpi, dpi, PdfRenderFlags.Annotations);

        }
    }
}

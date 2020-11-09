using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myselfFast.Fund.Core.Common
{
     /// <summary>
    /// html转pic
    /// </summary>
    public class HtmlToPicHelper
    {
        /// <summary>
        /// 将html页面绘制成图片
        /// </summary>
        /// <param name="biturl">html文件路径</param>
        /// <param name="bitmap">二进制图片对象</param>
        public void setBitmap(string biturl, out System.Drawing.Bitmap bitmap)
        {
            int w = 760, h = 1200;
            using (WebBrowser wb = new WebBrowser())
            {
                wb.Width = w;
                wb.Height = h;
                wb.ScrollBarsEnabled = false;
                wb.Navigate(biturl);//加载url资源到WebBrowser控件
                //确保页面被解析完全
                while (wb.ReadyState != WebBrowserReadyState.Complete)
                {
                    System.Windows.Forms.Application.DoEvents();
                }
                bitmap = new System.Drawing.Bitmap(w, h);//创建图像
                wb.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, w, h));//图像加载到bitmap,bitmap放入矩形并锁定位置
                wb.Dispose();
            }
        }
    }
}

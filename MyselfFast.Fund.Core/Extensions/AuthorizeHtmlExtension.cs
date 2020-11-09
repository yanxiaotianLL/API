using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace myselfFast.Fund.Core.Extensions
{
    public static class AuthorizeHtmlExtension
    {
        public static MvcHtmlString OutputFileUrlNoCache(this HtmlHelper helper, string contentPath)
        {
            int index = contentPath.IndexOf("?", StringComparison.Ordinal);
            string filePath = contentPath;
            if (index != -1)
                filePath = contentPath.Substring(0, index);
            string date = new FileInfo(System.Web.Hosting.HostingEnvironment.MapPath(filePath)).LastWriteTime.ToString("yyyyMMddhhmmss");
            string q = string.Empty;

            if (index != -1)
                q = "&t=" + date;
            else
                q = "?t=" + date;
            string ext = Path.GetExtension(contentPath).ToLower();

            if (ext == ".js")
            {
                contentPath = "<script type=\"text/javascript\" language=\"javascript\" src=\"" + contentPath + q + "\"></script>";
            }
            else if (ext == ".css")
            {
                contentPath = "<link rel=\"stylesheet\"  href=\"" + contentPath + q + "\"/>";
            }
            else if (Path.GetExtension(contentPath).ToLower().Trim() == ".css")
            {
                contentPath = "<link rel=\"stylesheet\"  href=\"" + contentPath + q + "\"/>";
            }
            return new MvcHtmlString(contentPath);

        }
    }
}

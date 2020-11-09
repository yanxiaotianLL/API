using FescoFast.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FescoFast.Collect.Core
{
    /**********************************************************************************
     *项目名称	：FescoFast.Collect.Core
     *项目描述  ：
     *类名称    ：CommonHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : CommonHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-03-30 15:35:55
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static   class CommonHelper
    {
        /// <summary>
        /// 获取文件全路径
        /// </summary>
        /// <param name="basePath">基础路径</param>
        /// <param name="dirName">文件所在parent目录，如果没有，直接为基础路径</param>
        /// <param name="fileName">文件名称</param>
        /// <returns></returns>
        public static string GetFilePath(string basePath,string dirName,string fileId,string fileName)
        {
            string filePath = string.Empty;
            if (basePath.EndsWith("/"))
            {
                filePath = string.Format("{0}/{1}/{2}", basePath, dirName, fileId) + "." + FileOperateHelper.GetPostfixStr(fileName);
            }
            else
            {
                filePath = string.Format("/{0}/{1}/{2}", basePath, dirName, fileId) + "." + FileOperateHelper.GetPostfixStr(fileName);
            }
            return filePath;

        }
    }
}

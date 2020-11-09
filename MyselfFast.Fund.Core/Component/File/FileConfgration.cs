using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Component.File.FileServerr;
using myselfFast.Component.File.OSS;

namespace myselfFast.Component.File
{
    /**********************************************************************************
     *项目名称	：FS.Component.File
     *项目描述  ：
     *类名称    ：FileConfgration
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : FileConfgration
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/12 16:42:44
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 文件服务配置
    /// </summary>
    public class FileConfiguration
    {
        /// <summary>
        /// Fescco文件服务器配置项
        /// </summary>
        public  myselfFileServerConfiguration myselfFileServerConfiguration { get; set; }
        /// <summary>
        /// OSS文件服务器配置项
        /// </summary>
        public  OSSFileConfiguration OSSFileConfiguration { get; set; }

        public OSSFileConfigurations OSSFileConfigurations { get; set; }
    }
   
}

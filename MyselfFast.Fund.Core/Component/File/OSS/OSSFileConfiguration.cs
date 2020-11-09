using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.File.OSS
{
    /**********************************************************************************
     *项目名称	：FS.Component.File.OSS
     *项目描述  ：
     *类名称    ：OSSFileConfiguration
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : OSSFileConfiguration
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/12 17:15:08
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// OSS文件服务器配置项
    /// </summary>
    public   class OSSFileConfiguration
    {
       /// <summary>
        /// 服务地址
        /// </summary>
        public string Endpoint { get; set; }
        /// <summary>
        /// OSS用户标识
        /// </summary>
        public string AccessKeyId { get; set; }
        /// <summary>
        /// OSS访问密匙
        /// </summary>
        public string AccessKeySecret { get; set; }
        /// <summary>
        /// bucket名称
        /// </summary>
        public string DefaultBucketName { get; set; }
        /// <summary>
        /// 默认目录前缀
        /// </summary>
        public string KeyPrefix { get; set; }
        /// <summary>
        /// 帐号名称，用于区分多个oss帐号
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 是否为默认使用的项
        /// </summary>

        public bool IsDefault { get; set; }
    
    }
    public class OSSFileConfigurations
    {
        public List<OSSFileConfiguration> FileConfigurations { get; set; }
    }
}
 

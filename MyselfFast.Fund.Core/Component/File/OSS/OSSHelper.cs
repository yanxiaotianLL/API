using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aliyun.OSS;

namespace myselfFast.Component.File.OSS
{
    /**********************************************************************************
     *项目名称	：FS.Component.File.OSS
     *项目描述  ：
     *类名称    ：OSSHelper
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : OSSHelper
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/13 21:05:46
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static class OSSHelper
    {
        /// <summary>
        /// 由用户指定的OSS访问地址、阿里云颁发的AccessKeyId/AccessKeySecret构造一个新的OssClient实例。
        /// </summary>
        /// <param name="endpoint">OSS的访问地址。</param>
        /// <param name="accessKeyId">OSS的访问ID。</param>
        /// <param name="accessKeySecret">OSS的访问密钥。</param>
        public static OssClient CreateClient(string endpoint, string accessKeyId, string accessKeySecret)
        {
            return new OssClient(endpoint, accessKeyId, accessKeySecret);
        }
        /// <summary>
        /// 使用默认配置
        /// </summary>
        /// <returns></returns>
        public static OssClient CreateClient()
        {
            string accessKeyId = myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.AccessKeyId;
            string accessKeySecret =
                myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.AccessKeySecret;
            string endpoint = myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.Endpoint;
            return new OssClient(endpoint, accessKeyId, accessKeySecret);
        }
        /// <summary>
        /// 上传指定的文件到指定的OSS的存储空间
        /// </summary>
        /// <param name="bucketName">指定的存储空间名称</param>
        /// <param name="key">文件的在OSS上保存的名称</param>
        /// <param name="fileToUpload">指定上传文件的本地路径</param>
        public static bool PutObject(string accessKeyId, string accessKeySecret, string endpoint, string bucketName, string key, string fileToUpload,ref string etag)
        {
            try
            {
                var client = myselfFast.Component.File.OSS.OSSHelper.CreateClient(endpoint, accessKeyId, accessKeySecret);
                var result = client.PutObject(bucketName, key, fileToUpload);
                etag = result.ETag;
                return true;
            }
            catch (Exception ex)
            {
                var log = myselfFast.Component.Logging.LoggerProviderFactory.CreateLogger();
                log.Error("ossPutObject", "文件上传报错", ex);

            }
            return false;
        }
        /// <summary>
        /// 上传指定的文件到指定的OSS的存储空间
        /// </summary>
        /// <param name="bucketName">指定的存储空间名称</param>
        /// <param name="key">文件的在OSS上保存的名称</param>
        /// <param name="fileToUpload">指定上传文件的本地路径</param>
        public static bool PutObject(string bucketName, string key, string fileToUpload, ref string etag)
        {
            try
            {
                var client = myselfFast.Component.File.OSS.OSSHelper.CreateClient();
                var result = client.PutObject(bucketName, key, fileToUpload);
                etag = result.ETag;
                return true;
            }
            catch (Exception ex)
            {
                var log =  myselfFast.Component.Logging.LoggerProviderFactory.CreateLogger();
                log.Error("ossPutObject", "文件上传报错", ex);

            }
            return false;
        }
        /// <summary>
        /// 从指定的OSS存储空间中获取指定的文件
        /// </summary>
        /// <param name="bucketName">要获取的文件所在的存储空间名称</param>
        /// <param name="key">要获取的文件在OSS上的名称</param>
        /// <param name="fileToDownload">本地存储下载文件的目录<param>
        public static bool GetObject(string accessKeyId, string accessKeySecret, string endpoint, string bucketName, string key, string fileToDownload)
        {
            try
            {
                var client = myselfFast.Component.File.OSS.OSSHelper.CreateClient(endpoint, accessKeyId, accessKeySecret);
                var objects = client.GetObject(bucketName, key);
                //将从OSS读取到的文件写到本地
                using (var requestStream = objects.Content)
                {
                    byte[] buf = new byte[1024];
                    using (var fs = new System.IO.FileStream(fileToDownload, FileMode.OpenOrCreate))
                    {
                        var len = 0;
                        while ((len = requestStream.Read(buf, 0, 1024)) != 0)
                        {
                            fs.Write(buf, 0, len);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                var log = myselfFast.Component.Logging.LoggerProviderFactory.CreateLogger();
                log.Error("ossPutObject", "文件上传报错", ex);
            }
            return false;
        }
        /// <summary>
        /// 从指定的OSS存储空间中获取指定的文件
        /// </summary>string accessKeyId, string accessKeySecret, string endpoint, 
        /// <param name="bucketName">要获取的文件所在的存储空间名称</param>
        /// <param name="key">要获取的文件在OSS上的名称</param>
        /// <param name="fileToDownload">本地存储下载文件的目录<param>
        public static bool GetObject(string bucketName, string key, string fileToDownload)
        {
            try
            {
                var client = myselfFast.Component.File.OSS.OSSHelper.CreateClient();
                var objects = client.GetObject(bucketName, key);
                //将从OSS读取到的文件写到本地
                using (var requestStream = objects.Content)
                {
                    byte[] buf = new byte[1024];
                    using (var fs = new System.IO.FileStream(fileToDownload, FileMode.OpenOrCreate))
                    {
                        var len = 0;
                        while ((len = requestStream.Read(buf, 0, 1024)) != 0)
                        {
                            fs.Write(buf, 0, len);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                var log = myselfFast.Component.Logging.LoggerProviderFactory.CreateLogger();
                log.Error("ossGetObject", "文件下载报错", ex);
            }
            return false;
        }
        /// <summary>
        /// 从指定的OSS存储空间中获取指定的文件
        /// </summary>
        /// <param name="bucketName">要获取的文件所在的存储空间名称</param>
        /// <param name="key">要获取的文件在OSS上的名称</param>
        /// <param name="fileToDownload">本地存储下载文件的目录<param>
        public static Stream GetObjectStream(string accessKeyId, string accessKeySecret, string endpoint, string bucketName, string key)
        {
            try
            {
                var client = myselfFast.Component.File.OSS.OSSHelper.CreateClient(endpoint, accessKeyId, accessKeySecret);
                var objects = client.GetObject(bucketName, key);
                return objects.Content;
            }
            catch (Exception ex)
            {
                var log = myselfFast.Component.Logging.LoggerProviderFactory.CreateLogger();
                log.Error("ossGetObject", "文件下载报错", ex);
            }
            return null;
        }
        /// <summary>
        /// 从指定的OSS存储空间中获取指定的文件
        /// </summary>string accessKeyId, string accessKeySecret, string endpoint, 
        /// <param name="bucketName">要获取的文件所在的存储空间名称</param>
        /// <param name="key">要获取的文件在OSS上的名称</param>
        /// <param name="fileToDownload">本地存储下载文件的目录<param>
        public static Stream GetObjectStream(string bucketName, string key)
        {
            try
            {
                var client = myselfFast.Component.File.OSS.OSSHelper.CreateClient();
                var objects = client.GetObject(bucketName, key);
                return objects.Content;
            }
            catch (Exception ex)
            {
                var log = myselfFast.Component.Logging.LoggerProviderFactory.CreateLogger();
                log.Error("ossGetObject", "文件下载报错", ex);
            }
            return null;
        }
    }
}

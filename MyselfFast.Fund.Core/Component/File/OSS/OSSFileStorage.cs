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
     *类名称    ：OSSFileStorage
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : OSSFileStorage
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/13 0:31:53
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// oss存储实现
    /// </summary>
    public class OSSFileStorage:IOSSFileStorage
    {
        public bool UploadFile(string accessKeyId, string accessKeySecret, string endpoint, string bucketName, string key,string localFilePath,ref string etag)
        {
            return OSSHelper.PutObject(accessKeyId, accessKeySecret, endpoint, bucketName, key, localFilePath, ref etag);
        }

        public bool UploadFile(string bucketName, string key,string localFilePath,ref string etag)
        {
            return OSSHelper.PutObject(bucketName, key, localFilePath, ref etag);
        }

        public bool UploadFile(string bucketName, string keyPrefix, string suffix, string localFilePath, ref string etag, ref string key)
        {
           key = string.Format("{0}/{1}", keyPrefix, suffix);
           return this.UploadFile(bucketName, key, localFilePath, ref etag);
        }

        public bool UploadFileByPrefix(string keyPrefix, string suffix, string localFilePath, ref string etag, ref string key)
        {
            key = string.Format("{0}/{1}", keyPrefix, suffix);
            return this.UploadFile(myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.DefaultBucketName, key, localFilePath, ref etag);
        }

        public bool UploadFileByPrefix(string suffix, string localFilePath, ref string etag, ref string key)
        {
             key = string.Format("{0}/{1}", myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.KeyPrefix, suffix);
            return this.UploadFile(myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.DefaultBucketName, key, localFilePath, ref etag);
        }

        public System.IO.Stream DownFile(string accessKeyId, string accessKeySecret, string endpoint, string bucketName, string key)
        {
            return myselfFast.Component.File.OSS.OSSHelper.GetObjectStream(accessKeyId, accessKeySecret, endpoint, bucketName,
                key);
        }

        public System.IO.Stream DownFile(string bucketName, string key)
        {
            return myselfFast.Component.File.OSS.OSSHelper.GetObjectStream(bucketName, key);
        }

        public System.IO.Stream DownFile(string bucketName, string keyPrefix, string suffix)
        {
            string key = string.Format("{0}/{1}", keyPrefix, suffix);
            return myselfFast.Component.File.OSS.OSSHelper.GetObjectStream(bucketName, key);
        }

        public System.IO.Stream DownFileByPrefix(string keyPrefix, string suffix)
        {
            string key = string.Format("{0}/{1}", keyPrefix, suffix);
            return myselfFast.Component.File.OSS.OSSHelper.GetObjectStream(myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.DefaultBucketName, key);
        }

        public System.IO.Stream DownFileByPrefix(string suffix)
        {
            string key = string.Format("{0}/{1}", myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.KeyPrefix, suffix);
            return myselfFast.Component.File.OSS.OSSHelper.GetObjectStream(myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.DefaultBucketName, key);
        }

        public bool DownFile(string accessKeyId, string accessKeySecret, string endpoint, string bucketName, string key, string localFileName)
        {
            return myselfFast.Component.File.OSS.OSSHelper.GetObject(accessKeyId, accessKeySecret, endpoint, bucketName, key,
                localFileName);
        }

        public bool DownFileToLocal(string bucketName, string key, string localFileName)
        {
            return myselfFast.Component.File.OSS.OSSHelper.GetObject(bucketName, key,
                localFileName);
        }

        public bool DownFile(string bucketName, string keyPrefix, string suffix, string localFileName)
        {
            string key = string.Format("{0}/{1}", keyPrefix, suffix);
            return myselfFast.Component.File.OSS.OSSHelper.GetObject(bucketName, key,
                localFileName);
        }

        public bool DownFileByPrefix(string keyPrefix, string suffix, string localFileName)
        {
            string key = string.Format("{0}/{1}", keyPrefix, suffix);
            return myselfFast.Component.File.OSS.OSSHelper.GetObject(myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.DefaultBucketName, key,
                localFileName);
        }

        public bool DownFileByPrefixToLocal(string suffix, string localFileName)
        {
            string key = string.Format("{0}/{1}", myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.KeyPrefix, suffix);
            return myselfFast.Component.File.OSS.OSSHelper.GetObject(myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.DefaultBucketName, key,
                localFileName);
        }


        public System.IO.Stream DownFile(string key)
        {
            return myselfFast.Component.File.OSS.OSSHelper.GetObjectStream(myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.DefaultBucketName, key);
        }

        public bool DownFileByKeyToLocal(string key,string localFileName)
        {
            return myselfFast.Component.File.OSS.OSSHelper.GetObject(myselfFast.Component.File.GlobalConfiguration.Configuration.OSSFileConfiguration.DefaultBucketName, key,
                localFileName);
        }
    }
}

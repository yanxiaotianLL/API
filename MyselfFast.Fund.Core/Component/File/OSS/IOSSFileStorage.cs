using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.File.OSS
{
    /**********************************************************************************
     *项目名称	：FS.Component.File.OSS
     *项目描述  ：
     *接口名称  ：IOSSFileStorage
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : IOSSFileStorage
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/13 0:15:01
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// OSS存储接口
    /// </summary>
    public  interface IOSSFileStorage
    {
        #region OSS上传文件

        /// <summary>
        /// OSS文件操作接口
        /// </summary>
        /// <param name="accessKeyId">aliyun-accessKeyId</param>
        /// <param name="accessKeySecret">aliyun-accessKeySecret</param>
        /// <param name="endpoint">aliyun-endpoint</param>
        /// <param name="bucketName">aliyun-bucketName</param>
        /// <param name="key">aliyun-key</param>
        /// <returns></returns>
        bool UploadFile(string accessKeyId, string accessKeySecret, string endpoint, string bucketName, string key,
            string localFilePath, ref string etag);

        /// <summary>
        /// OSS文件操作接口部分默认
        /// </summary>
        /// <param name="bucketName">bucket</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        bool UploadFile(string bucketName, string key, string localFilePath, ref string etag);

        /// <summary>
        /// OSS文件操作接口部分默认 
        /// </summary>
        /// <param name="bucketName"></param>
        /// <param name="keyPrefix"></param>
        /// <param name="suffix"></param>
        /// <returns></returns>
        bool UploadFile(string bucketName, string keyPrefix, string suffix, string localFilePath, ref string etag, ref string key);

        /// <summary>
        /// OSS文件操作接口部分默认 
        /// </summary>
        /// <param name="keyPrefix"></param>
        /// <param name="suffix"></param>
        /// <returns></returns>
        bool UploadFileByPrefix(string keyPrefix, string suffix, string localFilePath, ref string etag, ref string key);

        /// <summary>
        /// OSS文件操作接口部分默认 
        /// </summary>
        /// <param name="suffix"></param>
        /// <returns></returns>
        bool UploadFileByPrefix(string suffix, string localFilePath, ref string etag, ref string key);
        #endregion
        #region OSS下载文件
        /// <summary>
        /// OSS文件操作接口
        /// </summary>
        /// <param name="accessKeyId">aliyun-accessKeyId</param>
        /// <param name="accessKeySecret">aliyun-accessKeySecret</param>
        /// <param name="endpoint">aliyun-endpoint</param>
        /// <param name="bucketName">aliyun-bucketName</param>
        /// <param name="key">aliyun-key</param>
        /// <returns></returns>
        Stream DownFile(string accessKeyId, string accessKeySecret, string endpoint, string bucketName, string key);
        /// <summary>
        /// OSS文件操作接口部分默认
        /// </summary>
        /// <param name="bucketName">bucket</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        Stream DownFile(string bucketName, string key);
        /// <summary>
        /// OSS文件操作接口部分默认
        /// </summary>
        /// <param name="bucketName">bucket</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        Stream DownFile(string key);
        /// <summary>
        /// OSS文件操作接口部分默认 
        /// </summary>
        /// <param name="bucketName"></param>
        /// <param name="keyPrefix"></param>
        /// <param name="suffix"></param>
        /// <returns></returns>
        Stream DownFile(string bucketName, string keyPrefix, string suffix);
        /// <summary>
        /// OSS文件操作接口部分默认 
        /// </summary>
        /// <param name="keyPrefix"></param>
        /// <param name="suffix"></param>
        /// <returns></returns>
        Stream DownFileByPrefix(string keyPrefix, string suffix);
        /// <summary>
        /// OSS文件操作接口部分默认 
        /// </summary>
        /// <param name="suffix"></param>
        /// <returns></returns>
        Stream DownFileByPrefix(string suffix);
        /// <summary>
        /// OSS文件操作接口
        /// </summary>
        /// <param name="accessKeyId">aliyun-accessKeyId</param>
        /// <param name="accessKeySecret">aliyun-accessKeySecret</param>
        /// <param name="endpoint">aliyun-endpoint</param>
        /// <param name="bucketName">aliyun-bucketName</param>
        /// <param name="key">aliyun-key</param>
        /// <returns></returns>
        bool DownFile(string accessKeyId, string accessKeySecret, string endpoint, string bucketName, string key,string localFileName);
        /// <summary>
        /// OSS文件操作接口部分默认
        /// </summary>
        /// <param name="bucketName">bucket</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        bool DownFileToLocal(string bucketName, string key,string localFileName);
        /// <summary>
        /// OSS文件操作接口部分默认 
        /// </summary>
        /// <param name="bucketName"></param>
        /// <param name="keyPrefix"></param>
        /// <param name="suffix"></param>
        /// <returns></returns>
        bool DownFile(string bucketName, string keyPrefix, string suffix, string localFileName);
        /// <summary>
        /// OSS文件操作接口部分默认 
        /// </summary>
        /// <param name="keyPrefix"></param>
        /// <param name="suffix"></param>
        /// <returns></returns>
        bool DownFileByPrefix(string keyPrefix, string suffix, string localFileName);
        /// <summary>
        /// OSS文件操作接口部分默认 
        /// </summary>
        /// <param name="suffix"></param>
        /// <returns></returns>
        bool DownFileByPrefixToLocal(string suffix, string localFileName);
        /// <summary>
        /// OSS文件操作接口部分默认 
        /// </summary>
        /// <param name="suffix"></param>
        /// <returns></returns>
        bool DownFileByKeyToLocal(string key,string localFileName);
        #endregion
    }
}

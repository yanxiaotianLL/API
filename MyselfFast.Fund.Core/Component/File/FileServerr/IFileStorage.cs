using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.File.FileServerr
{
    public   interface IFileStorage
    {
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="fileServerUrl">上传文件地址全路径包括文件夹</param>
        /// <param name="file">本地文件路径-全路径</param>
        /// <param name="strRet">文件服务器返回对应文件服务器文件全路路径</param>
        /// <returns></returns>
        bool UploadFile(string fileServerUrl, string file, out string strRet, string filedata = "image/jpeg");
        /// <summary>
        /// 通过指定channel上传文件
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="file"></param>
        /// <param name="strRet"></param>
        /// <returns></returns>
        bool UploadFileByChannel(string channel, string file, out string strRet, string filedata = "image/jpeg");
        /// <summary>
        /// 通过指定系统已经定义的channel上传文件
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="file"></param>
        /// <param name="strRet"></param>
        /// <returns></returns>
        bool UploadFileByChannel(Channel channel, string file, out string strRet, string filedata = "image/jpeg");
         /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="fileServerUrl">上传文件地址全路径包括文件夹</param>
        /// <param name="file">本地文件路径-全路径</param>
        /// <param name="strRet">文件服务器返回对应文件服务器文件全路路径</param>
        /// <returns></returns>
        bool UploadFile(string fileServerUrl, Stream stream, out string strRet, string filedata = "image/jpeg");
        /// <summary>
        /// 通过指定channel上传文件
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="file"></param>
        /// <param name="strRet"></param>
        /// <returns></returns>
        bool UploadFileByChannel(string channel, Stream stream,out string strRet, string filedata = "image/jpeg");
        /// <summary>
        /// 通过指定系统已经定义的channel上传文件
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="file"></param>
        /// <param name="strRet"></param>
        /// <returns></returns>
        bool UploadFileByChannel(Channel channel, Stream stream,out string strRet, string filedata = "image/jpeg");
        /// <summary>
        /// 文件下载
        /// </summary>
        /// <returns></returns>
        bool DownFile(string fileFullName,string localFileFullName);
        ///// <summary>
        ///// 根据文件名称获取文件，url路径采用默认地址
        ///// </summary>
        ///// <param name="fileName"></param>
        ///// <returns></returns>

        //bool DownFileByFileName(string fileName);
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.Core.Common;

namespace myselfFast.Component.File.FileServerr
{
    /// <summary>
    /// 
    /// </summary>
    public  class DefaultFileStorage:IFileStorage
    {

        public bool UploadFile(string fileServerUrl, string file, out string strRet, string filedata = "image/jpeg")
        {
            if (string.IsNullOrEmpty(fileServerUrl.Trim()))
            {
                throw new ArgumentNullException("fileServerUrl不能为空！");
            }
            if (string.IsNullOrEmpty(file.Trim()))
            {
                throw new ArgumentNullException("file不能为空！");
            }
           
            return  HttpHelper.UploadFile(fileServerUrl, file,filedata,out strRet);
        }
        public bool UploadFileByChannel(string channel, string file, out string strRet, string filedata = "image/jpeg")
        {
            if (string.IsNullOrEmpty(channel))
            {
                throw new ArgumentNullException("channel不能为空！");
            }
            if (myselfFast.Component.File.GlobalConfiguration.Configuration.myselfFileServerConfiguration.Channels.Split(',').Contains(channel))
            {
                throw new ArgumentNullException("channel可能不正确，请检查配置文件中是否正确配置了该channel！");
            }
            string url = string.Format("{0}?channel={1}",myselfFast.Component.File.GlobalConfiguration.Configuration.myselfFileServerConfiguration.ServerUrl,channel);
            return this.UploadFile(url, file, out strRet, filedata);
        }

        public bool UploadFileByChannel(Channel channel, string file, out string strRet, string filedata = "image/jpeg")
        {
            string url = string.Format("{0}?channel={1}", myselfFast.Component.File.GlobalConfiguration.Configuration.myselfFileServerConfiguration.ServerUrl, channel.ToString());
            return this.UploadFile(url, file, out strRet,filedata);
        }
        public bool DownFile(string fileFullName, string localFileFullName)
        {
            if (string.IsNullOrEmpty(fileFullName.Trim()))
            {
                throw new ArgumentNullException("fileFullName不能为空。");
            }
            if (string.IsNullOrEmpty(localFileFullName.Trim()))
            {
                throw new ArgumentNullException("localFileFullName不能为空。");
            }
            using (Stream stream = new FileStream(localFileFullName, FileMode.OpenOrCreate))
            {
                 Stream streamFile =  HttpHelper.HttpGetStream(fileFullName);
                 byte[] buffers = new byte[2048];
                 int offset = 0;
                 while (streamFile.Read(buffers, offset, buffers.Length) >0)
                 {
                     stream.Write(buffers, offset, buffers.Length);
                 }
                streamFile.Dispose();
            }
            return true;
        }


        public bool UploadFile(string fileServerUrl, Stream stream, out string strRet, string filedata = "image/jpeg")
        {
            if (string.IsNullOrEmpty(fileServerUrl.Trim()))
            {
                throw new ArgumentNullException("fileServerUrl不能为空！");
            }


            return HttpHelper.UploadFile(fileServerUrl, stream,filedata, out strRet);
        }

        public bool UploadFileByChannel(string channel, Stream stream, out string strRet, string filedata = "image/jpeg")
        {
            if (string.IsNullOrEmpty(channel))
            {
                throw new ArgumentNullException("channel不能为空！");
            }
            if (myselfFast.Component.File.GlobalConfiguration.Configuration.myselfFileServerConfiguration.Channels.Split(',').Contains(channel))
            {
                throw new ArgumentNullException("channel可能不正确，请检查配置文件中是否正确配置了该channel！");
            }
            string url = string.Format("{0}?channel={1}", myselfFast.Component.File.GlobalConfiguration.Configuration.myselfFileServerConfiguration.ServerUrl, channel);
            return this.UploadFile(url, stream, out strRet, filedata);
        }

        public bool UploadFileByChannel(Channel channel, Stream stream, out string strRet, string filedata = "image/jpeg")
        {
            string url = string.Format("{0}?channel={1}", myselfFast.Component.File.GlobalConfiguration.Configuration.myselfFileServerConfiguration.ServerUrl, channel.ToString());
            return this.UploadFile(url, stream, out strRet, filedata);
        }
    }


}

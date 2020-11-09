using myselfFast.Fund.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;


namespace myselfFast.Fund.Core.Common
{
    public class HttpHelper
    {
        /// <summary>
        /// Get请求,获取字符串
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns></returns>
        public static string HttpGetString(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();
            String result = response.Content.ReadAsStringAsync().Result;
            return result;
        }
        /// <summary>
        /// Get请求,获取字符串
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns></returns>
        public static string HttpGetString(string url,Dictionary<string,string> requestHeaders)
        {
            HttpClient httpClient = new HttpClient();
            if (requestHeaders != null && requestHeaders.Count >0)
            {
                foreach (var item in requestHeaders)
                {
                    if (!item.Key.ToUpper().Contains("CONTENT"))
                    {
                        httpClient.DefaultRequestHeaders.Add(item.Key, item.Value);  
                    }
                }
            }
            String result = string.Empty;
            HttpResponseMessage response = httpClient.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();
            result = response.Content.ReadAsStringAsync().Result;

            //try
            //{
                
            //}
            //finally
            //{
            //  headers = response.Headers.ToDictionary(p=>p.Key);
            //}
            return result;
        }
        /// <summary>
        /// Get请求,获取流
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns></returns>
        public static Stream HttpGetStream(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();
            Stream stream = response.Content.ReadAsStreamAsync().Result;
            return stream;
        }

        /// <summary>
        /// Post请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="paramDic">参数，字典格式存储，key：参数名，value：参数值</param>
        /// <returns></returns>
        public static string httpPost(string url, Dictionary<string, string> paramDic)
        {
            HttpClient httpClient = new HttpClient();
            List<KeyValuePair<String, String>> paramList = new List<KeyValuePair<String, String>>();
            foreach (KeyValuePair<string, string> item in paramDic)
            {
                paramList.Add(new KeyValuePair<string, string>(item.Key, item.Value));
            }
            HttpResponseMessage response = httpClient.PostAsync(new Uri(url), new FormUrlEncodedContentCostom(paramList)).Result;
            response.EnsureSuccessStatusCode();
            String result = response.Content.ReadAsStringAsync().Result;
            return result;
        }
        public static string httpPost(string url, string jsonParmaters, Dictionary<string, string> requestHeaders)
        {
            HttpClient httpClient = new HttpClient();
           //string str ="{\"sign\":\"bfdcf072e9227e9f81b26c888fe8180f\",\"noncestr\":\"3389f8f1-61bc-424c-902f-860b34d1c6fc\",\"timestamp\":\"1483529254\",\"appaccount\":\"NetworkApp\",\"jsonParam\":{\"PageIndex\":5,\"PageSize\":30}}";
            HttpContent content = new StringContent(jsonParmaters, Encoding.UTF8);
           if (requestHeaders != null && requestHeaders.Count > 0)
           {
               foreach (var item in requestHeaders)
               {
                   if (!item.Key.ToUpper().Contains("CONTENT"))
                   {
                       httpClient.DefaultRequestHeaders.Add(item.Key, item.Value);
                   }
                   else
                   {

                       if (content.Headers.Contains(item.Key))
                       {
                           content.Headers.Remove(item.Key);
                       }
                       content.Headers.Add(item.Key, item.Value);
                   }
               }
           }
           
            HttpResponseMessage response = httpClient.PostAsync(new Uri(url), content).Result;
            string result = string.Empty;
            response.EnsureSuccessStatusCode();
            result = response.Content.ReadAsStringAsync().Result;
          
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileServerUrl"></param>
        /// <param name="stream"></param>
        /// <param name="strRet"></param>
        /// <returns></returns>
        public static bool UploadFile(string fileServerUrl, string file, string filedata, out string strRet)
        {
            //byte[] buffer = System.Text.Encoding.UTF8.GetBytes(file);
            using (FileStream stream = new FileStream(file,FileMode.OpenOrCreate))
            {
                return UploadFile(fileServerUrl, stream,filedata, out strRet);
            }

        }


        /// <summary>
        /// 上传文件到文件服务器 "image/jpeg"
        /// </summary>
        /// <param name="filePath">本地文件路径，必须是物理路径。</param>
        /// <param name="strRet">返回文件服务器所上传文件访问地址。</param>
        /// <returns></returns>
        public static bool UploadFile(string fileServerUrl, Stream stream,string filedata,  out string strRet)
        {
            //if (string.IsNullOrEmpty(filePath))
            //{
            //    throw new ArgumentException("filePath:不能为空。");
            //}
            //if (!File.Exists(filePath))
            //{
            //    throw new FileNotFoundException(string.Format("[{0}]文件不存在。"));
            //}


            HttpClient httpClient = new HttpClient();
            //Stream stream = new FileStream(filePath, FileMode.Open);
            bool success = false;
            strRet = string.Empty;
            try
            {
                //StreamContent streamContent = CreateFileContents(stream, "Filedata",filedata);
                var response = httpClient.PostAsync(string.Format("{0}&t={1}", fileServerUrl, UploadToken()), CreateFileContent(stream, "Filedata", filedata)).Result;
                response.EnsureSuccessStatusCode();
                strRet = response.Content.ReadAsStringAsync().Result;
                
                success = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                httpClient.Dispose();
                stream.Dispose();
            }
            return success;
        }
        private static string UploadToken()
        {
            string token = string.Empty;
            var key = "fe#sk&(*_che" + DateTime.Now.ToString();
            token = Encryption.Encrypt(key);
            return token;
        }

        private static MultipartFormDataContent CreateFileContent(Stream stream, string fileName, string contentType)
        {
            var fileContent = new StreamContent(stream);

            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "\"Filedata\"",
                FileName = "\"" + fileName + "\""
            };
            fileContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
            MultipartFormDataContent content = new MultipartFormDataContent();
            content.Add(fileContent, "Filedata", "Filedata");
            return content;
        }

        private static StreamContent CreateFileContents(Stream stream, string fileName, string contentType)
        {
            var fileContent = new StreamContent(stream);
            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("Filedata") { FileName = fileName };
            fileContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
            return fileContent;
        }
    }
}

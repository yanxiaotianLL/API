using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Jil;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace myselfFast.Fund.API.Framework
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.MessageHandler
     *项目描述  ：
     *类名称    ：JsonpMediaTypeFormatter
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : JsonpMediaTypeFormatter
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017-04-07 12:02:50
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class JsonpMediaTypeFormatter : MediaTypeFormatter
    {
        private readonly Options mJilOptions; 
        public string Callback { get; private set; }
     
        public JsonpMediaTypeFormatter(string callback = null)
        {
            this.Callback = callback;
            
            mJilOptions = new Options(
                dateFormat: DateTimeFormat.ISO8601,
                excludeNulls: true,
                includeInherited: true);
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/jsonp"));
            SupportedEncodings.Add(new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true));
            SupportedEncodings.Add(new UnicodeEncoding(bigEndian: false, byteOrderMark: true, throwOnInvalidBytes: true));  
            
        }

        public override bool CanReadType(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            return true;
        }
        public override bool CanWriteType(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            return true;
        }
        public override Task<object> ReadFromStreamAsync(Type type, Stream readStream, System.Net.Http.HttpContent content, IFormatterLogger formatterLogger)
        {
            return Task.FromResult(this.DeserializeFromStream(type, readStream));
        }
        private object DeserializeFromStream(Type type, Stream readStream)
        {
            try
            {
                using (var reader = new StreamReader(readStream))
                {
                    MethodInfo method = typeof(JSON).GetMethod("Deserialize", new Type[] { typeof(TextReader), typeof(Options) });
                    MethodInfo generic = method.MakeGenericMethod(type);
                    return generic.Invoke(this, new object[] { reader, mJilOptions });
                }
            }
            catch
            {
                return null;
            }
        }
        public override Task WriteToStreamAsync(Type type, object value, Stream writeStream, System.Net.Http.HttpContent content, TransportContext transportContext)
        {
            var streamWriter = new StreamWriter(writeStream);
            streamWriter.Write(this.Callback + "(");
            JSON.Serialize(value, streamWriter, mJilOptions);
            streamWriter.Write(")");
            streamWriter.Flush();
            return Task.FromResult(writeStream);
        }
        //public override MediaTypeFormatter GetPerRequestFormatterInstance(Type type, HttpRequestMessage request, MediaTypeHeaderValue mediaType)
        //{

        //    string callback;
        //    //if (request.GetQueryNameValuePairs().ToDictionary(pair => pair.Key,
        //    //     pair => pair.Value).TryGetValue("callback", out callback))
        //    //{
        //    //    return new JsonpMediaTypeFormatter(callback);
        //    //}
        //    if (request.Method != HttpMethod.Get)
        //    {
        //        return this;
        //    }
        //    return this;
        //}
    }
}

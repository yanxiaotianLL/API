using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace myselfFast.Fund.API.Framework.MessageHandler
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
      public class JsonpMediaTypeFormatter : JsonMediaTypeFormatter
    {
        public string Callback { get; private set; }
     
        public JsonpMediaTypeFormatter(string callback = null)
        {
            this.Callback = callback;
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/jsonp"));
            
        }
     
       public override Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
       {
           if (string.IsNullOrEmpty(this.Callback))
           {
               return base.WriteToStreamAsync(type, value, writeStream, content, transportContext);
           }
           try
           {
               this.WriteToStream(type, value, writeStream, content);
               return Task.FromResult<AsyncVoid>(new AsyncVoid());
           }
           catch (Exception exception)
           {
               TaskCompletionSource<AsyncVoid> source = new TaskCompletionSource<AsyncVoid>();
              source.SetException(exception);
               return source.Task;
           }
       }
    
       private void WriteToStream(Type type, object value, Stream writeStream, HttpContent content)
       {
           //this.SerializerSettings.DefaultValueHandling = DefaultValueHandling.Ignore;
           //this.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
           //this.UseDataContractJsonSerializer = false;
           IsoDateTimeConverter timeFormat = new IsoDateTimeConverter();
           timeFormat.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
           this.SerializerSettings.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;
           JsonSerializer serializer = JsonSerializer.Create(this.SerializerSettings);
           
          using(StreamWriter streamWriter = new StreamWriter(writeStream, this.SupportedEncodings.First()))
           using (JsonTextWriter jsonTextWriter = new JsonTextWriter(streamWriter) { CloseOutput = false })
           {
               jsonTextWriter.WriteRaw(this.Callback + "(");
               jsonTextWriter.WriteRaw(JsonConvert.SerializeObject(value,timeFormat));
              //serializer.Serialize(jsonTextWriter, value);
               jsonTextWriter.WriteRaw(")");

               
           }
       }
    
       //public override MediaTypeFormatter GetPerRequestFormatterInstance(Type type, HttpRequestMessage request, MediaTypeHeaderValue mediaType)
       //{
       //   if (request.Method != HttpMethod.Get)
       //    {
       //        return this;
       //    }
       //    string callback;
       //    if (request.GetQueryNameValuePairs().ToDictionary(pair => pair.Key, 
       //         pair => pair.Value).TryGetValue("callback", out callback))
       //   {
       //        return new JsonpMediaTypeFormatter(callback);
       //    }
       //    return this;
       //}
    
      [StructLayout(LayoutKind.Sequential, Size = 1)]
       private struct AsyncVoid
       {}
   }
}

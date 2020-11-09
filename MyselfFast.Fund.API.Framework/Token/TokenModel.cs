using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.Token
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Token
     *项目描述  ：Token 存储对象
     *类名称    ：TokenModel
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : TokenModel
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/16 21:56:18
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [JsonObject(MemberSerialization.OptIn)]
    public  class TokenModel
    {
        //[JsonProperty]
        //public string ClientId { get; set; }
        [JsonProperty]
        public string Access_Token { get; set; }
        [JsonProperty]
        public int Expires_In { get; set; }
        //[JsonProperty]
        //public int Fesid { get; set; }
         [JsonProperty]
        public DateTime CreateTime { get; set; }
        [JsonProperty]
         public string OpenId { get; set; }
        public string SessionKey { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserName { get; set; }
        public string DepartName { get; set; }
        public int AdminId { get; set; }
        //[JsonProperty]
        //public TokenType Token_Type { get; set; } 
        //public string ContentKey { get; set; }
       
        //public bool IsUseContentKey { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.ClientCredentials
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.ClientCredentials
     *项目描述  ：
     *类名称    ：ClientCredentialsModel
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ClientCredentialsModel
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/16 23:41:49
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public   class ClientCredentialsModel
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        /// <summary>
        /// 用于内容加密
        /// </summary>;
        public string ContentKey { get; set; }
        /// <summary>
        /// 发送内容是否使用密文
        /// </summary>
        public bool IsUseContentKey { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.Models
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Models
     *项目描述  ：用户获取Token的请求参数
     *类名称    ：TokenRequestModel
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : TokenRequestModel
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/17 0:46:27
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class TokenRequest
    {
        public string appkey { get; set; }
        public string appsecret { get; set; }
    }
}

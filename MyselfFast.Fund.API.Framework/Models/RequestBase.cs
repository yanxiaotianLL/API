using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.Models
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Models
     *项目描述  ：API接口统一请求实体
     *类名称    ：ApiRequestModel
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ApiRequestModel
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/16 21:41:35
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class RequestBase<T> where T : new()
    {
        public string methodname { get; set; }
        public string tokenkey { get; set; }
        public string format { get; set; }
        public string jsonParam { get; set; }
        public string Sign { get; set; }
        public string user_account { get; set; }
      

    }
}

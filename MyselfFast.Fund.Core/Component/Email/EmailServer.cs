using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.Email
{
    /**********************************************************************************
     *项目名称	：FS.Component.Email
     *项目描述  ：
     *类名称    ：EmailServer
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : EmailServer
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/11 19:50:42
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class EmailServer : IConfiguration
    {
        public string EmailFromAddress { get; set; }
        public string EmailFromPassword{get;set;}
        public string EmailHostIP { get; set; }
        public string EmailHostPort { get; set; }
       
    }
}

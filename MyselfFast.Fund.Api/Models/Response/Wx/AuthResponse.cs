using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myselfFast.Fund.Api.Models.Response.Wx
{
    /**********************************************************************************
	 *项目名称	：myselfFast.Fund.Api.Models.Response.Wx
	 *项目描述  ：
	 *类名称    ：AuthResponse
	 *版本号    ：v1.0.0
	 *机器名称  ：LIUYONG-PC
	 *项目名称  : AuthResponse
	 *CLR版本   : 4.0.30319.42000
	 *作者      ：liu.yong
	 *创建时间  : 2018-06-11 10:40:43
	 *------------------------------------变更记录--------------------------------------
	 *变更描述  :
	 *变更作者  :
	 *变更时间  :
	***********************************************************************************/

    public class AuthResponse
    {
        public bool IsBind { get; set; }
        public string Ticket { get; set; }
        public string SessionKey { get; set; }
        public string UserName { get; set; }
        public string DepartName { get; set; }
    }
}
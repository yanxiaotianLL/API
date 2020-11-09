using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace myselfFast.Fund.Api.Models.Request.Test
{
    /**********************************************************************************
	 *项目名称	：myselfFast.Fund.Api.Models.Request.Test
	 *项目描述  ：
	 *类名称    ：TestRequest
	 *版本号    ：v1.0.0
	 *机器名称  ：LIUYONG-PC
	 *项目名称  : TestRequest
	 *CLR版本   : 4.0.30319.42000
	 *作者      ：liu.yong
	 *创建时间  : 2018-01-28 18:12:56
	 *------------------------------------变更记录--------------------------------------
	 *变更描述  :
	 *变更作者  :
	 *变更时间  :
	***********************************************************************************/

    public class TestRequest
    {
        [Required(ErrorMessage = "名字不能为空。")]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
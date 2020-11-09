using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myselfFast.Fund.Api.Models.Response.Wx
{
    /**********************************************************************************
	 *项目名称	：myselfFast.Fund.Api.Models.Response.Wx
	 *项目描述  ：
	 *类名称    ：GetSignListResponse
	 *版本号    ：v1.0.0
	 *机器名称  ：LIUYONG-PC
	 *项目名称  : GetSignListResponse
	 *CLR版本   : 4.0.30319.42000
	 *作者      ：liu.yong
	 *创建时间  : 2018-06-19 9:55:27
	 *------------------------------------变更记录--------------------------------------
	 *变更描述  :
	 *变更作者  :
	 *变更时间  :
	***********************************************************************************/

    public class GetSignListResponse
    {
        public string Address { get; set; }
        /// <summary>
        /// [BUSI_CUST_NO]
        /// </summary>
        public string BUSI_CUST_NO { get; set; }

        /// <summary>
        /// [BUSI_CUST_NAME]
        /// </summary>
        public string BUSI_CUST_NAME { get; set; }
        /// <summary>
        /// [ACCE_NO]
        /// </summary>
        public string ACCE_NO { get; set; }

        /// <summary>
        /// [ACCE_NAME]
        /// </summary>
        public string ACCE_NAME { get; set; }
        /// <summary>
        /// [UNIT_NO]
        /// </summary>
        public string UNIT_NO { get; set; }
        /// <summary>
        /// [UNIT_NAME_PRINT]
        /// </summary>
        public string UNIT_NAME_PRINT { get; set; }
        public string UnitRate { get; set; }
    }
}
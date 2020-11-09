using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Component.Logging
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Component.Logging
     *项目描述  ：
     *类名称    ：ApiInputLogEntity
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ApiInputLogEntity
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-24 22:04:48
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 本机服务
    /// </summary>
    public  class ApiInputLogEntity
    {
        /// <summary>
        /// 请求属于那个子系统或者那个域
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// 请求那个控制器模块
        /// </summary>
        public string Controller { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// 帐号类型
        /// </summary>
        public string AccountType { get; set; }
        /// <summary>
        /// 企业账号
        /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// 请求方法
        /// </summary>
        public string HttpMethod { get; set; }
        /// <summary>
        /// 请求地址
        /// </summary>
        public string Sign { get; set; }
        /// <summary>
        /// 请求信息的全路径
        /// </summary>
        public string OriginalString { get; set; }
        /// <summary>
        /// ip地址
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 请求时间
        /// </summary>
        public DateTime RequestTime { get; set; }
        /// <summary>
        /// 请求参数
        /// </summary>
        public string RequestContent { get; set; }
        /// <summary>
        /// 响应内容
        /// </summary>
        public string ResponseContent { get; set; }
        /// <summary>
        /// 请求耗时
        /// </summary>
        public int Expire { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Region:{0}\r\n", Region));
            sb.Append(string.Format("Controller:{0}\r\n", Controller));
            sb.Append(string.Format("AccountType:{0}\r\n", AccountType));
            sb.Append(string.Format("AccountName:{0}\r\n", AccountName));
            sb.Append(string.Format("HttpMethod:{0}\r\n", HttpMethod));
            sb.Append(string.Format("Sign:{0}\r\n", Sign));
            sb.Append(string.Format("OriginalString:{0}\r\n", OriginalString));
            sb.Append(string.Format("Ip:{0}\r\n", Ip));
            sb.Append(string.Format("RequestTime:{0}\r\n", RequestTime));
            sb.Append(string.Format("RequestContent:{0}\r\n", RequestContent));

            sb.Append(string.Format("ResponseContent:{0}\r\n", ResponseContent));
            sb.Append(string.Format("Expire:{0}\r\n", Expire));
          
            return sb.ToString();
        }


    }
}

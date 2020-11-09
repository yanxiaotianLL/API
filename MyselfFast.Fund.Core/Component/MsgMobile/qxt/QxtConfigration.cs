using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.MsgMobile.qxt
{
    /**********************************************************************************
     *项目名称	：FS.Component.MsgMobile.qxt
     *项目描述  ：
     *类名称    ：QxtConfigration
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : QxtConfigration
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/2/17 14:51:56
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 鸿联95短信接口（供应商提供）配置项目
    /// </summary>
    public  class QxtConfigration
    {
        /// <summary>
        /// 短信服务地址
        /// </summary>
        public string ServerUrl { get; set; }
        /// <summary>
        /// 供应商分配ID
        /// </summary>
        public string TID { get; set; }
        /// <summary>
        /// 用户帐号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }


    }
}

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
     *类名称    ：SendRequestModel
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : SendRequestModel
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/2/17 15:01:05
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 发送消息请求体
    /// </summary>
    public  class SendRequestModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 要发送的手机号码最多50个，以‘，’分隔
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// /短信内容
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 企业id
        /// </summary>
        public string epid { get; set; }
        /// <summary>
        /// 备用，可不必填写
        /// </summary>
        public string linkid { get; set; }
        /// <summary>
        /// 扩展小号
        /// </summary>
        public string subcode { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.MsgMobile
{
    /**********************************************************************************
     *项目名称	：FS.Component.MsgMobile
     *项目描述  ：
     *类名称    ：ISendMsg
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ISendMsg
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/11 14:28:55
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/


    public interface ISendMsgHandler 
    {
        #region 发送到144服务器的发送短信方法
        /// <summary>
        /// 发送到144服务器的发送短信方法
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        bool SendMsg(string phone, string content);

        bool SendMsg(string phone, string content, ref string msg);

        bool SendMsg(string[] phones, string content);
        bool SendMsg(string[] phones, string content, ref string msg);
        #endregion

        #region 发送到DB服务器的发送短信方法
        [Obsolete("短信供应商更换，请不要再使用此方法进行短息发送。")]
        bool SendMsg89(string phone, string content);
        [Obsolete("短信供应商更换，请不要再使用此方法进行短息发送。")]
        bool SendMsg89(string phone, string content, ref string msg); 
        #endregion
       
    }
}

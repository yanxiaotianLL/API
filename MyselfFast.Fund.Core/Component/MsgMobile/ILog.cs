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
     *接口名称  ：ILog
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ILog
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/11 23:02:27
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public interface ILog
    {
        void CreateMsgLog(string phone, string LinkId, string content, string err);
    }
}

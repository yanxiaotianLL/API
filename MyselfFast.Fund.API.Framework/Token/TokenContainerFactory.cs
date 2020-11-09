using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.Token
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Token
     *项目描述  ：
     *类名称    ：TokenContainerFactory
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : TokenContainerFactory
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/16 22:12:41
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public   class TokenContainerFactory
    {
        public static ITokenContainer GetTokenContainer()
        {
            return DefaultTokenContainer.CreateInstance();
        }
    }
}

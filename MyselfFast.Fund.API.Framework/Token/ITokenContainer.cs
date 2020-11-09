using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.Token
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Token
     *项目描述  ：存放token的容器接口
     *类名称    ：ITokenContainer
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ITokenContainer
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/16 21:53:38
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  interface ITokenContainer
    {
        /// <summary>
        /// 添加Token
        /// </summary>
        /// <returns></returns>
        void AddToken(TokenModel tokenModel);
        /// <summary>
        /// 删除Token
        /// </summary>
        /// <returns></returns>
        void RemoveByToken(string token);
        /// <summary>
        /// 根据ClientID获取Token对象，无则返回Null
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        TokenModel GetTokenByClientId(string clientId);
        /// <summary>
        /// 根据token字符串获取token对象，无则返回Null
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        TokenModel GetTokenByValue(string token);
        /// <summary>
        /// 更新Token过期时间，再原有时间的基础上增加
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="expires"></param>
        /// <returns></returns>
        bool UpdateTokenExpiresByClientId(string clientId,int expires);
        /// <summary>
        /// 更新Token过期时间，再原有时间的基础上增加
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="expires"></param>
        /// <returns></returns>
        bool UpdateTokenExpiresByToken(string token, int expires);
        /// <summary>
        /// 获取目前Token对象的数量
        /// </summary>
        /// <returns></returns>
        int GetTokenCount();
    }
}

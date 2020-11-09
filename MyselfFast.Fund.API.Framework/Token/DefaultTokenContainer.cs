
using myselfFast.Component.Cache;
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
     *类名称    ：DefaultTokenContainer
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : DefaultTokenContainer
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/16 22:16:33
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class DefaultTokenContainer:ITokenContainer
    {
        /// <summary>
        /// 单例模式实现
        /// </summary>
        private DefaultTokenContainer() { }

        private volatile static DefaultTokenContainer _instance = null;

        private static readonly object lockHelper = new object();
        public static DefaultTokenContainer CreateInstance()
        {
            if (_instance == null)
            {
                lock (lockHelper)
                {
                    if (_instance == null)
                        _instance = new DefaultTokenContainer();
                }
            }
            return _instance;
        }

        /// <summary>
        /// Token存储对象
        /// </summary>
        private ICacheStorage cacheStroage = CacheProviderFactory.CreateCacheProvider(CacheType.InMemery);
        public void AddToken(TokenModel tokenModel)
        {
            cacheStroage.Set<TokenModel>(tokenModel.Access_Token,new CacheValue<TokenModel>(tokenModel, true));
        }

        public void RemoveByToken(string token)
        {
            cacheStroage.Delete(token);
        }

        public TokenModel GetTokenByClientId(string clientId)
        {
            var list = cacheStroage.GetCacheKeys();
            if (list != null && list.Count > 0)
            {
                foreach (var item in list)
                {
                    var tokenModel = this.GetTokenByValue(item);
                    if (tokenModel != null && tokenModel.OpenId == clientId)
                    {
                        return tokenModel;
                    }
                }
            }
            return null;
        }

        public TokenModel GetTokenByValue(string token)
        {
            var tokenModel = cacheStroage.Get<TokenModel>(token);
            return tokenModel == null || !tokenModel.HasValue ? null : tokenModel.Value;
        }

        public bool UpdateTokenExpiresByClientId(string clientId, int expires)
        {
            var tokenModel = this.GetTokenByClientId(clientId);
            tokenModel.Expires_In = tokenModel.Expires_In+expires;
            return true;
        }

        public int GetTokenCount()
        {
            return cacheStroage.GetCacheKeys().Count();
        }


        public bool UpdateTokenExpiresByToken(string token, int expires)
        {
            var tokenModel = this.GetTokenByValue(token);
            tokenModel.Expires_In = tokenModel.Expires_In+expires;
            return true;
        }
    }
}

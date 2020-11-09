
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Component.Cache.Redis
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Component.Cache.Redis
     *项目描述  ：
     *类名称    ：RedisFactoryProvider
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : RedisFactoryProvider
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-02-07 9:28:36
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class RedisFactoryProvider
    {
        public static ICacheManager GetCacheManager(string connectionString)
        {
            IRedisConnectionWrapper conncetionWrapper = RedisConnectionWrapper.CreateInstance(connectionString);
            ICacheManager cacheManger = new RedisCacheManager(conncetionWrapper,null);
            return cacheManger;
        }

    }
}

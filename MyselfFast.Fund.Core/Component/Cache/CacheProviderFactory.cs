using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.Cache
{
    /**********************************************************************************
     *项目名称	：FS.Component.Cache
     *项目描述  ：
     *类名称    ：CacheProviderFactory
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : CacheProviderFactory
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/16 22:30:51
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class CacheProviderFactory
    {
        public static ICacheStorage CreateCacheProvider(CacheType cacheType)
        {
            ICacheStorage cacheStorage = null;
            switch (cacheType)
            {
                case CacheType.InMemery:
                    return new DefaultCacheAdapter();
                    break;
                case CacheType.Memcached:
                    return null;
                    break;
                default:
                    return new DefaultCacheAdapter();
                    break;
            }
        }
    }
}

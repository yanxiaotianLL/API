
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace myselfFast.Component.Cache
{
    /// <summary>
    /// 本地缓存
    /// </summary>
    public  class DefaultCacheAdapter:ICacheStorage
    {
       
        private static System.Web.Caching.Cache cache;
        //private static TimeSpan timeSpan = new TimeSpan(
        //    Settings.Default.DefaultCacheDuration_Days,
        //    Settings.Default.DefaultCacheDuration_Hours,
        //    Settings.Default.DefaultCacheDuration_Minutes, 0);
        private static TimeSpan timeSpan = new TimeSpan(0,0,30, 0);

        static DefaultCacheAdapter()
        {
            cache = HttpContext.Current.Cache;
        }

        public CacheValue<T> Get<T>(string cache_key)
        {
            try
            {
                return (CacheValue<T>)cache.Get(cache_key);
            }
            catch{
                return null;
            }
        }

        public List<string> GetCacheKeys()
        {
            List<string> keys = new List<string>();
            IDictionaryEnumerator ca = cache.GetEnumerator();
            while (ca.MoveNext())
            {
                keys.Add(ca.Key.ToString());
            }
            return keys;
        }

        public void Set<T>(string cache_key, CacheValue<T> cache_object)
        {
            Set<T>(cache_key, cache_object, timeSpan);
        }

        public void Set<T>(string cache_key, CacheValue<T> cache_object, DateTime expiration)
        {
            Set(cache_key, cache_object, expiration, CacheItemPriority.Normal);
        }

        public void Set<T>(string cache_key, CacheValue<T> cache_object, TimeSpan expiration)
        {
            Set<T>(cache_key, cache_object, expiration, CacheItemPriority.Normal);
        }

        public void Set<T>(string cache_key, CacheValue<T> cache_object, DateTime expiration, CacheItemPriority priority)
        {
            cache.Insert(cache_key, cache_object, null, expiration, System.Web.Caching.Cache.NoSlidingExpiration, priority, null);
        }

        public void Set<T>(string cache_key, CacheValue<T> cache_object, TimeSpan expiration, CacheItemPriority priority)
        {
            cache.Insert(cache_key, cache_object, null, System.Web.Caching.Cache.NoAbsoluteExpiration, expiration, priority, null);
        }

        public void Delete(string cache_key)
        {
            if (Exists(cache_key))
                cache.Remove(cache_key);
        }

        public bool Exists(string cache_key)
        {
            if (cache[cache_key] != null)
                return true;
            else
                return false;
        }

        public void Flush()
        {
            foreach (string s in GetCacheKeys())
            {
                Delete(s);
            }
        }



        public void Dispose()
        {
           
        }
    }
}

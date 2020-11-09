using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;

namespace myselfFast.Component.Cache
{
    /// <summary>
    /// 缓存使用统一功能接口
    /// </summary>
    public  interface ICacheStorage:IDisposable
    {
        /// <summary>
        ///01. 根据键值获取缓存值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cache_key"></param>
        /// <returns></returns>
        CacheValue<T> Get<T>(string cache_key);
        /// <summary>
        /// 02.获取所有的键值集合
        /// </summary>
        /// <returns></returns>
        List<string> GetCacheKeys();
        /// <summary>
        /// 03.设置缓存键和值，默认永不过期
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cache_key"></param>
        /// <param name="cache_object"></param>
        void Set<T>(string cache_key, CacheValue<T> cache_object);
        /// <summary>
        /// 04.设置缓存键值并指定过期时间
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cache_key"></param>
        /// <param name="cache_object"></param>
        /// <param name="expiration">到某一个时间点过期</param>
        void Set<T>(string cache_key, CacheValue<T> cache_object, DateTime expiration);
        /// <summary>
        /// 05.设置缓存键值并设置过多上时间过期，时间单位TimeSpan
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cache_key"></param>
        /// <param name="cache_object"></param>
        /// <param name="expiration"></param>
        void Set<T>(string cache_key, CacheValue<T> cache_object, TimeSpan expiration);
        /// <summary>
        /// 06.设置缓存键值和过期时间节点，以及缓存对象优先级
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cache_key"></param>
        /// <param name="cache_object"></param>
        /// <param name="expiration"></param>
        /// <param name="priority"></param>
        void Set<T>(string cache_key, CacheValue<T> cache_object, DateTime expiration, CacheItemPriority priority);
        /// <summary>
        /// 07.设置缓存键值并设置过多上时间过期，时间单位TimeSpan,和优先级
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cache_key"></param>
        /// <param name="cache_object"></param>
        /// <param name="expiration"></param>
        /// <param name="priority"></param>
        void Set<T>(string cache_key, CacheValue<T> cache_object, TimeSpan expiration, CacheItemPriority priority);
        /// <summary>
        /// 08.根据键值删除缓存项
        /// </summary>
        /// <param name="cache_key"></param>
        void Delete(string cache_key);
        /// <summary>
        /// 09.根据键值判断缓存是否存在
        /// </summary>
        /// <param name="cache_key"></param>
        /// <returns></returns>
        bool Exists(string cache_key);
        /// <summary>
        /// 10.清理缓存
        /// </summary>
        void Flush();
    }
}

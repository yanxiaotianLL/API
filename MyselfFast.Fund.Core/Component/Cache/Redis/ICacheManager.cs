using System;

namespace myselfFast.Fund.Core.Component.Cache.Redis
{
    /// <summary>
    /// Cache manager interface
    /// 缓存使用管理统一接口
    /// </summary>
    public interface ICacheManager : IDisposable
    {
        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// 获取缓存对象
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="key">The key of the value to get.</param>
        /// <returns>The value associated with the specified key.</returns>
        T Get<T>(string key);

        /// <summary>
        /// Adds the specified key and object to the cache.
        /// 设置缓存对象
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="data">Data</param>
        /// <param name="cacheTime">Cache time</param>
        void Set(string key, object data, int cacheTime);

        /// <summary>
        /// Gets a value indicating whether the value associated with the specified key is cached
        /// 判断对象键值缓存对象是否存在
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>Result</returns>
        bool IsSet(string key);

        /// <summary>
        /// Removes the value with the specified key from the cache
        /// 缓存移除
        /// </summary>
        /// <param name="key">/key</param>
        void Remove(string key);

        /// <summary>
        /// Removes items by pattern
        /// 按照键值正则删除
        /// </summary>
        /// <param name="pattern">pattern</param>
        void RemoveByPattern(string pattern);

        /// <summary>
        /// Clear all cache data
        /// 清除所有缓存
        /// </summary>
        void Clear();
    }
}

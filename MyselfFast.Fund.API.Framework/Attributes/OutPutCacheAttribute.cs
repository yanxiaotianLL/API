using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.Attributes{
    
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Attributes
     *项目描述  ：
     *类名称    ：OutPutCache
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : OutPutCache
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/11 13:42:24
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 用于缓存输出
    /// </summary>
    public class OutPutCacheAttribute : Attribute
    {
        private bool isJsonParam = false;
        private CacheType cacheType = CacheType.AbsoluteExpiration;
        private int expiration = 30;
             
        /// <summary>
        /// 缓存依赖参数，必须是如参数为不可为空的类型
        /// </summary>
        public string[] Parameters { get; set; }
        /// <summary>
        /// 缓存过期时间
        /// </summary>
        public int Expiration {
            get { return expiration; }
            set { expiration = value; }
        }
        /// <summary>
        /// 缓存类型
        /// </summary>
        public CacheType CacheType {
            get { return cacheType; }
            set { cacheType = value; } }
        /// <summary>
        /// 根据输入参数缓存
        /// </summary>
        public bool IsJsonParam {
            get { return isJsonParam; }
            set { isJsonParam = value; }}
    }

    public enum CacheType
    {
        AbsoluteExpiration = 0,
        SlidingExpiration = 1
    }
}

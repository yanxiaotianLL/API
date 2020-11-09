using myselfFast.Component.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using myselfFast.Fund.Core.Common.Extensions;


namespace myselfFast.Fund.API.Framework.Attributes
{
    /**********************************************************************************
     *项目名称	：FS.Core.API.Attributes
     *项目描述  ：
     *类名称    ：OutPutCacheFilterAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : OutPutCacheFilterAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/15 2:48:17
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 输出缓存检查
    /// </summary>
    public   class OutPutCacheFilterAttribute : System.Web.Http.Filters.ActionFilterAttribute
    {
        private string cachePrefix = "myselfSERVICEOUTCACHE_";
        private string cacheGlobalCache;
        //缓存校验
        public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if (actionContext != null && actionContext.Request.Method != HttpMethod.Get)
            {
                base.OnActionExecuting(actionContext);
                return;
            }
            OutPutCacheAttribute cacheAttribute = null;
            bool isUseCache = IsUseOutCache(actionContext,ref cacheAttribute);
            //配置了缓存使用规则
            if (isUseCache)
            {
                //计算缓存键值
                string cacheKey = GetCacheKey(actionContext, cacheAttribute);
                cacheGlobalCache = cacheKey;
                //获取缓存结果
                ICacheStorage cacheStorage = CacheProviderFactory.CreateCacheProvider(myselfFast.Component.Cache.CacheType.InMemery);
                if (cacheStorage.Exists(cacheKey))
                {
                    var cacheResult = cacheStorage.Get<byte[]>(cacheKey);
                    actionContext.Response = actionContext.Request.CreateResponse();
                    actionContext.Response.Content = new ByteArrayContent(cacheResult.Value);
                }
            }

            base.OnActionExecuting(actionContext);
        }
        public override void OnActionExecuted(System.Web.Http.Filters.HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext != null && actionExecutedContext.Request.Method != HttpMethod.Get)
            {
                base.OnActionExecuted(actionExecutedContext);
                return;
            }
             OutPutCacheAttribute cacheAttribute = null;
            bool isUseCache = IsUseOutCache(actionExecutedContext.ActionContext,ref cacheAttribute);
            //配置了缓存使用规则
            if (isUseCache)
            {
                //计算缓存键值
                string cacheKey = GetCacheKey(actionExecutedContext.ActionContext, cacheAttribute);
                //获取缓存
                ICacheStorage cacheStorage = CacheProviderFactory.CreateCacheProvider(myselfFast.Component.Cache.CacheType.InMemery);
                var content =  actionExecutedContext.ActionContext.Response.Content.ReadAsByteArrayAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                if (content != null && content.Length>0)
                {
                    //换取缓存过期方式
                    if (cacheAttribute.CacheType == CacheType.AbsoluteExpiration)
                    {
                        cacheStorage.Set<byte[]>(cacheKey, new CacheValue<byte[]>(content, true), DateTime.Now.AddMinutes(cacheAttribute.Expiration));
                    }
                    else
                    {
                        cacheStorage.Set<byte[]>(cacheKey, new CacheValue<byte[]>(content, true), TimeSpan.FromMinutes(cacheAttribute.Expiration));
                    }
                }
            }

         
            base.OnActionExecuted(actionExecutedContext);
        }
        /// <summary>
        /// 计算缓存键值
        /// </summary>
        /// <param name="actionContext"></param>
        /// <param name="cacheAttribute"></param>
        /// <returns></returns>
        private string GetCacheKey(System.Web.Http.Controllers.HttpActionContext actionContext, OutPutCacheAttribute cacheAttribute)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0}_{1}_{2}_", cachePrefix,actionContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                actionContext.ActionDescriptor.ActionName));
            //判断是否配置了使用jsonparam作为缓存参考参数
            if (cacheAttribute.IsJsonParam)
            {
                sb.Append(GetKeyByJsonParm(actionContext));

            }
            //配置了使用自定义参数作为缓存参考参数
            else if (cacheAttribute.Parameters != null && cacheAttribute.Parameters.Any())
            {
                sb.Append(GetKeyByMatchParamter(actionContext,cacheAttribute.Parameters));
            }
            //所有情况缓存
            return sb.ToString();
        }
        /// <summary>
        /// 检查是否配置了缓存
        /// </summary>
        /// <returns></returns>
        private bool IsUseOutCache(System.Web.Http.Controllers.HttpActionContext actionContext,ref OutPutCacheAttribute cacheAttribute)
        {
            var actionDescripter = actionContext.Request.GetActionDescriptor();
            var cache = actionDescripter.GetCustomAttributes<OutPutCacheAttribute>();
            if (cache.Any())
            {
                 cacheAttribute = cache.First<OutPutCacheAttribute>();
                 return true;
            }
            
            return false;

        }
        /// <summary>
        /// 根据用户自定义参数使用缓存
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        private String GetKeyByMatchParamter(System.Web.Http.Controllers.HttpActionContext actionContext,string[] parameters)
        {
            Dictionary<string, string> dicParamters = new Dictionary<string, string>();
            StringBuilder sb = new StringBuilder();

            //获取请求action的参数值
            string jsonParmters = actionContext.Request.Properties["Model_Paramters"].ToString();
            var jsonData = LitJson2.JsonMapper.ToObject(jsonParmters);

            Array.Sort(parameters);
            foreach (var item in parameters)
            {
                
                 var param = jsonData[item];
                 if (param != null)
                 {
                     sb.Append(string.Format("{0}_{1}_", item, param));
                 }
                
            }
            return sb.ToString();
          
        }
        /// <summary>
        /// 使用jsonparamter用户输入缓存
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        private string GetKeyByJsonParm(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            return
                actionContext.Request.Properties["Model_Paramters"].ToString()
                    .Replace('{', '_')
                    .Replace('}', '_')
                    .Replace(':', '_')
                    .Replace(',', '_')
                    .Replace('[', '_')
                    .Replace(']', '_');
        }
    }
}

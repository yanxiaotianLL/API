using myselfFast.Fund.Core.Component.Cache.Redis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Test.Compoent.Cache.Redis
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Test.Compoent.Cache.Redis
     *项目描述  ：
     *类名称    ：RedisTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : RedisTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-02-07 13:02:57
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public  class RedisTest
    {
        private string redisConnection;
        private string key = "testredis";

        private ICacheManager redis;
        [TestInitialize]
        public void Init()
        {
            //redisConnection = "10.0.15.34,password=yangyang2015";
            redisConnection = "192.168.3.220:6379,password=yangyang2015";
            redis = RedisFactoryProvider.GetCacheManager(redisConnection);
        }
        [TestMethod]
        public void TestAdd()
        {
          
            redis.Set(key, "liuyong", 5);
            
        }
         [TestMethod]
        public void TestGet()
        {
           string str =  redis.Get<string>(key);
           Assert.AreEqual("liuyong", str);
        }
    }
}

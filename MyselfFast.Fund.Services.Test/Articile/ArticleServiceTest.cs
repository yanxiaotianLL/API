using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Core.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Test.Articile
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Services.Test.Articile
     *项目描述  ：
     *类名称    ：ArticleServiceTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ArticleServiceTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-27 17:15:07
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public  class ArticleServiceTest
    {
        [TestInitialize]
        public void Init()
        {
           
            EngineContext.Initialize(true);
        }
        [TestMethod]
        public void TestEf()
        {
           //ILoggerProviderFactory factory = EngineContext.Current.Resolve<ILoggerProviderFactory>();
           //IArticle articleService = EngineContext.Current.Resolve<IArticle>();
           //IBaseService<T_Article> articlesService = EngineContext.Current.Resolve<IBaseService<T_Article>>();
           //int[] ids = { 2,5};
           //int count = articlesService.DeleteEntitysByIds(ids);
        }
    }
}

using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Fund.Services.Banner;
using myselfFast.Fund.Services.DTO.Request.Banner;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Test.Banner
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Services.Test.Banner
     *项目描述  ：
     *类名称    ：BannerTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : BannerTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-27 17:15:07
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public  class BannerTest
    {

        private IBannerHoleImgDataService _BannerHoleImgDataService;
        [TestInitialize]
        public void Init()
        {
           
            EngineContext.Initialize(true);
            _BannerHoleImgDataService = EngineContext.Current.Resolve<IBannerHoleImgDataService>();
        }
       [TestMethod]
        public void TestGetSysBannerList()
        {
            SelectBannerImgListRequestModel model = new SelectBannerImgListRequestModel( );
            model.Id = 0;
            var res = _BannerHoleImgDataService.GetBannerImgDataList(model,1,10);
            Assert.IsNotNull(res);
        }
    }
}

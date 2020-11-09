using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Fund.Services.Admin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Test.Admin
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Services.Test.Admin
     *项目描述  ：
     *类名称    ：AdminAccountServiceTest
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : AdminAccountServiceTest
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-29 14:36:31
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [TestClass]
    public  class AdminAccountServiceTest
    {
        private IAdminAccountService adminAccountService;
        [TestInitialize]
        public void Init()
        {

            EngineContext.Initialize(true);
            adminAccountService = EngineContext.Current.Resolve<IAdminAccountService>();
        }
        [TestMethod]
        public void TestGetRoles()
        {
            var roles = adminAccountService.GetRoles(3);
            Assert.IsNotNull(roles);
        }
        [TestMethod]
        public void TestGetMenus()
        {
            var menus = adminAccountService.GetMenus(3);
            Assert.IsNotNull(menus);
        }
    }
}

using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Data;
using myselfFast.Component.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Services.Admin
     *项目描述  ：
     *类名称    ：AdminPasswordSignHistoryService
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : AdminPasswordSignHistoryService
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-04-19 14:00:47
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class AdminPasswordSignHistoryService : BaseService<T_Admin_PasswordSignHistory>, IAdminPasswordSignHistoryService
    {
        private const string cacheKey = "TADMINPASSWORDSIGNHISTORYCACHEKEY_";
        private IRepository<T_Admin_PasswordSignHistory> tEntityResponsity;
        private ICacheStorage cacheStoreService;
        public AdminPasswordSignHistoryService(IRepository<T_Admin_PasswordSignHistory> tEntityResponsity, 
            IDataProvider _dataProvider, 
            IDbContext _dbContext,
            ICacheStorage cacheStoreService) :
            base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.tEntityResponsity = tEntityResponsity;
            this.cacheStoreService = cacheStoreService;
        }
        public void Add(T_Admin_PasswordSignHistory model)
        {
            this.tEntityResponsity.Insert(model);
            cacheStoreService.Set<T_Admin_PasswordSignHistory>(cacheKey + model.Sign, new CacheValue<T_Admin_PasswordSignHistory>(model, true),TimeSpan.FromDays(1));
        }

        public T_Admin_PasswordSignHistory GetHistory(string sign)
        {
            var history = cacheStoreService.Get<T_Admin_PasswordSignHistory>(cacheKey + sign);
            if (history != null && history.HasValue)
            {
                return history.Value;
            }
            DateTime dt = DateTime.Now.AddDays(-1);
            return tEntityResponsity.TableNoTracking.Where(w => w.Sign == sign && w.CreateTime >= dt && w.IsDelete == false).FirstOrDefault();
        }
    }
}

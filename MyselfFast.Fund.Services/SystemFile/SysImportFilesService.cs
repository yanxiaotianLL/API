using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Core.Common.Extensions;
using myselfFast.Fund.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Common;
using myselfFast.Fund.Core.Domain.Hukou;
 
using myselfFast.Fund.Core.Domain.ExportImport;
using myselfFast.Fund.Core.Domain;
using myselfFast.Fund.Core.Component.Logging;
using myselfFast.Component.Logging;
using System.Linq.Expressions;
namespace myselfFast.Fund.Services.SystemFile
{
    public class SysImportFilesService : BaseService<T_Sys_ImportFiles>, ISysImportFilesService
    {
        private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;

        public SysImportFilesService(IRepository<T_Sys_ImportFiles> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext,
            ILoggerProviderFactory iLoggerProviderFactory)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
        }

        public JqGridResult<T_Sys_ImportFiles> GetList(T_Admin_Account account, string begintime, string endtime, int rows, int page)
        {
            DateTime time = DateTime.Now.Date.AddDays(-7);
            Expression<Func<T_Sys_ImportFiles, bool>> whereexp = t => t.CreateTime >= time;
            DateTime begin = new DateTime(), end = new DateTime();
            if (!string.IsNullOrWhiteSpace(begintime))
            {
                begin= Utils.ToDateTime(begintime);
            }
            if (!string.IsNullOrWhiteSpace(endtime))
            {
                end = Utils.ToDateTime(endtime);
                end = end.AddHours(24);
            }
            
            IPagedList<T_Sys_ImportFiles> pagedList = new PagedList<T_Sys_ImportFiles>(_tEntityResponsity.Table.Where(whereexp)
                //.Where(t=>t.Type==10)
                .WhereIf(w => w.UserId == account.Id, account.UserName != "administrator")
                                           .WhereIf(t => t.CreateTime >= begin, !string.IsNullOrWhiteSpace(begintime))
                                           .WhereIf(t => t.CreateTime < end, !string.IsNullOrWhiteSpace(endtime)).OrderByDescending(t => t.CreateTime), page, rows);

            return JqGridResult<T_Sys_ImportFiles>.Build(pagedList);
        }
    }
}

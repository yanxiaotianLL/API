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
namespace myselfFast.Fund.Services.SystemFile
{
    public class SysExportFilesService : BaseService<T_Sys_ExportFiles>, ISysExportFilesService
    {
        private ILoggerProviderFactory iLoggerProviderFactory;
        private readonly ILogger _logger = null;

        public SysExportFilesService(IRepository<T_Sys_ExportFiles> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext,
            ILoggerProviderFactory iLoggerProviderFactory)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {
            this.iLoggerProviderFactory = iLoggerProviderFactory;
            _logger = this.iLoggerProviderFactory.CreateDefaultLogger();
        }
        public JqGridResult<T_Sys_ExportFiles> GetExportFilesList(T_Admin_Account account, int rows, int page)
        {

            DateTime timeBefore7 = DateTime.Now.AddDays(-7);
            IPagedList<T_Sys_ExportFiles> pagedList = new PagedList<T_Sys_ExportFiles>(_tEntityResponsity.Table
                .Where(t => t.CreateTime >= timeBefore7 && t.IsDelete == 0)
                .WhereIf(w => w.UserId == account.Id, account.UserName != "administrator")
                .OrderByDescending(t => t.CreateTime), page, rows);


            return JqGridResult<T_Sys_ExportFiles>.Build(pagedList);
        }

        public string DeleteExportFileById(int id)
        {
            string result = string.Empty;
            try
            {
                T_Sys_ExportFiles f = new T_Sys_ExportFiles();
                f = _tEntityResponsity.GetById(id);
                f.IsDelete = 1;
                 _tEntityResponsity.Update(f);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
    }
}

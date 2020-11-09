using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Domain.ExportImport;
using myselfFast.Fund.Services.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.SystemFile
{
    public interface ISysImportFilesService : IBaseService<T_Sys_ImportFiles>
    {
        JqGridResult<T_Sys_ImportFiles> GetList(T_Admin_Account account, string begintime, string endtime, int rows, int page);
    }
}

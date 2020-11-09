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
    public interface ISysExportFilesService : IBaseService<T_Sys_ExportFiles>
    {
        JqGridResult<T_Sys_ExportFiles> GetExportFilesList(T_Admin_Account account, int rows, int page);

        string DeleteExportFileById(int id);
    }
}

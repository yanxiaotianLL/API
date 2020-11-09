using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Domain.ExportImport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.HukouS
{
    public interface IImportFileImpService : IBaseService<T_Sys_ImportFiles>
    {
        string InsertAndUploadSystemImportFile(string FileNameOld, string filepath, T_Admin_Account account);
    }
}

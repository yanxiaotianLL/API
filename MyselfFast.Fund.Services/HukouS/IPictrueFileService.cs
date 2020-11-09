using myselfFast.Fund.Core.Domain.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.HukouS
{
    public interface IPictrueFileService
    {
        string SaveBase64Pictrue(string base64str, int type, int orderid, T_Admin_Account account);
        string GetBase64PictrueFromStream(string keyPrefix, string fileName);
    }
}

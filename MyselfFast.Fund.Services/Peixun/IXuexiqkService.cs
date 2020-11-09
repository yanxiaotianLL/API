using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Domain.Peixun;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Services.DTO.Request.Peixun;
using myselfFast.Fund.Services.DTO.Response.Peixun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Peixun
{
    public interface IXuexiqkService : IBaseService<T_Trn_StuRec>
    {
        JqGridResult<ResPeixunxxqkResponseModel> GetXuexiqkList(SelectXuexiqkRequestModel model, T_Admin_Account account, int rows, int page);
        string yuangongDataOut(string[] tIds, T_Admin_Account account);

        string getPerson(string Hno);
    }
}

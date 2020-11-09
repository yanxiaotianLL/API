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
    public interface IYuangongService : IBaseService<T_Trn_Stu>
    {
        JqGridResult<ResYuangongResponseModel> GetYuangongList(SelectYuangongRequestModel model, T_Admin_Account account, int rows, int page);
        string YuangongDataIn(string FileNameOld, string path, T_Admin_Account account, string LableId);
        List<T_Trn_Label> GetLabelIdsText();
        List<ResPeixunLableResponseModel> getTrnLabelList();
 
    }
}

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
    public interface IPeixunService : IBaseService<T_Trn_CozInfo>
    {
        JqGridResult<ResPeixunCozInfoResponseModel> GetPeixunList(SelectPeixunRequestModel model, T_Admin_Account account, int rows, int page);

        List<ResPeixunLableResponseModel> getTrnLabelList();
        List<string> GetLabelIdsText();
        string addSave(T_Trn_CozInfo model, T_Admin_Account account);
        string AddLabel(string name);
        int getLabelIdbyName(string name);
        string delLabel(int id);
        string IsOpen(int id);
        string IsClose(int id);
        T_Trn_CozInfo GetPeixun(int id);
        string editSave(T_Trn_CozInfo model, T_Admin_Account account);
        GetPlayInfoResponseModel GetPlayInfo(string VideoId);
    }
}

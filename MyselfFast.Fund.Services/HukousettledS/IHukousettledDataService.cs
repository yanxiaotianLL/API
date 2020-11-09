using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Domain.HuKouSettled;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Services.DTO.Request.Hukousettled;
using myselfFast.Fund.Services.DTO.Response.Hukousettled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.HukousettledS
{
    public interface IHukousettledDataService : IBaseService<T_HK_Settled_Info>
    {
        JqGridResult<SelectHukousettledResponseModel> GetHukousettledList(SelectHukousettledRequestModel model, T_Admin_Account account, int rows, int page);
        SelectHukousettledResponseModel GetHukousettledDetail(int id, string savePath);
        SelectHukousettledResponseModel fileSys(int Id,int pid, string MaritalStatus, string CensusRegister, string MigrationType, string savePath, int State, int FesId);
        string editRegisterPara(T_HK_Settled_Info model, T_Admin_Account account);
        string setStateOK(int id, T_Admin_Account account);
        List<string> getXianList();
        List<T_HK_Dictionary> GetFileItem();
        List<string> GetFatalReason();
        string SetSaveReason(T_HK_Settled_Info model, T_Admin_Account account, string savePath);
        string getSelfTable(int id, string savePath);
        string getReason(int id);
        string searchDataOut(string id, T_Admin_Account account);
    }
}

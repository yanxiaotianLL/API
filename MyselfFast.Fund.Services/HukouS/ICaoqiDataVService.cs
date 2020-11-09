using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Domain.Hukou;
using myselfFast.Fund.Services.domain;
using myselfFast.Fund.Services.DTO.Request.Hukou;
using myselfFast.Fund.Services.DTO.Response.Hukou;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.HukouS
{
    public interface ICaoqiDataVService : IBaseService<V_HK_Order_List>
    {

        JqGridResult<V_HK_Order_List> GetHukouList(SelectHukouRequestModel model, int rows, int page);
        string tuiDataList(string[] tIds, T_Admin_Account account);
    }
}

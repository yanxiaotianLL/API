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
    public interface ICaiwuDataVService : IBaseService<V_HK_Order_List>
    {
        JqGridResult<V_HK_Order_List> GetHukouList(SelectHukouRequestModel model, int rows, int page);
        string tuiDataList(T_Admin_Account account);
        string setImg(int id, string path, T_Admin_Account account);
        string setPrintState(string[] tIds, T_Admin_Account account);
        string setShoukuan(int id, string Alipayno, string BuyerAccount,DateTime TradeTime, T_Admin_Account account);
    }
}

using myselfFast.Fund.Core.Domain;
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
    public interface IHukouDataVService : IBaseService<V_HK_Order_List>
    {
        JqGridResult<V_HK_Order_List> GetHukouList(SelectHukouRequestModel model, T_Admin_Account account,int rows, int page);
        ResHukouDetailListResponseModel GetHukouDetail(int id);

        string tuiOrder(int id, string Cancelcause, T_Admin_Account account);
        string setIsSendEmail(int id, T_Admin_Account account);
        string setIsSendEmailByids(string[] tIds, T_Admin_Account account);
        string setBackTime(int id, T_Admin_Account account);
        string setBackTimeByids(string[] tIds, T_Admin_Account account);
        string kuaidiDataOut(string[] tIds, T_Admin_Account account);
        string qianchuDataOut(string[] tIds, T_Admin_Account account);
        string searchDataOut(string[] tIds, T_Admin_Account account);
        string kuidiDataIn(string FileNameOld, string path, T_Admin_Account account);
        string tuiDataList(string[] tIds, T_Admin_Account account);
       
        string editKuaidiPara(T_HK_Order model, T_Admin_Account account);
        T_HK_Order getKuaidiPara(string id);
        List<V_CD_PROVINCE> getProvinceList();
        List<V_CD_XIAN> getXianList(string PROVINCE);
        string[] getJYpic(string id);
        string[] getQCpic(string id);
        string getTuipic(string id);
        string tuiOrderJYno(int id, string Backcause, T_Admin_Account account);
        string tuiOrderJYok(int id, T_Admin_Account account);
        string setKuaidiOk(int id, string Kno, T_Admin_Account account);
    }
}

using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Core.Domain.HuKouSettled;
using myselfFast.Fund.Services.DTO.Response.Hukousettled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.HukousettledS
{
    public interface IHukousettledSpecdayService : IBaseService<T_HK_Settled_Specday>
    {
        //获取默认天数和时间段默认人数
        dicShowday GetShowItem();
        //保存默认天数和时间段默认人数
        string setShowItem(dicShowday Dshow, T_Admin_Account account);
        //获取每一天的状态type（0默认，1休息日，2特殊日，21可约，22约满） 以及信息（每个时间段 总人数，已经约的人数，剩余人数）
        List<dayshowType> GetDayshowlist();
        //时间段
        shijianduan getShijianduan(int TimeType);
         string setXiuxi(DateTime dTime, T_Admin_Account account);
         string setGongzuo(DateTime dTime, T_Admin_Account account);
         string setshowdaynum(DateTime dTime, int A, int B, int C, int D, int E, T_Admin_Account account);

    }
}

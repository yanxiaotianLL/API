using myselfFast.Fund.Core.Domain.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.Admin
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Services.Admin
     *项目描述  ：
     *接口名称  ：IAdminPasswordSignHistoryService
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : IAdminPasswordSignHistoryService
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-04-19 14:00:36
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public interface IAdminPasswordSignHistoryService : IBaseService<T_Admin_PasswordSignHistory>
    {
        void Add(T_Admin_PasswordSignHistory model);
        T_Admin_PasswordSignHistory GetHistory(string sign);
    }
}

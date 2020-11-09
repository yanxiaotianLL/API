using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Domain.Admin;
using myselfFast.Fund.Data;
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
     *类名称    ：DepartService
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : DepartService
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-15 12:09:16
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class DepartService :  BaseService<T_Admin_Depart>,IDepartService
    {
        public DepartService(IRepository<T_Admin_Depart> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext)
            : base(tEntityResponsity, _dataProvider, _dbContext)
        {

        }
    }
}

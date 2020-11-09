using myselfFast.Fund.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Services
     *项目描述  ：
     *接口名称  ：IBaseService
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : IBaseService
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-15 13:19:13
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        void AddEntity(TEntity entity);
        void AddEntitys(IEnumerable<TEntity> entitys);
        void DeleteEntity(TEntity entity);
        int DeleteEntitysByIds(int[] ids);
        void DeleteEntitys(IEnumerable<TEntity> entitys);
        void UpdateEntity(TEntity entity);
        TEntity GetById(int id);
        IPagedList<TEntity> GetPageList(int pageIndex = 0, int pageSize = 20);

    }
}

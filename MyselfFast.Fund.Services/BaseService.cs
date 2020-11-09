using myselfFast.Fund.Core;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Fund.Data;
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
     *类名称    ：BaseService
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : BaseService
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-15 13:19:26
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        protected readonly IRepository<TEntity> _tEntityResponsity;
        protected readonly IDataProvider _dataProvider;
        protected readonly IDbContext _dbContext;
        public BaseService(IRepository<TEntity> tEntityResponsity, IDataProvider _dataProvider, IDbContext _dbContext)
        {
            this._tEntityResponsity = tEntityResponsity;
            this._dataProvider = _dataProvider;
            this._dbContext = _dbContext;
        }

        public void AddEntity(TEntity entity)
        {
            if (entity == null){
                throw new ArgumentNullException(string.Format("参数不能为空，类型为{0}", typeof(TEntity)));
            }
            _tEntityResponsity.Insert(entity);
           
        }

        public void AddEntitys(IEnumerable<TEntity> entitys)
        {
            if (entitys == null)
            {
                throw new ArgumentNullException(string.Format("参数不能为空，类型为{0}", typeof(TEntity)));
            }
            _tEntityResponsity.Insert(entitys);
           
        }

        public void DeleteEntity(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(string.Format("参数不能为空，类型为{0}", typeof(TEntity)));
            }
            _tEntityResponsity.Delete(entity);
           
        }    

        

        public void UpdateEntity(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(string.Format("参数不能为空，类型为{0}", typeof(TEntity)));
            }
            _tEntityResponsity.Update(entity);
            
        }

        public TEntity GetById(int id)
        {
            if(id<=0){
                throw new ArgumentNullException(string.Format("参数不合法，类型值为{0}", id));
            }
            return _tEntityResponsity.GetById(id);
        }

        public IPagedList<TEntity> GetPageList(int pageIndex = 0, int pageSize = 20)
        {
            return new PagedList<TEntity>(_tEntityResponsity.Table.Select(s => s), pageIndex, pageSize);
        }


        public void DeleteEntitys(IEnumerable<TEntity> entitys)
        {
            if (entitys == null)
            {
                throw new ArgumentNullException(string.Format("参数不能为空，类型为{0}", typeof(TEntity)));
            }
            _tEntityResponsity.Delete(entitys);
           
        }


        public int DeleteEntitysByIds(int[] ids)
        {
            if (ids == null || ids.Length == 0)
            {
                throw new ArgumentNullException(string.Format("参数ids不能为空，类型为{0}"));
            }
            string tableName = typeof(TEntity).Name;
            
            string strIds = string.Join(",",ids);
            string sqlText = string.Format("DELETE FROM {0} WHERE ID IN({1})", tableName, strIds);
            //var idsParameter =  _dataProvider.GetParameter();

            return _dbContext.ExecuteSqlCommand(sqlText, true);
        }


       
    }
}

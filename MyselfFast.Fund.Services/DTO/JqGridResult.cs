using myselfFast.Fund.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.domain
{
    public class JqGridResult<T> where T : new()
    {
        public int page { get; set; }
        public int total { get; set; }
        public int records { get; set; }
        public List<T> rows { get; set; }
        /// <summary>
        /// 根据分页对象构建JqGrid对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pagedList"></param>
        public static JqGridResult<T> Build(IPagedList<T> pagedList)
        {
            if (pagedList == null || pagedList.Count == 0)
            {
                return new JqGridResult<T>();
            }
            JqGridResult<T> result = new JqGridResult<T>();
            result.rows = pagedList as List<T>;
            result.page = pagedList.PageIndex;
            result.total = pagedList.TotalPages;
            result.records = pagedList.TotalCount;
            return result;
        }
    }
}

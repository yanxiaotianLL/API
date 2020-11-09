using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Request.Peixun
{
    //删除分类入参
    public class setDeleteCategory
    {
        //系统规定参数。取值：DeleteCategory
        public string Action { get; set; }
        /// 分类ID
        public long CateId { get; set; }

    }
}

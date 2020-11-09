using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Request.Peixun
{
    //添加标签分类入参
    public class setAddCategoryModel
    {
        //系统规定参数。取值：AddCategory
        public string Action { get; set; }
        // 分类名称。
        public string CateName { get; set; }
        // 父分类ID。若不填，则默认生成一级分类，根节点分类ID为-1
        public long ParentId { get; set; }

    }
}

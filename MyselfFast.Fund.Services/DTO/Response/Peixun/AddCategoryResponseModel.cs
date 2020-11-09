using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Response.Peixun
{
    public class txtResponseAdd
    {
        public string Success { get; set; }

        public AddCategoryResponseModel Data { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
    }


    //添加视频分类返回值
    public class AddCategoryResponseModel
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public string RequestId { get; set; }
        /// <summary>
        /// 视频分类信息
        /// </summary>
        public Category Category { get; set; }
    }

    public class Category
    {
        /// <summary>
        /// 视频分类ID
        /// </summary>
        public long? CateId { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string CateName { get; set; }
        /// <summary>
        /// 父分类ID，一级分类父ID为-1
        /// </summary>
        public long? ParentId { get; set; }
        /// <summary>
        /// 分类层级，一级分类层级为0
        /// </summary>
        public long? Level { get; set; }
    }

}

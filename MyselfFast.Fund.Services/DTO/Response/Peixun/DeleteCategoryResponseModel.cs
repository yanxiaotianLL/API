using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Services.DTO.Response.Peixun
{
    public class txtResponseDel
    {
        public string Success { get; set; }

        public DeleteCategoryResponseModel Data { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
    }
    //删除视频分类返回值
    public class DeleteCategoryResponseModel
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        public string RequestId { get; set; }
    }

     

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.Models
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Models
     *项目描述  ：接口统一API数据返回实体
     *类名称    ：ApiResponseModel
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ApiResponseModel
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/16 21:42:34
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class ResponseBase<T> where T : new()
    {
        public ResponseBase()
        {
            
        }
        public ResponseBase(string message)
        {
            this.Success = false;
            this.Code = "1";
            this.Data = default(T);
            this.Message = message;
        }
        /// <summary>
        /// 接口调用是否成功
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 接口调用情况描述：失败-返回失败原因，成功默认为空，也可以赋予特定的附加信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 返回调用接口状态码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 接口返回数据
        /// </summary>
        public T Data { get; set; }
    }
}

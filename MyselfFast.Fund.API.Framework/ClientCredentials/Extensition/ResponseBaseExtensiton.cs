using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myselfFast.Fund.API.Framework.Models;

namespace myselfFast.Fund.API.Framework.Extensition
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Extensition
     *项目描述  ：
     *类名称    ：ResponseBaseExtensiton
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ResponseBaseExtensiton
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/12/27 16:00:39
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/

    public static class ResponseBaseExtensiton
    {
        /// <summary>
        /// 如果请求参数为空，创建返回结果
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static ResponseBase<T> CreateResponseForNull<T>(this ResponseBase<T> model)
            where T : new()
         {
            ResponseBase<T> responseResult = new ResponseBase<T>();
            responseResult.Data = default(T);
            responseResult.Code = "0";
            responseResult.Success = false;
            responseResult.Message = "请求参数不能为空！";
            return responseResult;
        }

        /// <summary>
        /// 如果请求参数为空，创建返回结果
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static ResponseBase<T> CreateResponseForIsNotValid<T>(this ResponseBase<T> model,string errMessage)
            where T : new()
        {
            ResponseBase<T> responseResult = new ResponseBase<T>();
            responseResult.Data = default(T);
            responseResult.Code = "0";
            responseResult.Success = false;
            responseResult.Message = errMessage;
            return responseResult;
        }
    }
}

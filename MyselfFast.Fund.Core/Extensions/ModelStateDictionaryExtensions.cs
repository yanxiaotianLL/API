using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;


namespace myselfFast.Fund.Core.Common.Extensions
{
    /**********************************************************************************
     *项目名称	：FS.Common.Extensions
     *项目描述  ：
     *类名称    ：ModelStateDictionaryExtensions
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC 
     *项目名称  : ModelStateDictionaryExtensions
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/12/27 15:07:50
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static  class ModelStateDictionaryExtensions
    {
        public static string GetErrorMessage(this ModelStateDictionary modelState)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in modelState.Values)
            {
                if (item.Errors.Count > 0)
                {
                    for (int i = item.Errors.Count - 1; i >= 0; i--)
                    {
                        sb.Append(item.Errors[i].ErrorMessage);
                        sb.Append(",");
                    }
                }
            }
            return sb.ToString();
        }
    }
}

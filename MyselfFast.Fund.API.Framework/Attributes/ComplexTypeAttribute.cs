using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.Attributes
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Attributes
     *项目描述  ：
     *类名称    ：ComplexTypeAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ComplexTypeAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/17 14:19:04
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 请求参数如果为非IDE简单类型，需要加上此标签标识。
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ComplexTypeAttribute : Attribute
    {
    }
}

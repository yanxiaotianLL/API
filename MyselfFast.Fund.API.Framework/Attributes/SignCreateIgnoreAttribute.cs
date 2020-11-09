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
     *类名称    ：SignCreateIgnoreAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : SignCreateIgnoreAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/17 14:21:01
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 用于标记在生成sign的时候是否使用该属性,将该标记加到符合限制条件的属性上
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class SignCreateIgnoreAttribute : Attribute
    {
    }
}

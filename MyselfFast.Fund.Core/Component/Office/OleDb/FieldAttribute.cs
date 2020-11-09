using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Component.Office.OleDb
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Component.Office.OleDb
     *项目描述  ：
     *类名称    ：TableAttribute
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : TableAttribute
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-02-08 0:56:15
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    [AttributeUsage(AttributeTargets.Property)]
    public class FieldAttribute:Attribute
    {
        public string Name { get; set; }
        public FieldAttribute(string name)
        {
            this.Name = name;
        }
    }
}

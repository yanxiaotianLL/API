using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.Extensition
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.Extensition
     *项目描述  ：
     *类名称    ：KeyValuePairExtensition
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : KeyValuePairExtensition
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/12/31 0:57:32
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static  class KeyValuePairExtensition
    {
        public static KeyValuePair<string, string> GetParamter(this IEnumerable<KeyValuePair<string, string>> dic, string name)
        {
            KeyValuePair<string, string> value = new KeyValuePair<string, string>();
            if (dic.Any(a=>a.Key == name))
            {
               
                foreach(var item in dic)
                {
                    if (item.Key == name)
                    {
                        return item;
                    }
                }
            }
            return value;
        }
    }
}

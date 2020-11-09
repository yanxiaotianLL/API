using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace myselfFast.Fund.Core
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core
     *项目描述  ：
     *类名称    ：FormUrlEncodedContentCostom
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : FormUrlEncodedContentCostom
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-12-03 18:04:49
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class FormUrlEncodedContentCostom : FormUrlEncodedContent
    {
        public FormUrlEncodedContentCostom(IEnumerable<KeyValuePair<string, string>> nameValueCollection)
            : base(nameValueCollection)
        {
            
        }
        static byte[] SerializeValue(string value)
        {
            if (value == null)
                return null;
            //return HttpUtility.UrlEncodeToBytes(value).Replace("%20", "+");
            //value = Uri.EscapeDataString(value).Replace("%20", "+");
            return Encoding.ASCII.GetBytes(value);
        }
    }
}

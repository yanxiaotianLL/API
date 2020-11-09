using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.ClientCredentials
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.ClientCredentials
     *项目描述  ：
     *类名称    ：DefaultCredentialsProvider
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : DefaultCredentialsProvider
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/11/17 0:00:38
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class DefaultCredentialsProvider:IClientCredentialsProvider
    {
        public ClientCredentialsModel GetByClientId(string clientId)
        {
           var clientCredentialsLists = WebApiConfiguration.CreateInstance().ClientCredentialsModelStore.Where(w=>w.ClientId == clientId).Select(s => s);
            if (clientCredentialsLists != null && clientCredentialsLists.Count() > 0)
            {
                return clientCredentialsLists.SingleOrDefault<ClientCredentialsModel>();
            }
            return null;
        }
    }
}

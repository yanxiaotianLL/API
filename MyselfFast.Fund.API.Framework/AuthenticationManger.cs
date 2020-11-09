
using myselfFast.Fund.API.Framework.Attributes;
using myselfFast.Fund.API.Framework.ClientCredentials;
using myselfFast.Fund.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework
{
    public  class AuthenticationManger
    {
        /// <summary>
        /// 用户身份校验
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool ClientCredentialsCheck(ClientCredentialsModel model)
        {
            return true;
        }

        /// <summary>
        /// token生成并存储到容器
        /// </summary>
        /// <param name="clientCredentials"></param>
        /// <returns></returns>
        internal string CreateToken(ClientCredentialsModel clientCredentials)
        {
            string token = EncryptHelperTwo.HmacMd5(clientCredentials.ClientId + clientCredentials.ClientSecret,
                Guid.NewGuid().ToString());
            return token;
        }

    }
}

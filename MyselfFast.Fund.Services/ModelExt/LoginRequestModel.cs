using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myselfFast.ZFBZ.Services.ModelExt
{
    public class LoginRequestModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { get; set; }
    }
}
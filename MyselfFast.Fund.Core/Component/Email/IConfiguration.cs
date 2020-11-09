using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.Email
{
    public interface IConfiguration
    {
        /// <summary>
        /// 发件人地址
        /// </summary>
        string EmailFromAddress { get; }
        /// <summary>
        /// 发件人密码
        /// </summary>
        string EmailFromPassword { get; }
        /// <summary>
        /// 邮件服务器地址
        /// </summary>
        string EmailHostIP { get; }
        /// <summary>
        /// 邮件服务器端口
        /// </summary>
        string EmailHostPort { get; }

    }
}

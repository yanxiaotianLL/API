using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.Email
{
    /// <summary>
    /// 邮箱信息配置
    /// </summary>
    public class EmailConfiguration
    {
        public EmailServer EmailServer { get; set; }
        public EmailUserGroups EmailUserGroups { get; set; }
    }
}

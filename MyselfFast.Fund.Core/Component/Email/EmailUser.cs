using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Component.Email
{
    /**********************************************************************************
     *项目名称	：FS.Component.Email
     *项目描述  ：
     *类名称    ：EmailUser
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : EmailUser
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/11 19:10:31
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 收件人列表
    /// </summary>
    public  class EmailUser
    {
        public int Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string Email { get; set; }
    }
    /// <summary>
    /// 收件人分组
    /// </summary>
    public class EmailUserGroup
    {
        public string GroupName { get; set; }
        public List<EmailUser> EmailUsers { get; set; }
    }
    public class EmailUserGroups
    {
        public int Id { get; set; }
        public List<EmailUserGroup> UserGroups { get; set; }
    }
}

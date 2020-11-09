using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Component.Logging
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Component.Logging
     *项目描述  ：
     *类名称    ：LogEntity
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : LogEntity
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-24 17:35:32
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class LogEntity
    {
              
        /// <summary>
        /// 系统名称
        /// </summary>
        public string SystemName { get; set; }
        /// <summary>
        /// 模块名称
        /// </summary>
        public string ModuleName { get; set; }       
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 日志记录自定义内容信息
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 业务日志编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 业务关键字1
        /// </summary>
        public string Key1 { get; set; }
        /// <summary>
        /// 业务关键字2
        /// </summary>
        public string Key2 { get; set; }
        /// <summary>
        /// 业务关键字3
        /// </summary>
        public string Key3 { get; set; }
        /// <summary>
        /// 业务关键字4
        /// </summary>
        public string Key4 { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("SystemName:{0}\r\n", SystemName));
            sb.Append(string.Format("ModuleName:{0}\r\n", ModuleName));
            sb.Append(string.Format("Name:{0}\r\n", Name));
            sb.Append(string.Format("Content:{0}\r\n", Content));
            sb.Append(string.Format("Code:{0}\r\n", Code));
            sb.Append(string.Format("Key1:{0}\r\n", Key1));
            sb.Append(string.Format("Key2:{0}\r\n", Key2));
            sb.Append(string.Format("Key3:{0}\r\n", Key3));
            sb.Append(string.Format("Key4:{0}\r\n", Key4));
          
            return sb.ToString();
        }
    }
}

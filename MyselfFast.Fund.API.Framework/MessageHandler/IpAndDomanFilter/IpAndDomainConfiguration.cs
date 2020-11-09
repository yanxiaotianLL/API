﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.API.Framework.MessageHandler.IpAndDomanFilter
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.API.Framework.MessageHandler.IpAndDomanFilter
     *项目描述  ：
     *类名称    ：IpAndDomainConfiguration
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : IpAndDomainConfiguration
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/15 0:10:10
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public   class IpAndDomainConfiguration
    {
        /// <summary>
        /// 是否开启IP过滤
        /// </summary>
        public  bool IsIpSwitch { get; set; }
       
        /// <summary>
        /// IP允许列表
        /// </summary>
        public List<IpFiltering> IpFilterings { get; set; }
       
    }

    public class IpFiltering
    {
        public FilterType FilterType { get; set; } 
        public string IpAddress { get; set; }
    }
   

    public enum FilterType
    {
        Denied = 0,
        Allowed = 1
    }
}
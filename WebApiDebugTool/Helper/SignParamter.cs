using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDebugTool.Helper
{
    /**********************************************************************************
     *项目名称	：WebApiDebugTool.Helper
     *项目描述  ：
     *类名称    ：SignParamter
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : SignParamter
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017/1/4 13:49:53
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 计算签名所需要的参数
    /// </summary>
    public class SignParamter
    {
        /// <summary>
        /// 签名
        /// </summary>
        public const string Signature = "sign";
        /// <summary>
        /// 随机串
        /// </summary>
        public const string Noncestr = "noncestr";
        /// <summary>
        /// 时间戳
        /// </summary>
        public const string Timestamp = "timestamp";
        /// <summary>
        /// 客户端名称
        /// </summary>
        public const string AppAccount = "appaccount";
        /// <summary>
        /// 参数值
        /// </summary>
        public const string JsonParam = "jsonParam";



    }
}

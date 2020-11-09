using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewSystem.SDK.Config;

namespace DependencyRegister.NewSytemSDKConfig
{
    /**********************************************************************************
     *项目名称	：DependencyRegister.NewSytemSDKConfig
     *项目描述  ：
     *类名称    ：NewSytemSDKConfigInit
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : NewSytemSDKConfigInit
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2016/12/28 0:07:02
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class NewSytemSDKConfigInit
    {
        public static void SDKConfigInit()
        {
            //如果存在配置文件，加载配置文件当中的配置信息
            GlobalConfiguration.ConfigInitialization();
            //注册日志组件
            GlobalConfiguration.Configuration.RegisterLoggerFactory(new LoggerFactory());
            //新系统中间表机制默认重发时间
            GlobalConfiguration.Configuration.DefaultScheduleTime = 30;
            //新系统获取token 使用密码提供程序注册
            //GlobalConfiguration.Configuration.RegisterTokenProviderFactory(new TokenProviderFactory());
        }
    }
}

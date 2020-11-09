using myselfFast.Fund.Core.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Integration.Mvc;
using NewSystem.SDK.Services;
using NewSystem.SDK.Interfaces;
namespace myselfFast.Fund.Services.Infrastructure
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Services.Infrastructure
     *项目描述  ：
     *类名称    ：NewSDKDependencyRegistrar
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : NewSDKDependencyRegistrar
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-03-30 13:30:10
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// 新系统接口服务注册
    /// </summary>
    public  class NewSDKDependencyRegistrar:IDependencyRegistrar
    {

        public void Register(Autofac.ContainerBuilder builder, Core.Infrastructure.ITypeFinder typeFinder)
        {
            
            builder.RegisterType<FileDownService>().As<IFileDownService>().InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 7; }
        }
    }
}

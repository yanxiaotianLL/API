using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using myselfFast.Fund.Core.Infrastructure;

namespace myselfFast.Fund.Core.DependencyManagement
{
    /**********************************************************************************
     *项目名称	：FS.Component.Infrastructure.DependencyManagement
     *项目描述  ：
     *类名称    ：IDependencyRegistrar
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : IDependencyRegistrar
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017-04-10 15:27:36
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// Dependency registrar interface
    /// </summary>
    public interface IDependencyRegistrar
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="builder">Container builder</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="config">Config</param>
        void Register(ContainerBuilder builder, ITypeFinder typeFinder);

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        int Order { get; }
    }
}

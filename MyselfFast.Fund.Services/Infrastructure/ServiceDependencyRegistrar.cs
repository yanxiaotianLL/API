using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Integration.Mvc;
using myselfFast.Fund.Core.DependencyManagement;
using myselfFast.Fund.Core.Infrastructure;
using myselfFast.Fund.Core.Data;
using myselfFast.Fund.Data;
using myselfFast.Fund.Services.Admin;

namespace myselfFast.Fund.Services.Infrastructure
{
    /// <summary>
    /// Dependency registrar
    /// </summary>
    public class ServiceDependencyRegistrar : IDependencyRegistrar
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="builder">Container builder</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="config">Config</param>
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {


            builder.RegisterAssemblyTypes(Assembly.GetAssembly(this.GetType()))
                  .Where(w => w.Name.EndsWith("Service"))
                  .AsImplementedInterfaces().InstancePerRequest(); 
            //#region 服务层代码注册
            builder.RegisterGeneric(typeof(BaseService<>)).As(typeof(IBaseService<>)).InstancePerLifetimeScope();
            //#region 权限相关
            //builder.RegisterType(typeof(AdminAccountService)).As(typeof(IAdminAccountService)).InstancePerLifetimeScope();
            //builder.RegisterType(typeof(AdminMenuService)).As(typeof(IAdminMenuService)).InstancePerLifetimeScope();
            

            //#endregion

            //#endregion
        }

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        public int Order
        {
            get { return 1; }
        }

      
    }


   

}

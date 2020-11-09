using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Integration.Mvc;
using FescoFast.Collect.Core.DependencyManagement;
using FescoFast.Collect.Core.Infrastructure;
using FescoFast.Component.Cache;
using FescoFast.Component.MsgMobile;
using FescoFast.Component.Email;
using FescoFast.Component.Logging;
using FescoFast.Collect.Core.Component.Logging;

namespace FescoFast.Collect.Core.Infrastructure.Modules
{
    /// <summary>
    /// Dependency registrar
    /// </summary>
    public class DependencyRegistrar : IDependencyRegistrar
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="builder">Container builder</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="config">Config</param>
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
           
                
          
           

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

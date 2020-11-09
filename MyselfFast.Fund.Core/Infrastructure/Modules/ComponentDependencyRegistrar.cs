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
using myselfFast.Component.Cache;
using myselfFast.Component.MsgMobile;
using myselfFast.Component.Email;
using myselfFast.Component.Logging;
using myselfFast.Fund.Core.Component.Logging;

namespace myselfFast.Fund.Core.Infrastructure.Modules
{
    /// <summary>
    /// Dependency registrar �������ע��
    /// </summary>
    public class ComponentDependencyRegistrar : IDependencyRegistrar
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="builder">Container builder</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="config">Config</param>
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
           
            #region ����
            builder.RegisterType<DefaultCacheAdapter>().As<ICacheStorage>().SingleInstance();
            #endregion
            #region ����
            builder.RegisterType<EmailServiceV2>().As<myselfFast.Component.Email.IEmail>().SingleInstance();
            #endregion
            #region ��־
            builder.RegisterType<LoggerProviderFactory>().As<ILoggerProviderFactory>().SingleInstance();
            #endregion              
          
            #region ��־
            builder.RegisterType<myselfFast.Component.MsgMobile.qxt.SendMsgHandler>().As<ISendMsgHandler>().InstancePerRequest();
            #endregion 

        }

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        public int Order
        {
            get { return 0; }
        }
    }


   

}

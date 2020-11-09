using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using myselfFast.Fund.Core.DependencyManagement;
using myselfFast.Component.Logging;


namespace myselfFast.Fund.Core.Infrastructure
{
    /**********************************************************************************
     *项目名称	：FS.Component.Infrastructure
     *项目描述  ：
     *类名称    ：myselfServiceEngine
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : myselfServiceEngine
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017-04-10 15:41:35
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    /// <summary>
    /// Engine
    /// </summary>
    public class myselfServiceEngine : IEngine
    {
        #region Fields

        private ContainerManager _containerManager;

        #endregion

        #region Utilities

        /// <summary>
        /// Run startup tasks
        /// </summary>
        protected virtual void RunStartupTasks()
        {
            var logger = new LoggerProviderFactory().CreateDefaultLogger();
            logger.Info(this, "\r\n============RunStartupTasks:Call-Start==============\r\n");
            var typeFinder = _containerManager.Resolve<ITypeFinder>();
            var startUpTaskTypes = typeFinder.FindClassesOfType<IStartupTask>();
            var startUpTasks = new List<IStartupTask>();
            foreach (var startUpTaskType in startUpTaskTypes)
                startUpTasks.Add((IStartupTask)Activator.CreateInstance(startUpTaskType));
            //sort
            startUpTasks = startUpTasks.AsQueryable().OrderBy(st => st.Order).ToList();
            foreach (var startUpTask in startUpTasks)
            {
                startUpTask.Execute();
                logger.Info(this, string.Format("任务类型:{0},\r\n", startUpTask));
            }
            logger.Info(this, "\r\n============RunStartupTasks:Call-End==============\r\n");
        }

        /// <summary>
        /// Register dependencies
        /// </summary>
        /// <param name="config">Config</param>
        protected virtual void RegisterDependencies()
        {
            var logger = new LoggerProviderFactory().CreateDefaultLogger();
            logger.Info(this, "\r\n============RegisterDependencies:Call-Start==============\r\n");
           
            var builder = new ContainerBuilder();
            var container = builder.Build();
            this._containerManager = new ContainerManager(container);

            //dependencies
            builder = new ContainerBuilder();
            var typeFinder = new WebAppTypeFinder();
            builder.RegisterInstance(this).As<IEngine>().SingleInstance();
            //builder.RegisterInstance(typeFinder).As<ITypeFinder>().InstancePerLifetimeScope();
            builder.RegisterType<WebAppTypeFinder>().As<ITypeFinder>().InstancePerRequest();
            builder.Update(container);

           
            //register dependencies provided by other assemblies
            builder = new ContainerBuilder();
            var assemblys = typeFinder.GetAssemblies();
            var drTypes = typeFinder.FindClassesOfType<IDependencyRegistrar>(assemblys);
            var drInstances = new List<IDependencyRegistrar>();
            foreach (var drType in drTypes)
            {
                drInstances.Add((IDependencyRegistrar)Activator.CreateInstance(drType));
                logger.Info(this, string.Format("类型:{0},\r\n",drType));
            }
            //sort
            drInstances = drInstances.AsQueryable().OrderBy(t => t.Order).ToList();
            foreach (var dependencyRegistrar in drInstances)
                dependencyRegistrar.Register(builder, typeFinder);
            builder.Update(container);
           
            var config = GlobalConfiguration.Configuration;
            //web api
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            //mvc
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            logger.Info(this, "\r\n============RegisterDependencies:Call-End==============\r\n");
            
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initialize components and plugins in the nop environment.
        /// </summary>
        /// <param name="config">Config</param>
        public void Initialize()
        {
            var logger = new LoggerProviderFactory().CreateDefaultLogger();
            logger.Info(this, "\r\n============myselfServiceEngine-Init:Call-Start==============\r\n");
            //register dependencies
            RegisterDependencies();
            RunStartupTasks();
            logger.Info(this, "\r\n============myselfServiceEngine-Init:Call-End==============\r\n");
        }

        /// <summary>
        /// Resolve dependency
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <returns></returns>
        public T Resolve<T>() where T : class
        {
            return ContainerManager.Resolve<T>();
        }

        /// <summary>
        ///  Resolve dependency
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns></returns>
        public object Resolve(Type type)
        {
            return ContainerManager.Resolve(type);
        }

        /// <summary>
        /// Resolve dependencies
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <returns></returns>
        public T[] ResolveAll<T>()
        {
            return ContainerManager.ResolveAll<T>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Container manager
        /// </summary>
        public ContainerManager ContainerManager
        {
            get { return _containerManager; }
        }

        #endregion

    }


}

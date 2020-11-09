using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using FescoFast.Collect.Core.Infrastructure;
using FescoFast.Collect.Core.DependencyManagement;
using System.Web.Mvc;



namespace FescoFast.Collect.Core.Infrastructure
{
    /**********************************************************************************
     *项目名称	：FS.Component.Infrastructure
     *项目描述  ：
     *类名称    ：FescoServiceEngine
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : FescoServiceEngine
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
    public class BaseEngine : IEngine
    {
        #region Fields

        protected ContainerManager _containerManager;

        #endregion

        #region Utilities

        /// <summary>
        /// Run startup tasks
        /// </summary>
        protected virtual void RunStartupTasks()
        {
            var typeFinder = _containerManager.Resolve<ITypeFinder>();
            var startUpTaskTypes = typeFinder.FindClassesOfType<IStartupTask>();
            var startUpTasks = new List<IStartupTask>();
            foreach (var startUpTaskType in startUpTaskTypes)
                startUpTasks.Add((IStartupTask)Activator.CreateInstance(startUpTaskType));
            //sort
            startUpTasks = startUpTasks.AsQueryable().OrderBy(st => st.Order).ToList();
            foreach (var startUpTask in startUpTasks)
                startUpTask.Execute();
        }

        /// <summary>
        /// Register dependencies
        /// </summary>
        /// <param name="config">Config</param>
        protected virtual void RegisterDependencies()
        {
           
            var builder = new ContainerBuilder();
            var container = builder.Build();
            this._containerManager = new ContainerManager(container);

           
            Assembly[]  assemblys = RegisterDependencie(builder,container);


            //dependencies
            var typeFinder = new WebAppTypeFinder();
            builder = new ContainerBuilder();

            builder.RegisterInstance(this).As<IEngine>().SingleInstance();
            builder.RegisterInstance(typeFinder).As<ITypeFinder>().SingleInstance();
            //builder.RegisterType<SsoLoginAttribute>().SingleInstance();
            builder.Update(container);

            //register dependencies provided by other assemblies
            builder = new ContainerBuilder();
            var drTypes = typeFinder.FindClassesOfType<IDependencyRegistrar>(assemblys);
            var drInstances = new List<IDependencyRegistrar>();
            foreach (var drType in drTypes)
                drInstances.Add((IDependencyRegistrar)Activator.CreateInstance(drType));
            //sort
            drInstances = drInstances.AsQueryable().OrderBy(t => t.Order).ToList();
            foreach (var dependencyRegistrar in drInstances)
                dependencyRegistrar.Register(builder, typeFinder);
            builder.Update(container);

            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
        public virtual Assembly[] RegisterDependencie(ContainerBuilder builder, IContainer container) {
            return null;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Initialize components and plugins in the nop environment.
        /// </summary>
        /// <param name="config">Config</param>
        public void Initialize()
        {
            //register dependencies
            RegisterDependencies();

            //startup tasks           
            RunStartupTasks();
            

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

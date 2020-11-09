using myselfFast.Fund.Core.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Integration.Mvc;
namespace myselfFast.Fund.Core.Infrastructure.Modules
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Infrastructure.Modules
     *项目描述  ：
     *类名称    ：MvcDependencyRegistrar
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : MvcDependencyRegistrar
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-27 13:30:05
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class MvcDependencyRegistrar : IDependencyRegistrar
    {
        public void Register(Autofac.ContainerBuilder builder, ITypeFinder typeFinder)
        {
          
            //var assemblys = AppDomain.CurrentDomain.GetAssemblies().Where(w => w.FullName.StartsWith("myselfFast."));
            var assemblys = typeFinder.GetAssemblies();
            var aa = assemblys.ToArray();
            if (assemblys != null && assemblys.Any())
            {
                //foreach (var assembly in assemblys)
                //{

                    // Register your MVC controllers. (MvcApplication is the name of
                    // the class in Global.asax.)
                    builder.RegisterControllers(aa);

                    // OPTIONAL: Register model binders that require DI.
                    builder.RegisterModelBinders(aa);
                    builder.RegisterModelBinderProvider();

                    // OPTIONAL: Register web abstractions like HttpContextBase.
                    builder.RegisterModule<AutofacWebTypesModule>();

                    // OPTIONAL: Enable property injection in view pages.
                    builder.RegisterSource(new ViewRegistrationSource());

                    // OPTIONAL: Enable property injection into action filters.
                    builder.RegisterFilterProvider();                   
                  
                //}

            }
        }

        public int Order
        {
            get { return 4; }
        }
    }
}

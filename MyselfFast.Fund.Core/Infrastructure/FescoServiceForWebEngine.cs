
using FescoFast.Collect.Core.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using FescoFast.Collect.Core.Infrastructure;

using System.Reflection;
using System.Web.Mvc;
namespace FescoFast.Collect.Core.Infrastructure
{
    /**********************************************************************************
     *项目名称	：FescoFast.Collect.Core
     *项目描述  ：
     *类名称    ：FescoServiceForWebEngine
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : FescoServiceForWebEngine
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-12 12:04:43
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class FescoServiceForWebEngine : BaseEngine
    {
        public override Assembly[] RegisterDependencie(ContainerBuilder builder, IContainer container)
        {
            var assemblys = AppDomain.CurrentDomain.GetAssemblies().Where(w => w.FullName.StartsWith("FescoFast"));
            var config = System.Web.Http.GlobalConfiguration.Configuration; 
            if (assemblys != null && assemblys.Any())
            {
                builder.RegisterControllers(assemblys.ToArray());

                // OPTIONAL: Register model binders that require DI.
                builder.RegisterModelBinders(assemblys.ToArray());
                builder.RegisterModelBinderProvider();
                builder.RegisterModule<AutofacWebTypesModule>();
                builder.RegisterFilterProvider();
                //builder.Update(container);
                config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
                DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            }
            
            return assemblys.ToArray();
        }
    }
}


using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using FescoFast.Collect.Core.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FescoFast.Collect.Core.Infrastructure
{
    /**********************************************************************************
     *项目名称	：FescoFast.Collect.Core.Infrastructure
     *项目描述  ：
     *类名称    ：FescoServiceForApiEngine
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : FescoServiceForApiEngine
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-12 12:05:08
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public class FescoServiceForApiEngine : BaseEngine
    {
       

        public override System.Reflection.Assembly[] RegisterDependencie(ContainerBuilder builder, IContainer container)
        {
            var assemblys = AppDomain.CurrentDomain.GetAssemblies().Where(w => w.FullName.StartsWith("FescoFast."));
            var config = System.Web.Http.GlobalConfiguration.Configuration;    
            if (assemblys != null && assemblys.Any())
            {


                // Register your Web API controllers.
                builder.RegisterApiControllers(assemblys.ToArray());

                // OPTIONAL: Register the Autofac filter provider.
                builder.RegisterWebApiFilterProvider(config);

                // OPTIONAL: Register the Autofac model binder provider.
                builder.RegisterWebApiModelBinderProvider();

                builder.Update(container);
                config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            }
           
            return assemblys.ToArray();
        }
    }
}

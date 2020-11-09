using myselfFast.Fund.Core.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Integration.WebApi;
using System.Web.Http;
namespace myselfFast.Fund.Core.Infrastructure.Modules
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Infrastructure.Modules
     *项目描述  ：
     *类名称    ：ApiDependencyRegistrar
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : ApiDependencyRegistrar
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-27 13:41:32
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class ApiDependencyRegistrar : IDependencyRegistrar
    {
        public void Register(Autofac.ContainerBuilder builder, ITypeFinder typeFinder)
        {
           
            var assemblys = typeFinder.GetAssemblies();
            var aa = assemblys.ToArray();
            if (assemblys != null && assemblys.Any())
            {
                var config = GlobalConfiguration.Configuration;
                // Register your Web API controllers.
                builder.RegisterApiControllers(aa);

                // OPTIONAL: Register the Autofac filter provider.
                builder.RegisterWebApiFilterProvider(config);

                // OPTIONAL: Register the Autofac model binder provider.
                builder.RegisterWebApiModelBinderProvider();


            }
        }

        public int Order
        {
            get { return 5; }
        }
    }
}

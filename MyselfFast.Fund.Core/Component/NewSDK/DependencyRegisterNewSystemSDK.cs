using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using NewSystem.SDK.Interfaces;
using myselfFast.Fund.Core.DependencyManagement;
using myselfFast.Fund.Core.Infrastructure;

namespace myselfFast.Component.NewSDK
{
    /**********************************************************************************
     *项目名称	：FS.Component.NewSDK
     *项目描述  ：
     *类名称    ：DependencyRegisterNewSystemSDK
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : DependencyRegisterNewSystemSDK
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2017-04-10 22:22:49
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public  class DependencyRegisterNewSystemSDK : IDependencyRegistrar
    {
        public void Register(Autofac.ContainerBuilder builder, ITypeFinder typeFinder)
        {
           
            //雇员信息接口导入
            builder.RegisterType<NewSystem.SDK.Services.EmployeeService>().As<NewSystem.SDK.Interfaces.IEmployee>().InstancePerRequest();
            builder.RegisterType<NewSystem.SDK.Services.EmployeeHttpsService>().As<NewSystem.SDK.Interfaces.IEmployeeHttpsService>().InstancePerRequest();
            //基础信息接口导入
            builder.RegisterType<NewSystem.SDK.Services.BasicFunction>().As<NewSystem.SDK.Interfaces.IBasicFunction>().InstancePerRequest();

            builder.RegisterType<NewSystem.SDK.Services.ExaminService>().As<IExaminSupplier>().InstancePerRequest();
            builder.RegisterType<NewSystem.SDK.Services.FileUploadService>().As<IFileUploadService>().InstancePerRequest();
            builder.RegisterType<NewSystem.SDK.Services.FileDownService>().As<IFileDownService>().InstancePerRequest();
            builder.RegisterType<NewSystem.SDK.Services.FundextRentHttpsService>().As<IFundextRentHttpsService>().InstancePerRequest();
            builder.RegisterType<NewSystem.SDK.Services.FileInfoQuery>().As<IFileInfoQueryService>().InstancePerRequest();
            //手机实名制接口导入
            builder.RegisterType<NewSystem.SDK.Services.MobileAuthenticationService>().As<IMobileAuthenticationService>().InstancePerRequest();
            
        }

        public int Order
        {
            get { return 3; }
        }
    }
}

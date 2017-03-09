using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Pruefung.Contract.Repositories;
using Pruefung.Contract.Services;
using Pruefung.Core;
using Pruefung.Data;
using System.Web.Http;
using System.Web.Mvc;

namespace Pruefung.Web.App_Start
{
    public class Bootstrap
    {
        public static void Setup(HttpConfiguration config)
        {
            var container = Register();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(Bootstrap).Assembly);
            builder.RegisterApiControllers(typeof(Bootstrap).Assembly);


            builder.RegisterType<TestRepository>().As<ITestRepository>().SingleInstance();

            builder.RegisterType<TestService>().As<ITestService>();

            return builder.Build();
        }
    }
}
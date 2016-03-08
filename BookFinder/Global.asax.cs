using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Reflection;
using Autofac;
using Autofac.Integration.Mvc;
using System.IO;
using BookFinder.Models;

namespace BookFinder
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            AutoFacMvc_Start();
        }

        private void AutoFacMvc_Start()
        {
            var builder = new ContainerBuilder();

            // Register MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //Register Business Layer.
            var fakeDomain = AppDomain.CurrentDomain.GetAssemblies()
    .Where(t => t.FullName.Contains("FakeDomain,"))
    .ToArray();

            builder.RegisterAssemblyTypes(fakeDomain).AsSelf().AsImplementedInterfaces().ExternallyOwned();


            // OPTIONAL: Register model binders that require DI.
            //builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            //builder.RegisterModelBinderProvider();

            //// OPTIONAL: Register web abstractions like HttpContextBase.
            //builder.RegisterModule<AutofacWebTypesModule>();

            //// OPTIONAL: Enable property injection in view pages.
            //builder.RegisterSource(new ViewRegistrationSource());

            //// OPTIONAL: Enable property injection into action filters.
            //builder.RegisterFilterProvider();


            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

    }
}
﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using CatsAndOwners.Interfaces;
using CatsAndOwners.Services;

namespace CatsAndOwners
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            InitialiseDependencyInjection();
        }

        private void InitialiseDependencyInjection()
        {
            var builder = new ContainerBuilder();

            // add MVC controllers so Autofac recognises them
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // register services
            builder
                .RegisterType<PetOwnerRetrievalService>()
                .As<IPetOwnerRetrievalService>()
                .InstancePerRequest();
            builder
                .RegisterType<PetGroupingService>()
                .As<IPetGroupingService>()
                .InstancePerRequest();

            // build the container and set it to be the default resolver
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}

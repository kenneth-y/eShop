using eShop.Core.Entities;
using eShop.Core.Interfaces;
using eShop.Core.Services;
using eShop.EntityFramework.DbContexts;
using eShop.EntityFramework.Repositories;
using eShop.WebApi.Unity;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace eShop.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<EShopDbContext, EShopDbContext>();
            container.RegisterType<IRepository<Product>, SqlStoreRepository<Product>>();
            container.RegisterType<IProductService, ProductService>();
            config.DependencyResolver = new UnityDependencyResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

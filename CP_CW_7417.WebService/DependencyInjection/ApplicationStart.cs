using Autofac;
using Autofac.Integration.Wcf;
using CP_CW_7417.DAL.Context;
using CP_CW_7417.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace CP_CW_7417.WebService.DependencyInjection
{
    // used to inject dependencies into classes
    public class ApplicationStart
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // registering db context using options
            var dbContextOptionsBuilder =
                new DbContextOptionsBuilder<SwipesDbContext>().UseSqlServer(ConfigurationManager.ConnectionStrings["Swipes7417"].ConnectionString);

            // registering db context parameters
            builder.RegisterType<SwipesDbContext>().WithParameter("options", dbContextOptionsBuilder.Options).InstancePerLifetimeScope();

            // registering repository using connection string which can be found in web.config file
            builder.RegisterType<SwipeRepository>().WithParameter("connectionString", ConfigurationManager.ConnectionStrings["Swipes7417"].ConnectionString).SingleInstance();

            // registering service
            builder.RegisterType<SwipesCollectionService>().SingleInstance();

            var container = builder.Build();

            AutofacHostFactory.Container = container;
        }
    }
}
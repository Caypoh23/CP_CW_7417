using Autofac;
using Autofac.Integration.Wcf;
using CP_CW_7417.DAL.Context;
using CP_CW_7417.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace CP_CW_7417.WebService.DependencyInjection
{
    public class ApplicationStart
    {
        public static void ConfigureContainer()
        {

            var builder = new ContainerBuilder();
            var dbContextOptionsBuilder =
                new DbContextOptionsBuilder<SwipesDbContext>().UseSqlServer(ConfigurationManager.ConnectionStrings["Swipes7417"].ConnectionString);

            builder.RegisterType<SwipesDbContext>().WithParameter("options", dbContextOptionsBuilder.Options).InstancePerLifetimeScope();

            builder.RegisterType<SwipeRepository>().WithParameter("connectionString", ConfigurationManager.ConnectionStrings["Swipes7417"].ConnectionString).SingleInstance();


            builder.RegisterType<SwipesCollectionService>().SingleInstance();


            var container = builder.Build();

            AutofacHostFactory.Container = container;
        }
    }
}
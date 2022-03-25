using CP_CW_7417.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;

namespace CP_CW_7417.WebService.DbContextFactory
{
    public class SwipesDbContextFactory : IDesignTimeDbContextFactory<SwipesDbContext>
    {
        public SwipesDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SwipesDbContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.
                ConnectionStrings["Swipes7417"].ConnectionString);

            return new SwipesDbContext(optionsBuilder.Options);
        }
    }
}
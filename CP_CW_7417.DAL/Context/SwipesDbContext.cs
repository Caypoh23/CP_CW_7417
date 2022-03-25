using CP_CW_7417.BLL.Models;
using Microsoft.EntityFrameworkCore;

namespace CP_CW_7417.DAL.Context
{
    public class SwipesDbContext : DbContext
    {
        #region Constructors

        public SwipesDbContext(DbContextOptions<SwipesDbContext> options)
           : base(options)
        {

        }
        public SwipesDbContext(string connectionStr)
         : base((new DbContextOptionsBuilder<SwipesDbContext>().UseSqlServer(
                    connectionStr)).Options)
        {
        }

        #endregion

        public virtual DbSet<Swipe> Swipes { get; set; }
    }
}

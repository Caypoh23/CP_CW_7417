using CP_CW_7417.BLL.Models;
using CP_CW_7417.DAL.Context;
using System.Collections.Generic;
using System.Linq;

namespace CP_CW_7417.DAL.Repositories
{
    public class SwipeRepository : IRepository
    {
        private readonly string _connectionString;

        public SwipeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        // add and save swipes to db
        public void AddSwipes(List<Swipe> swipes)
        {
            using (var context = new SwipesDbContext(_connectionString))
            {
                context.Swipes.AddRange(swipes);

                // save to db
                context.SaveChanges();
            }
        }

        // get all swipes
        public List<Swipe> GetSwipes()
        {
            using (var context = new SwipesDbContext(_connectionString))
            {
                return context.Swipes.ToList();
            }
        }
    }
}

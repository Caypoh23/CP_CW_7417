using CP_CW_7417.BLL.Models;
using System.Collections.Generic;

namespace CP_CW_7417.DAL.Repositories
{
    public interface IRepository
    {
        void AddSwipes(List<Swipe> swipes);
        List<Swipe> GetSwipes();
    }
}

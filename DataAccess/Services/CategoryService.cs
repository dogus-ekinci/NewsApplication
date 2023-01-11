using DataAccess.Contexts;
using DataAccess.Services.Bases;

namespace DataAccess.Services
{
    public class CategoryService : CategoryServiceBase
    {
        public CategoryService(Db dbContext) : base(dbContext)
        {
        }
    }
}

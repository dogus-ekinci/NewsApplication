using AppCore.DataAccess.Services;
using DataAccess.Contexts;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services.Bases
{
    public abstract class CategoryServiceBase : ServiceBase<Category>
    {
        public CategoryServiceBase(Db dbContext) : base(dbContext)
        {
        }
    }
}

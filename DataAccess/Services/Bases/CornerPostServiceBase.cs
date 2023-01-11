using AppCore.DataAccess.Services;
using DataAccess.Contexts;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services.Bases
{
    public abstract class CornerPostServiceBase : ServiceBase<CornerPost>
    {
        protected CornerPostServiceBase(Db dbContext) : base(dbContext)
        {
        }
    }
}

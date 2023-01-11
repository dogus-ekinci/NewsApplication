using AppCore.DataAccess.Services;
using DataAccess.Contexts;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services.Bases
{
    public abstract class NewsServiceBase : ServiceBase<News>
    {
        protected NewsServiceBase(Db dbContext) : base(dbContext)
        {
        }
    }
}

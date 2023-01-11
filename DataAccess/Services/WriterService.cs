using DataAccess.Contexts;
using DataAccess.Services.Bases;

namespace DataAccess.Services
{
    public class WriterService : WriterServiceBase
    {
        public WriterService(Db dbContext) : base(dbContext)
        {
        }
    }
}

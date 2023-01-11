using DataAccess.Contexts;
using DataAccess.Services.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class CornerPostService : CornerPostServiceBase
    {
        public CornerPostService(Db dbContext) : base(dbContext)
        {
        }
    }
}

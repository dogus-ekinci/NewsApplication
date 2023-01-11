﻿using AppCore.DataAccess.Services;
using DataAccess.Contexts;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services.Bases
{
    public abstract class WriterServiceBase : ServiceBase<Writer>
    {
        protected WriterServiceBase(Db dbContext) : base(dbContext)
        {
        }
    }
}

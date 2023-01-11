using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts
{
    public class Db : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<CornerPost> CornerPosts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<CornerPostDetail> CornerPostDetails { get; set; }


        public Db(DbContextOptions options) : base(options)
        {
        }

    }
}

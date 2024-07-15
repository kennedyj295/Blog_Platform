using Microsoft.EntityFrameworkCore;
using blog_api.Entities;

namespace blog_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }



    }
}

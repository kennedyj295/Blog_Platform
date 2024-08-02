using Microsoft.EntityFrameworkCore;
using blog_api.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace blog_api.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }



    }
}

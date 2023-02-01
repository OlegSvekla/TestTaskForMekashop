using Microsoft.EntityFrameworkCore;
using TestTaskForMekashop.DOMAIN.Entity;

namespace TestTaskForMekashop.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }               
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using FirstWebApplication.Models;

namespace FirstWebApplication.Models


{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<FirstWebApplication.Models.Car>? Car { get; set; }
        public DbSet<FirstWebApplication.Models.Owner>? Owner { get; set; }

        
    }
}

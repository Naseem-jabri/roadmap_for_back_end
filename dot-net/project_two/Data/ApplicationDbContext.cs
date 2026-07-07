using Microsoft.EntityFrameworkCore;
using EshopAPI.Models;

namespace EshopAPI.Data
    
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}

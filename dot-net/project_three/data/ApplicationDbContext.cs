using Microsoft.EntityFrameworkCore;
using Task_Management_System.Model;

namespace Task_Management_System.data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<TaskItem> Tasks { get; set; }
    }
}

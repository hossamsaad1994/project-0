using Microsoft.EntityFrameworkCore;

namespace Project_1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Information> Informations { get; set; }
    }
}

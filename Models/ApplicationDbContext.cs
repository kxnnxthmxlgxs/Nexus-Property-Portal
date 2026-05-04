using Microsoft.EntityFrameworkCore;

namespace NexusPropertyPortal.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // This line tells .NET to create a table called "Properties" based on our Model
        public DbSet<Property> Properties { get; set; }
    }
}

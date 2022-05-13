using Microsoft.EntityFrameworkCore;

namespace gwCloudAssessment.Context
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options): base(options)
        {
        }

       public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasIndex(c=>c.Name)
                .IsUnique();
        }

    }
}

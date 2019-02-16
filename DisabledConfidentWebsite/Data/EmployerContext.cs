using DisabledConfidentWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace DisabledConfidentWebsite.Data
{
    public class EmployerContext : DbContext
    {
        public EmployerContext(DbContextOptions<EmployerContext> options) : base(options)
        {
        }

        public DbSet<Employer> Employers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employer>().ToTable("Employer");
        }
    }
}

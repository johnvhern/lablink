using lablink.app.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lablink.app.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Patients> Patients => Set<Patients>();
        public DbSet<Models.Results> Results => Set<Models.Results>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Patients>()
               .ToTable("Patients", t => t.HasCheckConstraint(
                   "CK_BirthDate_MinDate",
                   "[DOB] >= '1900-01-01'"
                   ));

            builder.Entity<Models.Results>()
                .HasIndex(r => r.ReferenceNo)
                .IsUnique();
        }
    }
}

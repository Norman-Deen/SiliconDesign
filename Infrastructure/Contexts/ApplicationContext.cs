using Infrastructure.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class ApplicationContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }



    public DbSet<ApplicationUser> applicationUsers { get; set; }
    public DbSet<CourseEntity> Courses { get; set; }
    public DbSet<SubscriberEntity> Subscribers { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityUserLogin<string>>().HasKey(x => new { x.LoginProvider, x.ProviderKey });

        CourseConfiguration.Configure(modelBuilder);
    }
}


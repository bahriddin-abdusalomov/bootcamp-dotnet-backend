using JWT.Auth.Configurations;
using JWT.Auth.Models;
using Microsoft.EntityFrameworkCore;

namespace JWT.Auth.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { 
    }

    public DbSet<User> Users { get; set; }
    public DbSet<PassportData> PassportData { get; set; }
    public DbSet<Car> Cars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsersConfiguration());
        modelBuilder.ApplyConfiguration(new CarsConfiguration());
        modelBuilder.ApplyConfiguration(new PassportDataConfiguration());
    }
}

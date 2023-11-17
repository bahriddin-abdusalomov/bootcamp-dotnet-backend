using Education.API.Configurations;
using Education.API.Models.Students;
using Education.API.Models.Teachers;
using Education.API.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Education.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}

    public DbSet<User> Users { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsersConfiguration());
        modelBuilder.ApplyConfiguration(new StudentsConfiguration());
        modelBuilder.ApplyConfiguration(new TeacherConfiguration());
    }
}

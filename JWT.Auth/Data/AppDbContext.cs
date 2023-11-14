using JWT.Auth.Models;
using Microsoft.EntityFrameworkCore;

namespace JWT.Auth.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<User> Users { get; set; }
}

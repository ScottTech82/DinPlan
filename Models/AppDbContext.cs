using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DinnerPlanner.Models;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Meal> Meals { get; set; }


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) { }

}

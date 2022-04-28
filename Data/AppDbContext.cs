using App.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<Race> Races { get; set; }

    public DbSet<Car> Cars { get; set; }

    public DbSet<Category> Category { get; set; }

    public DbSet<ApplicationUser> ApplicationUser { get; set;}


    public DbSet<RaceResult> RaceResults { get; set; }
    public DbSet<ResultItem> ResultItem { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Car>()
            .HasOne(p => p.Category)
            .WithMany(b => b.Cars);
        modelBuilder.Entity<UserCar>()
        .HasKey(bc => new { bc.CarId, bc.ApplicationUserId });  
        modelBuilder.Entity<UserCar>()
            .HasOne(bc => bc.Car)
            .WithMany(b => b.UserCars)
            .HasForeignKey(bc => bc.CarId);  
        modelBuilder.Entity<UserCar>()
            .HasOne(bc => bc.ApplicationUser)
            .WithMany(c => c.UserCars)
            .HasForeignKey(bc => bc.ApplicationUserId);
    
    }
}
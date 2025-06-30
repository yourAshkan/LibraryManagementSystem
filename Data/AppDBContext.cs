using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LibraryManagementSystem.Data;

public class AppDBContext : DbContext
{
    public DbSet<Book> books { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Borrow> Borrows { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configBuilder = new ConfigurationBuilder();
        var configuration = configBuilder.AddJsonFile(@"appsetting.json").Build();
        var configSection = configuration.GetSection("ConnectionString");
        var configString = configSection["DBConnection"];

        optionsBuilder.UseSqlServer(configString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>()
            .HasIndex(x => x.NationalCode)
            .IsUnique();

        modelBuilder.Entity<Member>()
            .Property(x => x.NationalCode)
            .HasMaxLength(10)
            .HasMaxLength(10);

        modelBuilder.Entity<Book>()
            .HasIndex(x => x.ISBN)
            .IsUnique();
    }
}

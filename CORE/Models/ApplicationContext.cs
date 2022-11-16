using Microsoft.EntityFrameworkCore;

namespace CORE.Models;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public ApplicationContext() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=176.124.209.251;Database=helloappdb;Trusted_Connection=True;User ID=guest;Password=18072004;");
    }
}
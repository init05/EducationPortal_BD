using Microsoft.EntityFrameworkCore;

namespace CORE.Models;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public ApplicationContext() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=sql7.freemysqlhosting.net;database=sql7579116;user=sql7579116;password=w7py4kVcVR;",
            new MySqlServerVersion(new Version(8, 0, 25)));
    }
}
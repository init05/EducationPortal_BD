using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataContext;

public class DALContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    private string connetionString = @"server=sql7.freemysqlhosting.net;database=sql7579116;user=sql7579116;password=w7py4kVcVR;";
    public DALContext(DbContextOptions<DALContext> options):base() { }
    public DALContext() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connetionString, new MySqlServerVersion(new Version(8, 0, 25)));
    }
}
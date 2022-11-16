using CORE.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataBase;

public class DALContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    private string connetionString = @"Data Source=176.124.209.251;Initial Catalog=helloapdb;User ID=guest;Password=18072004";
    public DALContext(DbContextOptions<DALContext> options):base()
    {
        
    }
    public DALContext()
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connetionString);
    }
}
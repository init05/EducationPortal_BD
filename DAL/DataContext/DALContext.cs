using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DAL.DataContext;

public class DALContext : DbContext
{
    public class OptionsBuild
    {
        public DbContextOptionsBuilder<DALContext> OptionsBuilder { get; set; }
        public DbContextOptions<DALContext> DbOptions { get; set; }
        AppConfiguration settings { get; set; }
        public OptionsBuild()
        {
            settings = new AppConfiguration();
            OptionsBuilder = new DbContextOptionsBuilder<DALContext>();
            OptionsBuilder.UseMySql(settings.SqlConnectionString, new MySqlServerVersion(new Version(8, 0, 25)));
            DbOptions = OptionsBuilder.Options;
        }   
        
    }
    public static OptionsBuild options = new OptionsBuild();
    public DbSet<User> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DALContext(DbContextOptions<DALContext> options) : base(options) => Database.EnsureCreated();
    public DALContext() => Database.EnsureCreated();

}
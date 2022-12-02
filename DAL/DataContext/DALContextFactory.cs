using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL.DataContext;

public class DALContextFactory : IDesignTimeDbContextFactory<DALContext>
{
    public DALContext CreateDbContext(string[] args)
    {
        AppConfiguration appConfiguration = new AppConfiguration();
        var options = new DbContextOptionsBuilder<DALContext>();
        options.UseMySql(appConfiguration.SqlConnectionString, new MySqlServerVersion(new Version(8, 0, 25)));
        return new DALContext(options.Options);
    }
}
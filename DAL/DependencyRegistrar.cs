using DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL;

public class DependencyRegistrar
{
    public static void ConfigureServices(IServiceCollection services)
    {

        services.AddDbContext<DALContext>(options =>
            options.UseSqlServer(@"Data Source=176.124.209.251;Initial Catalog=helloapdb;User ID=guest;Password=18072004"));
    }
}
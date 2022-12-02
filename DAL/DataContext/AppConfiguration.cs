using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration;

namespace DAL.DataContext;

public class AppConfiguration
{
    public string SqlConnectionString { get; set; }

    public AppConfiguration()
    {
        IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
        string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "EducationPortal_solo");
        path = Path.Combine(path, "appsettings.json");
        Console.WriteLine(path);
        configurationBuilder.AddJsonFile(path, false);
        IConfigurationRoot root = configurationBuilder.Build();
        IConfigurationSection appSettings = root.GetSection("ConnectionStrings:EducationPortal_Solo");
        SqlConnectionString = appSettings.Value;
    }
}
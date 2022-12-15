using EducationPortal_Solo.APIs;
using EducationPortal_Solo.Bootstraper;

class Program
{
    static void Main(string[] args)
    {
        // Build app
        var app = AppBuilder.GetApp(args);
        
        // Configure app
        PipelineBuilder.Configure(app);
        
        // Connect end-points
        UsersApi.RegisterApis(app);
        
        // Run
        app.Run();

    }
}
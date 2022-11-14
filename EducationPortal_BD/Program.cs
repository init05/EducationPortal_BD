using CORE.Models;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            User user1 = new User("Denis", "123", "myEmal", true);
            User user2 = new User("notDenis", "321", "notMyEmal", false);

            db.Users.Add(user1);
            db.Users.Add(user2);
            db.SaveChanges();

            var users = db.Users.ToList();
            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.UserName} - Password: {user.Password}");
                Console.WriteLine($"Email: {user.Email} - IsAdmin: {user.Root}");
            }
        }

        Console.Read();
    }
}

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public ApplicationContext() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
    }
}
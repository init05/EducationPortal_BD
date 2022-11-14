using CORE.Models;

namespace CORE.Controllers;

public class UserController
{
    public void Register(User user)
    {
        using(ApplicationContext db = new ApplicationContext())
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        Console.WriteLine($"New user: {user.UserName} was created and added to db");
    }

    public void Login(User user)
    {
        using(ApplicationContext db = new ApplicationContext())
        {
            User? currUser = db.Users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            if (currUser != null)
            {
                Console.WriteLine($"You are logged in as {currUser.UserName}");
            }
            else
            {
                Console.WriteLine("There is no such user!");
            }
        }
    }

    public List<User> GetUsers()
    {
        using(ApplicationContext db = new ApplicationContext())
        {
            return db.Users.ToList();
        }
    }
}
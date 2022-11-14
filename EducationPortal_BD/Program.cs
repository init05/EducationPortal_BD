using CORE.Controllers;
using CORE.Models;

class Program
{
    static void Main(string[] args)
    {
        UserController userController = new UserController();

        var denis = new User("Denis", "123", "MyEmail", true);
        userController.Register(denis);
        userController.Register(new User("NotDenis", "321", "NotMyEmail", false));
        
        userController.Login(denis);
        userController.Login(new User("1", "2", "3", false));

        var users = userController.GetUsers();
        foreach (var user in users)
        {
            Console.WriteLine($"{user.UserName} - {user.Email}");
        }
    }
}
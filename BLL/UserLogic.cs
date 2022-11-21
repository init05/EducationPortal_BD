using DAL.Controllers;
using DAL.Interfaces;
using DAL.Models;

namespace BLL;

public class UserLogic
{
    IUser _userController = new UserController();

    public async Task Register(string username, string password, string email, bool root)
    {
        User newUser = new User(username, password, email, root);
        try
        {
            await _userController.AddUser(newUser);
            Console.WriteLine($"New user {newUser.UserName} has been registered!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    public async Task Login(string username, string password)
    {
        User loginUser = new User(username, password);
        List<User> users = await _userController.GetUsers();
        User? currUser = users.FirstOrDefault(x => x.UserName == loginUser.UserName && x.Password == loginUser.Password);
        Console.WriteLine(currUser != null ? $"You are logged in as {currUser.UserName}" : "There is no such user!");
    }
    
}
using BLL;
using DAL.Controllers;
using DAL.DataContext;
using DAL.Models;

class Program
{
    static async Task Main(string[] args)
    {
        UserLogic userLogic = new UserLogic();
        await userLogic.Register("Denis", "123", "myEmail", true);
        await userLogic.Login("Denis", "123");
        await userLogic.Login("Denis", "321");
    }
}
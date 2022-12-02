using DAL.DataContext;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Controllers;

public class UserController: IUser
{
    public async Task<User> AddUser(User user)
    {
        await using(DALContext db = new DALContext(DALContext.options.DbOptions))
        {
            await db.Users.AddAsync(user);
            await db.SaveChangesAsync();
        }
        
        return user;
    }

    public async Task<List<User>> GetUsers()
    {
        List<User> users = new List<User>();
        await using(DALContext db = new DALContext(DALContext.options.DbOptions))
        {
            users = await db.Users.ToListAsync();
        }

        return users;
    }
}
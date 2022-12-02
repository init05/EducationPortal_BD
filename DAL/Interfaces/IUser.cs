using DAL.Models;

namespace DAL.Interfaces;

public interface IUser
{
    Task<User> AddUser(User user);
    Task<List<User>> GetUsers();
}
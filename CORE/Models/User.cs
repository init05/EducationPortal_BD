namespace CORE.Models;

public class User
{
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public int Id { get; set; }
    public bool Root { get; set; }

    public User(string userName, string password, string email, bool root)
    {
        UserName = userName;
        Password = password;
        Email = email;
        Root = root;
    }
}
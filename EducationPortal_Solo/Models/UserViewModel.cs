namespace EducationPortal_Solo.Models;

public class UserViewModel
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public bool Root { get; set; }
    
    public UserViewModel(string userName, string email, bool root, int id)
    {
        Id = id;
        UserName = userName;
        Email = email;
        Root = root;
    }
}
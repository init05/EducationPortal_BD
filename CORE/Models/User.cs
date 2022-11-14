using System.ComponentModel.DataAnnotations;

namespace CORE.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "UserName is required!")]
    public string? UserName { get; set; }
    [Required(ErrorMessage = "Password is required!")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
    [Required(ErrorMessage = "Email is required!")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "Root is required!")]
    public bool Root { get; set; }

    public User(string userName, string password, string email, bool root)
    {
        UserName = userName;
        Password = password;
        Email = email;
        Root = root;
    }
}
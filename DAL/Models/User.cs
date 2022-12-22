using System.ComponentModel.DataAnnotations;

namespace DAL.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "UserName is required!")]
    public string? UserName { get; set; }
    [Required(ErrorMessage = "Password is required!")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
    [Required(ErrorMessage = "Password is required!")]
    [DataType(DataType.Password)]
    [Compare("Password")]
    public string? ConformationPassword { get; set; }
    [Required(ErrorMessage = "Email is required!")]
    [EmailAddress]
    public string? Email { get; set; }
    [Required(ErrorMessage = "Root is required!")]
    public bool Root { get; set; }

    public User(string userName, string password, string conformationPassword, string email, bool root)
    :this(userName, password)
    {
        ConformationPassword = conformationPassword;
        Email = email;
        Root = root;
    }

    public User(string userName, string password)
    {
        UserName = userName;
        Password = password;
        Email = String.Empty;
        Root = false;
    }

    public User() { }
}
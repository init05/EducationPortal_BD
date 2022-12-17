namespace EducationPortalBlazorApp.Models;


public class UserView
{
    public int Id { get; set; }
    
    public string? UserName { get; set; }
    
    public string? Email { get; set; }
    
    public bool Root { get; set; }
}
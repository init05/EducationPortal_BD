using System.Net.Http.Json;

namespace EducationPortalBlazorApp.Services;

public class User
{
    public int Id { get; set; }
    
    public string? UserName { get; set; }
    
    public string? Email { get; set; }
    
    public bool Root { get; set; }
}

public class UserApiClient
{
    readonly HttpClient httpClient;

    public UserApiClient(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<List<User>?> GetUsersAsync()
    {
        try
        {
            var response = await httpClient.GetAsync("/users");

            if (response.IsSuccessStatusCode)
            {
                var students = await response.Content.ReadFromJsonAsync<List<User>>();
                return students;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return new List<User>();
    }
}
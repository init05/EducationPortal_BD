using System.Net.Http.Json;
using DAL.Models;
using EducationPortalBlazorApp.Models;

namespace EducationPortalBlazorApp.Services;


public class UserApiClient
{
    readonly HttpClient httpClient;

    public UserApiClient(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<List<UserView>?> GetUsersAsync()
    {
        try
        {
            var response = await httpClient.GetAsync("/users");

            if (response.IsSuccessStatusCode)
            {
                var students = await response.Content.ReadFromJsonAsync<List<UserView>>();
                return students;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return new List<UserView>();
    }

    public async Task AddUser(User user)
    {
        try
        {
            var response = await httpClient.PostAsJsonAsync<User>("/users", user);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
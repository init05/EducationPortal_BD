using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using DAL.Models;
using EducationPortal_Solo.Models;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationPortal_Solo.APIs;

public static class UsersApi
{
    static UserLogic _userLogic = new UserLogic();
        
    public static void RegisterApis(WebApplication app)
    {
        // GET all users
        app.MapGet("/users", async () =>
        {
            List<UserViewModel> viewModels = new List<UserViewModel>();
            var users = await _userLogic.GetAllUsers();
            if (users.Count > 0)
            {
                foreach (var user in users)
                {
                    UserViewModel currViewModel = new UserViewModel(user.UserName, user.Email, user.Root, user.Id);
                    viewModels.Add(currViewModel);
                }
            }

            return viewModels;
        }).WithName("GetUsers");

        // Register new user
        app.MapPost("/users", async (User user) =>
        {
            await _userLogic.Register(
                user.UserName, 
                user.Password, 
                user.ConformationPassword, 
                user.Email, 
                user.Root);
        }).WithName("Register");
    }
}
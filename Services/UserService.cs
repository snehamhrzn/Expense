﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public class UserService : IUserService
    {
        private User user = new User
        {
            UserName = "Sneha",
            Password = "Sneha123"
        };

        public async Task<bool> ValidateUserAsync(string username, string password)
        {

            // Check if the credentials match the stored user
            return user.UserName == username && user.Password == password;
        }



    }
}
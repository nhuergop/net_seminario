﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UserApp.Models;

namespace UserApp.Services
{
    public class UserService : IUserService
    {
        public void CreateUser(UserModel userModel)
        {
            //create user in database
            //
            var num = 1;
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserModel userModel)
        {
            throw new NotImplementedException();
        }
    }
}

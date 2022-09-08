using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UserApp.Models;

namespace UserApp.Services
{
    public interface UserServices
    {
        public void CreateUser(UserModel userModel);

        public void UpdateUser(UserModel userModel);

        public UserModel GetUser(int id);

        public List<UserModel> GetUsers();

        public void DeleteUser(int id);


    }
}

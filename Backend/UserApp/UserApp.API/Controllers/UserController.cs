using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using UserApp.Models;

namespace UserApp.API.Controllers
{
    // estos son decoradores 
    [Route("api/[controller]")]
    [ApiController]
 
    // : indica que hereda
    public class UserController : ControllerBase
    {
        // GET USER
        [HttpGet]
        public UserModel GetUser(int userId)
        {
            return new UserModel() { UserId = 1, UserName = "Nico" };

        }
       

        // GET USERS


        // POST USER


        // PUT USER


        // DELETE USER
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using UserApp.Services;
using UserApp.Models;

namespace UserApp.API.Controllers
{
    // estos son decoradores 
    [Route("api/[controller]")]
    [ApiController]

    // : indica que hereda
    public class UserControler : ControlerBase
    {
        private readonly UserService userService;

        public UserControler(UserServiceImp userService)
        {
            this.userService = userService;
        }


        // GET USERS
        [HttpGet("{userId}")]
        public ActionResult<UserModel> GetUser([FromRoute] int userId)
        {
            return new UserModel()
            {
                UserId = 1,
                UserName = "Nicolas Huergo",
                DNI = "33323365",
                Email = "nhuergop@gmail.com"
            };
        }

        // GET ALL USERS
        [HttpGet]
        public ActionResult<List<UserModel>> GetUsers()
        {
            var result = new List<UserModel>();

            result.Add(new UserModel
            {
                UserId = 1,
                UserName = "Nicolás Huergo",
                DNI = "33323365",
                Email = "nhuergop@gmail.com",
            });
            result.Add(new UserModel
            {
                UserId = 2,
                UserName = "Pablo Amerisso",
                DNI = "34243225",
                Email = "pabloamerisso@gmail.com",
            });

            return result;
        }

        // POST USER
        [HttpPost]
        public ActionResult CreateUser([FromBody] UserModel user)
        {
            // llama a servicios
            var su = new UserServiceImp();

            su.CreateUser(user);
            return Ok();
        }

        // PUT USER
        [HttpPut("id")]
        public ActionResult UpdateUser([FromRoute] int id, [FromBody] UserModel user)
        {
            if (id == -1)
                return NoContent();
            return Ok();
        }

        // DELETE USER
        [HttpDelete("id")]
        public ActionResult DeleteUser([FromRoute] int id)
        {
            return Ok();
        }

        // PATCH
        [HttpPatch("{id}/[Action]", Name = "Activate")]
        public ActionResult Activate([FromRoute] int id)
        {
            return Ok();
        }
       
        [HttpPatch("{id}/[Action]", Name = "Inactivate")]
        public ActionResult Inactivate([FromRoute] int id)
        {
            return Ok();
        }



    }
}

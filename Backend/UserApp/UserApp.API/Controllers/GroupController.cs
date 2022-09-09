using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using UserApp.Models;
using UserApp.Services;


namespace UserApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        // es una buena practica usar las interfaces y no las clases
        // porque, a medida que vas mas alto en las capas de codigo, podes reutilizarlo mejor ¿?
        private readonly IGroupService _groupService;

        public GroupController(IGroupService groupService)
        {
            this._groupService = groupService;
        }


        // GET GROUP
        [HttpGet("{groupId}")]
        public ActionResult<GroupModel> Group([FromRoute] int groupId)
        {
            // var service = new GroupService();
            return _groupService.GetGroup(groupId);
        }

        // GET GROUPS
        [HttpGet]
        public ActionResult<List<GroupModel>> GetGroups()
        {
            var result = new List<GroupModel>();

            result.Add(new GroupModel
            {
                groupId = 1,
                groupName = "Rebels",
                Status = "ACTIVE",
                LastUpdateBy = "Nicolás Huergo"
            });
            result.Add(new GroupModel
            {
                groupId = 2,
                groupName = "Liberals",
                Status = "ACTIVE",
                LastUpdateBy = "Ramón Huergo"
            });

            return result;
        }

        // POST GROUP
        [HttpPost]
        public ActionResult CreateGroup([FromBody] GroupModel group) // [FromBody] [FromRoute] ??? @
        {
            /* INYECTAR DEPENDENCIA:
             * 1. ver punto 05 de clase_05.txt
             */
            _groupService.CreateGroup(group);

            return Ok();
        }

        // PUT USER
        [HttpPut("id")]
        public ActionResult UpdateGroup([FromRoute] int id, [FromBody] GroupModel group)
        {
            if (id == -1)
                return NoContent();
            return Ok();
        }

        // DELETE USER
        [HttpDelete("id")]
        public ActionResult DeleteGroup([FromRoute] int id)
        {
            return Ok();
        }

        // ACTIVATE
        [HttpPatch("{id}/[Action]")]





    }
}

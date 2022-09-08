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

        private readonly GroupServiceImp? groupService;

        public GroupController(GroupServiceImp? groupService)
        {
            this.groupService = groupService;
        }


        // GET GROUP
        [HttpGet("{groupId}")]
        public ActionResult<GroupModel> Group([FromRoute] int groupId)
        {
            var service = new GroupServiceImp();
            return groupService.GetGroup(groupId);
        }

        // GET GROUPS
        [HttpGet]
        public ActionResult<List<GroupModel>> GetGroups()
        {
            var result = new List<GroupModel>();

            result.Add(new GroupModel
            {
                groupId = 1,
                groupName="Rebels",
                Disabled=false,
                LastUpdateBy="Nicolás Huergo"
            });
            result.Add(new GroupModel
            {
                groupId = 2,
                groupName = "Liberals",
                Disabled = false,
                LastUpdateBy = "Ramón Huergo"
            });

            return result;
        }

        // POST USER
        [HttpPost]
        public ActionResult CreateGroup([FromBody] GroupModel group)
        {
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






    }
}

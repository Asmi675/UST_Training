using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPICRUD.Model;
using WebAPICRUD.Services;

namespace WebAPICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnduserController : ControllerBase
    {
        private readonly IEnduserService _EnduserService;

        public EnduserController(IEnduserService EnduserService)
        {
            _EnduserService = EnduserService;
        }

        [HttpGet]`
        public IActionResult Get([FromQuery] bool? isActive = null)
        {
            return Ok(_EnduserService.GetAllEndusers(isActive));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var User = _EnduserService.GetUserByID(id);
            if (User == null)
            {
                return NotFound();
            }
            return Ok(User);
        }

        [HttpPost]
        public IActionResult Post(AddUpdateEnduser UserObject)
        {
            var User = _EnduserService.AddUser(UserObject);

            if (User == null)
            {
                return BadRequest();
            }

            return Ok(new
            {
                message = "Super Hero Created Successfully!!!",
                id = User!.Id
            });
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] AddUpdateEnduser UserObject)
        {
            var User = _EnduserService.UpdateUser(id, UserObject);
            if (User == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                message = "Super Hero Updated Successfully!!!",
                id = User!.Id
            });
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            if (!_EnduserService.DeleteUserByID(id))
            {
                return NotFound();
            }

            return Ok(new
            {
                message = "Super Hero Deleted Successfully!!!",
                id = id
            });
        }
    }
}

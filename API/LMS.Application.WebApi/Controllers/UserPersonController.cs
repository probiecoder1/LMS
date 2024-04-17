using LMS.Application.Service.UserPerson;
using LMS.Application.Model;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Application.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserPersonController : ControllerBase
    {
        IUserPersonService _userPersonService;
        public UserPersonController(IUserPersonService userPersonService)
        {
            _userPersonService = userPersonService;
        }
        [HttpGet]
        public IActionResult GetUserPerson(String Json)
        {
            try
            {
                var userPerson = _userPersonService.GetUserPerson(Json);
                return Ok(userPerson);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult UserPersonTsk([FromBody] MvJson Json)
        {
            try
            {
                var userPerson = _userPersonService.UserPersonTsk(Json.Json);
                return Ok(userPerson);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}

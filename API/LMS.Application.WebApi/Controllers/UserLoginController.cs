using LMS.Application.Service.UserLogin;
using LMS.Application.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LMS.Application.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        IUserLoginService _userLoginService;

        public UserController(IUserLoginService userLoginService)
        {
            _userLoginService = userLoginService;
        }

        [HttpGet]
        public IActionResult GetUserLogin(string json)
        {
            try
            {
                var userLogins = _userLoginService.GetUserLogin(json);
                return Ok(userLogins);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

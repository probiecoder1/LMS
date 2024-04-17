using LMS.Application.Service.Membership;
using LMS.Application.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LMS.Application.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MembershipController : ControllerBase
    {
        IMembershipService _membershipService;

        public MembershipController(IMembershipService membershipService)
        {
            _membershipService = membershipService;
        }

        [HttpGet]
        public IActionResult GetMembership(string json)
        {
            try
            {
                var memberships = _membershipService.GetMembership(json);
                return Ok(memberships);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

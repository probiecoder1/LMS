using LMS.Application.Service.Borrow;
using LMS.Application.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LMS.Application.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BorrowController : ControllerBase
    {
        IBorrowService _borrowService;

        public BorrowController(IBorrowService borrowService)
        {
            _borrowService = borrowService;
        }

        [HttpGet]
        public IActionResult GetBorrow(string json)
        {
            try
            {
                var borrows = _borrowService.GetBorrow(json);
                return Ok(borrows);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult BorrowBook([FromBody] MvJson json)
        {
           try
           {
                var borrow = _borrowService.BorrowTsk(json.Json);
                return Ok(borrow);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

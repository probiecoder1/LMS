using LMS.Application.Service.Book;
using LMS.Application.Service.Common;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Application.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CommonController : ControllerBase
    {
        ICommonService _commonService;
        public CommonController(ICommonService commonService)
        {
            _commonService = commonService;
        }

        [HttpGet]
        public IActionResult GetRecent(string json)
        {
            try
            {
                var books = _commonService.GetRecent(json);
                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetTotal(string json)
        {
            try
            {
                var total = _commonService.GetTotal(json);
                return Ok(total);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetUserBooks(string json)
        {
            try
            {
                var total = _commonService.GetUserBooks(json);
                return Ok(total);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetUserPayments(string json)
        {
            try
            {
                var total = _commonService.GetUserPayments(json);
                return Ok(total);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

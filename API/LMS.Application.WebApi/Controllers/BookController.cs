using LMS.Application.Service.Book;
using LMS.Application.Model;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Application.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BookController : ControllerBase
    {
        IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetBook(string json)
        {
            try
            {
                var books = _bookService.GetBook(json);
                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult BookTsk([FromBody] MvJson json)
        {
            try
            {
                var book = _bookService.BookTsk(json.Json);
                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult IssueBook([FromBody] MvJson json)
        {
            try
            {
                var issueTask = _bookService.Issue(json.Json);
                return Ok(issueTask);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An unexpected error occurred.");
            }
        }

        [HttpPost]
        public IActionResult Return([FromBody] MvJson json)
        {
            try
            {
                var issueTask = _bookService.Return(json.Json);
                return Ok(issueTask);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An unexpected error occurred.");
            }
        }
    }
}

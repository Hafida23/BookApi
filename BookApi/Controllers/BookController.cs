using BookApi.Data;
using BookApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookServices _bookservices;
        public BookController(BookServices bookservices)
        {
            _bookservices = bookservices;
        }

        [HttpGet("get-all-books")]  
        public IActionResult GetAllBooks()
        {
            var allBooks = _bookservices.GetAllBooks();
            return Ok(allBooks);
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _bookservices.AddBook(book);
            return Ok(book);
        }
        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBookById(int id)
        {
           var book= _bookservices.GetBookById(id);  
           
            return Ok(book);
        }
        [HttpDelete("deleteBook/{id}")]
        public IActionResult DeleteBookById(int id)
        {
             _bookservices.DeleteBookById(id);

            return Ok();
        }

    }
}

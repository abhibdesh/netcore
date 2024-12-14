using CoreTrainingDayTwo08122024.DAL;
using CoreTrainingDayTwo08122024.Models;
using CoreTrainingDayTwo08122024.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreTrainingDayTwo08122024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookService service;
        public BookController(IBookService _service) {
            service = _service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Book> books = service.GetAllBooks();
            return Ok(books);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try { 
                var book = service.GetBookById(id); 
                return Ok(book);
            
            }
            catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            try
            {
                var _book = service.AddBook(book);
                return Created($"~api/Book/{book.BookId}", book);
            }
            catch (Exception ex) { 
                return BadRequest($"{ex.Message}");
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Book book)
        {
            try {
                var result = service.updateBook(id, book);
                if(result) return Ok(result);
                else return NotFound($"The book with id {id} was not found in the db");
            }
            catch (Exception ex) {
                return BadRequest($"{ex.Message}");

            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try { 
                bool isDeleted = service.DeleteBook(id);
                return Ok(isDeleted);
            }
            catch (Exception ex) {
                return BadRequest($"{ex.Message}");

            }
        }
    }
}

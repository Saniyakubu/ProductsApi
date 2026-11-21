using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Data;
using ProductsApi.models;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET 

        [HttpGet("all")]
        public ActionResult<BookData> getAllBooks()
        {
            return Ok(Books.bookList);
        }

        //GET BY ID

        [HttpGet("{bookId}")]
        public ActionResult<BookData> getBookById(int BookId)
        {
            var book = Books.bookList.Find(b => b.Id == BookId);
            if (book == null) return NotFound();

            return Ok(book);
        }

        // POST / Create New Book

        [HttpPost]
        public ActionResult<BookData> createBook(BookData newBook)
        {
            if (newBook == null) return BadRequest();

            Books.bookList.Add(newBook);

            return CreatedAtAction(nameof(getBookById), new { BookId = newBook.Id }, newBook);
        }

        // PUT / Update book

        [HttpPut]
        public IActionResult updateBook(int bookId, BookData updatedBook)
        {


            var selectedBook = Books.bookList.FirstOrDefault(book => book.Id == bookId);
            if (selectedBook == null) return NotFound();

            selectedBook.Title = updatedBook.Title != string.Empty ? updatedBook.Title : selectedBook.Title;
            selectedBook.Author = updatedBook.Author != string.Empty ? updatedBook.Author : selectedBook.Author;
            selectedBook.Price = updatedBook.Price;
            selectedBook.Genre = updatedBook.Genre != string.Empty ? updatedBook.Genre : selectedBook.Genre;
            selectedBook.IsAvailable = updatedBook.IsAvailable;

            return NoContent();

        }

        // DELETE 
        [HttpDelete("{bookID}")]
        public IActionResult deleteBook(int bookId)
        {
            var selectedBook = Books.bookList.FirstOrDefault(book => book.Id == bookId);
            if (selectedBook == null) return NotFound();

            Books.bookList.Remove(selectedBook);

            return NoContent();

        }

        // GET BY STATUS 
        [HttpGet("status/{status}")]
        public ActionResult<BookData> findByStatus(bool status)
        {
            Console.WriteLine(status);
            var book = Books.bookList.FindAll(book => book.IsAvailable == status);
            if (book == null) return NotFound();

            return Ok(book);

        }

    }
}

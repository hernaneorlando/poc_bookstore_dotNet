using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Bs.Domain.Services;
using Bs.Web.Models;
using Bs.Web.Models.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bs.Web.Controllers
{
    [ApiController]
    [Route("api/")]
    public class BookstoreController : ControllerBase
    {
        public readonly IBookService bookService;

        public BookstoreController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet("books", Name = nameof(GetBooks))]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<BookDto>> GetBooks()
        {
            var books = await bookService.FindAll();
            return Ok(books.Select(b => b.ToDto()));
        }

        [HttpGet("books/{id}", Name = nameof(GetBook))]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<BookDto>> GetBook(long id)
        {
            var book = await bookService.FindById(id);
            return Ok(book.ToDto());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace spa_bookshelf.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<Book> GetAllBooks()
        {
            Console.WriteLine("Hitting an enpoint: book/all");

            List<Book> books = new List<Book>();

            Book firstBook = new Book();
            firstBook.Title = "The C Programming Language";
            firstBook.Author = "Briand Kernighan";
            firstBook.Editorial = "Pearson";
            firstBook.YearOfPublication = 1988;
            books.Add(firstBook);

            Book secondBook = new Book();
            secondBook.Title = "Pro C#";
            secondBook.Author = "Andrew Troelsen";
            firstBook.Editorial = "Apress";
            secondBook.YearOfPublication = 2020;
            books.Add(secondBook);

            return books;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace spa_bookshelf.Controllers
{
	[ApiController]
	[Route("[Controller]")]
	public class BooksController : ControllerBase
	{
		private readonly ILogger<BooksController> _logger;

		public BooksController(ILogger<BooksController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IEnumerable<Book> Get()
		{
			Console.WriteLine("Getting books data from Get()");

			List<Book> theBooks = new List<Book>();

			Book firstBook = new Book 
			{
				Title = "The C Programming Language"
			};

			Book secondBook = new Book	
			{
				Title = "Head First Design Patterns"
			};

			theBooks.Add(firstBook);
			theBooks.Add(secondBook);

			return theBooks.ToArray();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication_test.Classes;
using WebApplication_test.Interfaces;
using SimpleInjector;

namespace WebApplication_test.Controllers
{
	public class BookController : Controller
	{
		private readonly IBookService bookService;

		public BookController(IBookService service) 
		{ 
			bookService = service;
		}

		public ActionResult GetAllBooks()
		{
			var booklist = bookService.GetAllBooks();
			return new JsonResult { Data = booklist, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
		}

		[HttpGet]
		public ActionResult GetBook(int id)
		{
			var selectedBook = this.bookService.GetBook();
			if (selectedBook == null)
			{
				return new HttpStatusCodeResult(404);
			}
			return new JsonResult { Data = selectedBook, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
		}

		[HttpPost]
		public ActionResult AddBook(BookDTO book)
		{
			try
			{
				this.bookService.Add(new Book(book.Id, book.Isbn, book.Title, book.Author, book.Summary));
				return new JsonResult { Data = $"{book.Title} was added to library", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
			}
			catch
			{
				return new JsonResult { Data = "failed to add book", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
			}
		}
	}
}


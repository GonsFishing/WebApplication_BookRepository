using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication_test.Interfaces;

namespace WebApplication_test.Classes
{
	public class Book : IBook
	{
		private int id { get; set; }
		private int isbn { get; set; }
		private string title { get; set; }
		private string author { get; set; }
		private string summary { get; set; }

		public int Id => id;
		public int Isbn => isbn;
		public string Title => title;
		public string Author => author;
		public string Summary => summary;

		public Book(int id, int isbn, string titel, string författare, string sammanfattning)
		{
			this.id = id;
			this.isbn = isbn;
			this.title = titel;
			this.author = författare;
			this.summary = sammanfattning;
		}
	}

	public class BookDTO
	{
		public int Id { get; set; }
		public int Isbn { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public string Summary { get; set; }
	}
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication_test.Interfaces;

namespace WebApplication_test.Classes
{
	public class BookService : IBookService
	{
		public void Add(IBook book)
		{
			using (var connection = new SqlConnection("Data Source=DESKTOP-LT9U687\\HIBERNATE;Initial Catalog=BookRepository;User ID=sa;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
			{
				string query = "INSERT INTO books(ISBN, Title, Author, Summary) " +
					"VALUES(@ISBN, @Title, @Author, @Summary)";
				using (var cmd = new SqlCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@ISBN", book.Isbn);
					cmd.Parameters.AddWithValue("@Title", book.Title);
					cmd.Parameters.AddWithValue("@Author", book.Author);
					cmd.Parameters.AddWithValue("@Summary", book.Summary);

					connection.Open();
					int result = cmd.ExecuteNonQuery();

					if (result < 0)
					{
						throw new Exception("Nothing has changed");
					}
				}
			}
		}

		public List<IBook> GetAllBooks()
		{
			throw new NotImplementedException();
		}

		public IBook GetBook()
		{
			return new Book(1, 1, "lord of ring from bookservice", "tolkien", "very longstory");
		}

		public void Remove(IBook book)
		{
			throw new NotImplementedException();
		}

		public void UpDateBook()
		{
			throw new NotImplementedException();
		}

	}

	public class SixtensBookService : IBookService
	{
		public void Add(IBook book)
		{ }

		public List<IBook> GetAllBooks()
		{
			throw new NotImplementedException();
		}

		public IBook GetBook()
		{
			return new Book(1, 1, "lord of ring from Sixtens BookService", "tolkien", "very longstory");
		}

		public void Remove(IBook book)
		{
			throw new NotImplementedException();
		}

		public void UpDateBook()
		{
			throw new NotImplementedException();
		}
	}
}

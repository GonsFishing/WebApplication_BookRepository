using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_test.Interfaces
{
	public interface IBookService
	{
		
		void Add(IBook book);
		void Remove(IBook book);
		void UpDateBook();
		IBook GetBook();
		List<IBook> GetAllBooks();
	}
}
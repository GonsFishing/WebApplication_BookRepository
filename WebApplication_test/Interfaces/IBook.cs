using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_test.Interfaces
{
	public interface IBook
	{
		int Id { get; }
		int Isbn { get; }
		string Title { get; }
		string Author { get; }
		string Summary { get; }
	}
}

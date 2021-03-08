using System;
namespace WebApplication_test.Controllers
{
	public class Book()
	{
		int id;
		string titel;
		string författare;
		string sammanfattning;

		Book(int id, string titel, string författare, string sammanfattning)
			{
			this.id = id;
			this.titel = titel;
			this.författare = författare;
			this.sammanfattning = sammanfattning;
		}
	}
}

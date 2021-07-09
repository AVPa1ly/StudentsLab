using System;
using System.Collections.Generic;

namespace DesignPatterns.Adapter
{
    public class Client : IClient
    {
        public void ShowPattern()
        {
            Library lib = CreateLibrary();
            IXmlToJson adapter = new Adapter();
            BookAnalyzer analyzer = new BookAnalyzer();

            List<Book> books = lib.GetBooks();
            List<DateTime> dates = adapter.ListBookToDateTime(books);
            DisplayContents(books, analyzer.GetOldestBook(dates));
        }

        public Library CreateLibrary()
        {
            string[] authors = { "Tolstoy", "London", "Chukovsky" };
            string[] titles = { "War and pease", "White Fang", "Moidodyr" };
            DateTime[] pubDates = { DateTime.Parse("03/24/1867"), DateTime.Parse("05/02/1906"), Convert.ToDateTime("07/10/1923") };
            int[] cost = { 10000, 50000, 7000 };
            List<Book> books = new List<Book>();
            for (int i = 0; i < 3; i++)
            {
                books.Add(new Book(pubDates[i], authors[i], titles[i], cost[i]));
            }

            return new Library(books);
        }

        public void DisplayContents(List<Book> books, DateTime oldestDate)
        {
            Console.WriteLine("--Library contents--");
            const string format = "{0, 15} {1, 10} {2, 4} {3, 6}";
            Console.WriteLine(format, "Title", "Author", "Year", "Cost");
            foreach (var book in books)
            {
                Console.WriteLine(format, book.title, book.author, book.pubDate.Year, book.cost);
            }
            Console.WriteLine("Oldest publishing date: {0}", oldestDate.Date);
        }
    }
}

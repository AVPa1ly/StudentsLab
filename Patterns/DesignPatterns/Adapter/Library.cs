using System.Collections.Generic;

namespace DesignPatterns.Adapter
{
    public class Library
    {
        private List<Book> books;

        public Library(List<Book> books)
        {
            this.books = books;
        }

        public List<Book> GetBooks()
        {
            return new List<Book>(books);
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
    }
}

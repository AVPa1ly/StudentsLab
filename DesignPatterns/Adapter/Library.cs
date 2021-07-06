using System.Collections.Generic;

namespace DesignPatterns.Adapter
{
    class Library
    {
        public List<Book> Books { get; private set; }

        public Library(List<Book> books)
        {
            Books = books;
        }

        public List<Book> GetBooks()
        {
            return Books;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
}

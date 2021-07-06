using System;
using System.Collections.Generic;

namespace DesignPatterns.Adapter
{
    class Adapter : IXmlToJson
    {
        public List<DateTime> ListBookToDateTime(List<Book> books)
        {
            List<DateTime> booksPubDates = new List<DateTime>();
            foreach (var book in books)
            {
                booksPubDates.Add(book.PublishingDate);
            }

            return booksPubDates;
        }
    }
}

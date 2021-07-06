using System;

namespace DesignPatterns.Adapter
{
    class Book
    {
        public DateTime PublishingDate { get; private set; }
        public string Author { get; private set; }
        public string Title { get; private set; }
        public int Cost { get; private set; }

        public Book(DateTime pubDate, string author, string title, int cost)
        {
            PublishingDate = pubDate;
            Author = author;
            Title = title;
            Cost = cost;
        }
    }
}

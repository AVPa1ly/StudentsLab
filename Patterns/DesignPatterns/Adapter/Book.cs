using System;

namespace DesignPatterns.Adapter
{
    public class Book
    {
        public readonly DateTime pubDate;
        public readonly string author;
        public readonly string title;
        public readonly int cost;

        public Book(DateTime pubDate, string author, string title, int cost)
        {
            this.pubDate = pubDate;
            this.author = author;
            this.title = title;
            this.cost = cost;
        }
    }
}

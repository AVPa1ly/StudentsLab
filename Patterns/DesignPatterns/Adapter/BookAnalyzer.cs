using System;
using System.Collections.Generic;

namespace DesignPatterns.Adapter
{
    public class BookAnalyzer
    {
        public DateTime GetOldestBook(List<DateTime> booksPubDate)
        {
            DateTime oldestPubDate = DateTime.MaxValue;
            foreach (var pubDate in booksPubDate)
            {
                if (pubDate < oldestPubDate)
                {
                    oldestPubDate = pubDate;
                }
            }

            return oldestPubDate;
        }
    }
}

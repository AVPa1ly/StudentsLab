using System;
using System.Collections.Generic;

namespace DesignPatterns.Adapter
{
    class BookAnalyzer
    {
        public DateTime GetOldestBook(List<DateTime> booksPubDate)
        {
            DateTime oldestPubDate = booksPubDate[0];
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

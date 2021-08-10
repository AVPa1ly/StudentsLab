using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public interface IXmlToJson
    {
        public List<DateTime> ListBookToDateTime(List<Book> books);
    }
}

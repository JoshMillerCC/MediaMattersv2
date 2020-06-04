using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersv2.Models.Books
{
    public interface IBookRepository
    {
        IEnumerable<Book> getBooks();
        Book getBookByTitle(string title);
    }
}

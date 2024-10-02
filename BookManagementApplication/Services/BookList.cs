using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookList
    {
        BookServices bookService = new();
        List<Book> bookList = new List<Book>();


    }
}

using Repositories;
using Repositories.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookServices
    {
        private BookRepository _bookRepo = new();
        private List<Book> _bookList = null;

        public List<Book> GetAllBooks() => _bookList = _bookRepo.GetBooksFromDB();

        public int GetNewBookId() => _bookRepo.GetMaxBookId() + 1;

        public void AddBook(Book book) => _bookRepo.AddBookToDB(book);

        public void RemoveBook(Book book) => _bookRepo.RemoveBookFromDB(book);

        public void UpdateBook(Book book) => _bookRepo.UpdateBookFromDB(book);

        public List<Book>? SearchBook(string title, string description) => _bookRepo.SearchBookFormDB(title, description);
    }
}

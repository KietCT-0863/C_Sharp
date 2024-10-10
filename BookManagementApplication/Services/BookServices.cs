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
        private List<Book> _bookList = default;

        public List<Book> GetAllBooks() => _bookList = _bookRepo.GetAllBooksFromDB();

        public int GetBookPrimaryKey() => GetNumberOfBook() + 1;

        public int GetNumberOfBook() => _bookList.Max(b => b.BookId);

        public void AddBook(Book book) => _bookRepo.AddBookToDB(book);

        public void RemoveBook(Book book) => _bookRepo.RemoveBookFromDB(book);

        public void UpdateBook(Book book) => _bookRepo.UpdateBookFromDB(book);

        public List<Book> SearchBook(string keyWord)
        {
            List<Book> listBookSearch;
            return listBookSearch = _bookList.Where<Book>(b => b.BookName.ToLower().Contains(keyWord.ToLower())).ToList();
        }
    }
}

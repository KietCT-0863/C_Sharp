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

        public List<Book> BookList { get; set; }

        public List<Book> GetAllBooks() => BookList = _bookRepo.GetBooksFromDB();
        public int GetNewBookId() => BookList.Max(b => b.BookId) + 1;
        public void AddBook(Book book) => _bookRepo.AddBookToDB(book);
        public void RemoveBook(Book book) => _bookRepo.RemoveBookFromDB(book);
        public void UpdateBook(Book book) => _bookRepo.UpdateBookFromDB(book);
        public List<Book> SearchBook(string bookTitle, string description, List<Book> selectedListBook)
            => selectedListBook.Where<Book>(b => b.BookName.ToLower().Contains(bookTitle.ToLower()) && b.Description.ToLower().Contains(description.ToLower())).ToList();
        public List<Book> SortBook(List<Book> selectedListBook)
            => selectedListBook.OrderBy(b => b.BookName).ToList();
    }
}

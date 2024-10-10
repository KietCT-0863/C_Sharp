using Repositories;
using Repositories.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookServices
    {
        private BookRepository bookRepo = new();

        public List<Book> GetAllBooks() => bookRepo.GetAllBooksFromDB();
        public int GetBookPrimaryKey() => bookRepo.GetBookMaxPrimaryKey() + 1;
        public void AddBook(Book book)
        {
            bookRepo.AddBookToDB(book);
        }
        public void RemoveBook(Book book) => bookRepo.RemoveBookFromDB(book);
        public void UpdateBook(Book book) => bookRepo.UpdateBookFromDB(book);
        public List<Book> SortBookByBookTitle() => bookRepo.SortBookByTitleFromDB();
    }
}

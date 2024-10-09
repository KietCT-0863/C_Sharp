using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepository
    {
        private BookManagementDbContext? _context;

        public void AddBookToDB(Book newBook)
        {
            _context = new();
            _context.Books.Add(newBook);
            _context.SaveChanges();
        }
        public List<Book> GetAllBooksFromDB()
        {
            _context = new();
            return _context.Books.ToList();
        }
        public int GetBookMaxPrimaryKey()
        {
            _context = new();
            return _context.Books.Max(b => b.BookId);
        }
        public void UpdateBookFromDB(Book newBook)
        {
            _context = new();
            _context.Books.Update(newBook);
            _context.SaveChanges();
        }
        public void RemoveBookFromDB(Book book)
        {
            _context = new();
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
        public List<Book> SortBookByTitleFromDB()
        {
            _context = new();
            return _context.Books.OrderBy(b => b.BookName).ToList();
        }
    }
}

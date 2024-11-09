using Microsoft.EntityFrameworkCore;
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

        public List<Book> GetBooksFromDB()
        {
            _context = new();
            return _context.Books.Include("BookCategory").ToList();
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

        public int GetMaxBookId()
        {
            _context = new();
            return _context.Books.Max(b => b.BookId);
        }

        public List<Book>? SearchBookFormDB(string bookName, string description)
        {
            _context = new();
            return _context.Books.Where<Book>(b => b.BookName.ToLower().Contains(bookName.ToLower()) && b.Description.ToLower().Contains(description.ToLower())).ToList();
        }
    }
}

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
        // _context dễ gây xung đột trong ram nên khi nào cần sử dụng thì mới new
        private BookManagementDbContext _context;

        /// <summary>
        /// This method used to ADD book to database
        /// </summary>
        /// <param name="newBook"></param>
        public void AddBookToDB(Book newBook)
        {
            _context = new();
            // LINQ sử dụng để tạo 1 câu lệnH SQL
            _context.Books.Add(newBook);
            // chạy câu lệnh SQL
            _context.SaveChanges();
        }

        /// <summary>
        /// This method used to TAKE ALL book from database
        /// </summary>
        /// <returns>Return List<Book></returns>
        public List<Book> GetBooksFromDB()
        {
            _context = new();
            return _context.Books.ToList();
        }

        /// <summary>
        /// This method used to UPDATE Book from database
        /// </summary>
        /// <param name="newBook"></param>
        public void UpdateBookFromDB(Book newBook)
        {
            _context = new();
            _context.Books.Update(newBook);
            _context.SaveChanges();
        }

        /// <summary>
        /// This method used to REMOVE 1 book from database 
        /// </summary>
        public void RemoveBookFromDB(Book book)
        {
            _context = new();
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        /// <summary>
        /// This method is used to SEARCH for book titles from database
        /// </summary>
        /// <param name="Title"></param>
        /// <returns>Return List<Book> that matching the input Title</returns>
        public List<Book> SearchBookByTitleFromDB(string Title)
        {
            _context = new();
            return _context.Books.Where(b => b.BookName.Equals(Title, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        /// <summary>
        /// This method used to SORT book by Title
        /// </summary>
        /// <returns>Return a sorted List<Book></returns>
        public List<Book> SortBookByTitleFromDB()
        {
            _context = new();
            // hàm OrderBy được sử dụng để sắp xếp các phần tử theo thứ tự tăng dần dựa vào thuộc tính bạn chỉ định
            // thuộc tính được đưa vào bằng cách sử dụng DELIGATE
            return _context.Books.OrderBy(b => b.BookName).ToList();
        }

    }
}

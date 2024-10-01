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
    // BookService sẽ thông qua BookRepository để lấy database
    // Same : mỗi method cần truy xuất dữ liệu trong db trên Repo thì Ser đều có
    // Diff : trên Ser có thêm phần xử lý dữ liệu lấy từ db
    public class BookService
    {
        BookRepository bookRepo = new();

        public List<Book> PrintAllBook() => bookRepo.GetBooksFromDB();
        public void AddBook(Book book) => bookRepo.AddBookToDB(book);
        public void RemoveBook(Book book) => bookRepo.RemoveBookFromDB(book);
        public void UpdateBook(Book book) => bookRepo.UpdateBookFromDB(book);
        public List<Book> SortBookByBookTitle() => bookRepo.SortBookByTitleFromDB();
    }
}

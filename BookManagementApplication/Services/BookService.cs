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
    public class BookService
    {
        BookRepository bookRepo = new();

        public void PrintAllBook()
        {
            List<Book> listBook = bookRepo.GetBooksFromDB();
            for (int i = 0; i < listBook.Count; i++)
            {
                Console.WriteLine(listBook[i]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book) => bookRepo.AddBookToDB(book);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="book"></param>
        public void RemoveBook(Book book) => bookRepo.RemoveBookFromDB(book);

        /// <summary>
        /// 
        /// </summary>
        public void UpdateBook(Book book) => bookRepo.UpdateBookFromDB(book);

        /// <summary>
        /// 
        /// </summary>
        public void SortBookByBookTitle() => bookRepo.SortBookByTitleFromDB();

    }

    //public class BookTitleComparable : IComparer<Book>
    //{
    //    public int Compare(Book x, Book y)
    //    {
    //        // nếu x == null, check y có bằng null hay không
    //        // nếu y == null => x = y ( return 0; )
    //        // nếu y != null => x < y ( return -1;)
    //        if (x == null) return y == null ? 0 : -1;

    //        // nếu x != null và y == null => x > y ( return 1; )
    //        if (y == null) return 1;

    //        // nếu x != null và y != null => ta gọi hàm compare dể check như bình thường
    //        // StringComparison.OrdinalIgnoreCase : dùng để check 2 chuỗi string bỏ qua hoa thường
    //        return string.Compare(x.BookName, y.BookName, StringComparison.OrdinalIgnoreCase);
    //    }
    //}
}

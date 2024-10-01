using Repositories;
using Repositories.Models;
using Services;

namespace TesterDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BookRepository bookRepo = new();
            BookService bookService = new();

            //test addbook()
            //Book newbook = new Book(18, "Ai da dat ten cho dong song", "123", DateTime.Now, 22, 20.0, "author A", 1);
            //bookService.RemoveBook(newbook);
            //

            List<Book> printList = bookService.PrintAllBook();
            for (int i = 0; i < printList.Count; i++)
            {
                Console.WriteLine(printList[i]);
            }
        }
    }
}

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
            BookServices bookService = new();

            //test addbook()
            Book newbook = new Book("Ai da dat ten cho dong song", "123", DateTime.Now, 22, 20.0, "author A", 1);
            bookService.AddBook(newbook);
            //

            List<Book> printList = bookService.PrintAllBook();
            for (int i = 0; i < printList.Count; i++)
            {
                Console.WriteLine(printList[i]);
            }




            //UserAccountServices userAccountServices = new();

            //test addUser()
            //UserAccount userAccount = new() { FullName = "a", Email = "a@gmail.com", Password = "123@123", Role = 3 };
            //userAccountServices.AddUser(userAccount);
        }
    }
}

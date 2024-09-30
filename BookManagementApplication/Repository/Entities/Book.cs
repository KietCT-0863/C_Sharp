using System;
using System.Collections.Generic;

namespace Repositories.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string BookName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime PublicationDate { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public string Author { get; set; } = null!;

    public int BookCategoryId { get; set; }

    public virtual BookCategory BookCategory { get; set; } = null!;

    public Book(int bookId, string bookName, string description, DateTime publicationDate, int quantity, double price, string author, int bookCategoryId)
    {
        BookId = bookId;
        BookName = bookName;
        Description = description;
        PublicationDate = publicationDate;
        Quantity = quantity;
        Price = price;
        Author = author;
        BookCategoryId = bookCategoryId;
    }

    public override string? ToString()
    {
        return $"ID : {BookId} | Title : {BookName} | Quantity : {Quantity} | Price : {Price}";
    }
}

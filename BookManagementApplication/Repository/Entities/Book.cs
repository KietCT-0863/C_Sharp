using System;
using System.Collections.Generic;

namespace Repositories.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string? BookName { get; set; }

    public string? Description { get; set; }

    public DateTime PublicationDate { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public string? Author { get; set; }

    public int BookCategoryId { get; set; }

    public virtual BookCategory BookCategory { get; set; } = null!;

    public override string? ToString()
    {
        return $"ID : {BookId} | Title : {BookName} | Quantity : {Quantity} | Price : {Price}";
    }
}

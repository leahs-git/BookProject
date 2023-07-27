using MakeABookClass;
using Microsoft.VisualBasic;
/*
Book book1 = new Book();

book1.BookTitle = "Frankenstein";
book1.AuthorName = "Mary Shelley";

Console.WriteLine(book1.BookTitle + "\n" + book1.AuthorName);

Console.WriteLine(book1.ReleaseDate);
*/
var book2 = new Book()
{
    BookTitle = "Frankensteiners",
    AuthorName = "Married Shell",
    ReleaseDate = DateOnly.FromDateTime(DateTime.Today)
};


Console.WriteLine(book2.ReleaseDate);
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookDB
{
    public class EFDb
    {
        public void GetAllAuthors()
        {
            var authors = new List<Author>();

            using (var db = new LibraryDBContext())
            {
                foreach (var author in db.Author)
                {
                    Console.WriteLine("Name: {0} {1}    " + "Country: {2}    " + "Number of Books: {3}    " + "\n", author.AuthorName, author.Surname, author.Country, author.Book.Count);
                }
            }
        }

        public void FindBooks(string surname)
        {
            using (var db = new LibraryDBContext())
            {
                Author author = db.Author.FirstOrDefault(a => a.Surname == surname);

                if (author != null)
                {
                    var books = author.Book;

                    foreach (var book in books)
                    {
                        Console.WriteLine("{0}, {1}", book.BookName, book.Year);
                    }
                }
                else
                {
                    Console.WriteLine("This author has no books");
                }
            }
        }
    }
}

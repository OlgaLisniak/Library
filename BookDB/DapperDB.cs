using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.SqlClient;

namespace BookDB
{
    public class DapperDB
    {
        public string ConnectionString { get; set; }
        public DapperDB()
        {
            ConnectionString = new LibraryDBContext().Database.Connection.ConnectionString;
        }

        public void GetAllAuthors()
        {
            List<Author> authors = new List<Author>();
            using (var db = new SqlConnection(ConnectionString))
            {
                authors = db.Query<Author>("Select * From Author").ToList();

                foreach (var author in authors)
                {
                    var numberOfBooks = db.Query<Book>("Select * From Book Where AuthorId = @Id", new { author.Id}).Count();
                    Console.WriteLine("Name: {0} {1}    " + "Country: {2}    " + "Number of Books: {3}    " + "\n", author.AuthorName, author.Surname, author.Country, numberOfBooks);

                }
            }
        }

        public void FindBooks(string surname)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var author = db.Query<Author>("Select * From Author Where surname = @surname", new {surname}).FirstOrDefault();

                if (author != null)
                {
                    var listBooks = db.Query<Book>("Select * From Book Where AuthorId = @Id", new {author.Id});

                    foreach (var book in listBooks)
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

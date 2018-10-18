using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDB
{
    public class Data
    {
        public Data()
        {
            InsertData();
        }

        public void InsertData()
        {
            var StephenKing = new Author
            {
                AuthorName = "Stephen",
                Surname = "King",
                Country = "USA"
            };
            var kingsBooks = new List<Book>
            {
                new Book {BookName = "Carrie", Year = 1974, Author = StephenKing},
                new Book {BookName = "The Shining", Year = 1977, Author = StephenKing},
                new Book {BookName = "Insomnia", Year = 1994, Author = StephenKing},
                new Book {BookName = "The Green Mile", Year = 1996, Author = StephenKing},
                new Book {BookName = "11/22/63", Year = 2011, Author = StephenKing},
                new Book {BookName = "Mr. Mercedes", Year = 2014, Author = StephenKing},
                new Book {BookName = "Revival", Year = 2014, Author = StephenKing},
                new Book {BookName = "Elevation", Year = 2018, Author = StephenKing}
            };
            StephenKing.Book = kingsBooks;

            var JoanneRowling = new Author
            {
                AuthorName = "Joanne",
                Surname = "Rowling",
                Country = "Great Britain",

            };
            var rowlingsBooks = new List<Book>
            {
                new Book {BookName = "Harry Potter and the Philosopher's Stone", Year = 1997, Author = JoanneRowling},
                new Book {BookName = "Harry Potter and the Chamber of Secrets", Year = 1998, Author = JoanneRowling},
                new Book {BookName = "Harry Potter and the Prisoner of Azkaban", Year = 1999, Author = JoanneRowling},
                new Book {BookName = "Harry Potter and the Goblet of Fire", Year = 2000, Author = JoanneRowling},
                new Book {BookName = "Harry Potter and the Order of the Phoenix ", Year = 2003,  Author = JoanneRowling},
                new Book {BookName = "Harry Potter and the Half-Blood Prince", Year = 2005, Author = JoanneRowling},
                new Book {BookName = "Harry Potter and the Deathly Hallows", Year = 2007, Author = JoanneRowling}
            };
            JoanneRowling.Book = rowlingsBooks;

            var AlexandreDumas = new Author
            {
                AuthorName = "Alexandre",
                Surname = "Dumas",
                Country = "France"
            };
            var dumasBooks = new List<Book>
            {
                new Book {BookName = "Vingt Ans Apres", Year = 1845, Author = AlexandreDumas},
                new Book {BookName = " The Count Of Monte Cristo", Year = 1846, Author = AlexandreDumas},
                new Book {BookName = " The Queen's Necklace", Year = 1850, Author = AlexandreDumas},
                new Book {BookName = "The Black Tulip ", Year = 1850, Author = AlexandreDumas},
            };
            AlexandreDumas.Book = dumasBooks;

            var JulesVerne = new Author
            {
                AuthorName = "Jules Gabriel",
                Surname = "Verne",
                Country = "France"
            };
            var vernesBooks = new List<Book>
            {
                new Book {BookName = "20,000 Leagues Under the Sea", Year = 2018, Author = JulesVerne},
                new Book {BookName = "From the Earth to the Moon; And, Round the Moon", Year = 2016, Author = JulesVerne},
                new Book {BookName = "The Jules Verne Anthology", Year = 2014, Author = JulesVerne},
                new Book {BookName = "The Exploration of the World", Year = 2014, Author = JulesVerne},
            };
            JulesVerne.Book = vernesBooks;

            var HarukiMurakami = new Author
            {
                AuthorName = "Haruki",
                Surname = "Murakami",
                Country = "Japan"
            };
            var murakamisBooks = new List<Book>
            {
                new Book {BookName = "Hear the Wind Sing", Year = 2015, Author = HarukiMurakami},
                new Book {BookName = "A Wild Sheep Chase", Year = 1989, Author = HarukiMurakami},
                new Book {BookName = "Norwegian Wood", Year = 1989, Author = HarukiMurakami},
                new Book {BookName = "After Dark", Year = 2007, Author = HarukiMurakami},
                new Book {BookName = "1Q84", Year = 2011, Author = HarukiMurakami},
                new Book {BookName = "The Elephant Vanishes", Year = 1993, Author = HarukiMurakami},
                new Book {BookName = "Killing Commendatore", Year = 2018, Author = HarukiMurakami},
                new Book {BookName = "Men Without Women", Year = 2017, Author = HarukiMurakami},
                new Book {BookName = "Underground", Year = 2000, Author = HarukiMurakami}
            };
            HarukiMurakami.Book = murakamisBooks;

            using (var db = new LibraryDBContext())
            {
                db.Author.Add(StephenKing);
                db.Author.Add(JoanneRowling);
                db.Author.Add(JulesVerne);
                db.Author.Add(HarukiMurakami);
                db.Author.Add(AlexandreDumas);

                db.Book.AddRange(kingsBooks);
                db.Book.AddRange(rowlingsBooks);
                db.Book.AddRange(dumasBooks);
                db.Book.AddRange(vernesBooks);
                db.Book.AddRange(murakamisBooks);

                db.SaveChanges();
            }

            #region 
            /*var authors = new List<Author>()
            {
                new Author
                {
                    Name="Stephen", Surname = "King", Country = "USA", Id = 1,
                    Book = new List<Book>
                    {
                        new Book{Name = "Carrie", Year = 1974, AuthorID = 1},
                        new Book{Name = "The Shining", Year = 1977, AuthorID = 1},
                        new Book{Name = "Insomnia", Year = 1994, AuthorID = 1},
                        new Book{Name = "The Green Mile", Year = 1996, AuthorID = 1},
                        new Book{Name = "11/22/63", Year = 2011, AuthorID = 1},
                        new Book{Name = "Mr. Mercedes", Year = 2014, AuthorID = 1},
                        new Book{Name = "Revival", Year = 2014, AuthorID = 1},
                        new Book{Name = "Elevation", Year = 2018, AuthorID = 1}
                    }
                },
                new Author
                {
                    Name = "Joanne", Surname = "Rowling", Country = "Great Britain", Id = 2,
                    Book = new List<Book>
                    {
                        new Book{Name = "Harry Potter and the Philosopher's Stone", Year = 1997, AuthorID = 2},
                        new Book{Name = "Harry Potter and the Chamber of Secrets", Year = 1998, AuthorID = 2},
                        new Book{Name = "Harry Potter and the Prisoner of Azkaban", Year = 1999, AuthorID = 2},
                        new Book{Name = "Harry Potter and the Goblet of Fire", Year = 2000, AuthorID = 2},
                        new Book{Name = "Harry Potter and the Order of the Phoenix ", Year = 2003, AuthorID = 2},
                        new Book{Name = "Harry Potter and the Half-Blood Prince", Year = 2005, AuthorID = 2},
                        new Book{Name = "Harry Potter and the Deathly Hallows", Year = 2007, AuthorID = 2}
                    }
                },
                new Author
                {
                    Name="Alexandre", Surname = "Dumas", Country = "France", Id = 3,
                    Book = new List<Book>
                    {
                        new Book{Name = "Vingt Ans Apres", Year = 1845, AuthorID = 3},
                        new Book{Name = " The Count Of Monte Cristo", Year =1846, AuthorID = 3},
                        new Book{Name = " The Queen's Necklace", Year = 1850, AuthorID = 3},
                        new Book{Name = "The Black Tulip ", Year = 1850, AuthorID = 3},
                    }
                },
                new Author
                {
                    Name="Jules Gabriel", Surname = "Verne", Country = "France", Id = 4,
                    Book = new List<Book>
                    {
                        new Book{Name = "20,000 Leagues Under the Sea", Year = 2018, AuthorID = 4},
                        new Book{Name = "From the Earth to the Moon; And, Round the Moon", Year = 2016, AuthorID = 4},
                        new Book{Name = "The Jules Verne Anthology", Year = 2014, AuthorID = 4},
                        new Book{Name = "The Exploration of the World", Year = 2014, AuthorID = 4},
                    }
                },
                new Author
                {
                    Name="Haruki", Surname = "Murakami", Country = "Japan", Id = 5,
                    Book = new List<Book>
                    {
                        new Book{Name = "Hear the Wind Sing", Year = 2015, AuthorID = 5},
                        new Book{Name = "A Wild Sheep Chase", Year = 1989, AuthorID = 5},
                        new Book{Name = "Norwegian Wood", Year = 1989, AuthorID = 5},
                        new Book{Name = "After Dark", Year = 2007, AuthorID = 5},
                        new Book{Name = "1Q84", Year = 2011, AuthorID = 5},
                        new Book{Name = "The Elephant Vanishes", Year = 1993, AuthorID = 5},
                        new Book{Name = "Killing Commendatore", Year = 2018, AuthorID = 5},
                        new Book{Name = "Men Without Women", Year = 2017, AuthorID = 5},
                        new Book{Name = "Underground", Year = 2000, AuthorID = 5}
                    }
                },
            };*/
            #endregion
        }
    }
}

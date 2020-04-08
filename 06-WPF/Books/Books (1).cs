using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary
{
    public class Book
    {
        public int Id { get; private set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public bool IsRead { get; set; }

        public int Year { get; set; }

        public BookFormat Format { get; set; }

        public Book(int id)
        {
            Id = id;

        }
    }

    public enum BookFormat
    {
        PaperBack, EBook
    }

    public static class MyBookCollection
    {
        public static List<Book> GetMyCollection()
        {
            return new List<Book>()
            {
                new Book(1){ Author = "J.K. Rowling", Format = BookFormat.EBook, IsRead = true, Title = "Harry Potter and the Philosopher's Stone", Year=1997},

                new Book(1)
                {
                    Author = "J.K. Rowling", Format = BookFormat.EBook, IsRead = true, Title = "Harry Potter and the Chamber of Secrets",
                    Year = 1998
                },

                new Book(3){ Author = "J.K. Rowling", Format = BookFormat.PaperBack, IsRead = true, Title = "Harry Potter and the Prisoner of Azkaban", Year = 1999},

                new Book(4){ Author = "Jonathan Swift", Format = BookFormat.PaperBack, IsRead = false, Title = "Travels into Several Remote Nations of the World. In Four Parts. By Lemuel Gulliver, First a Surgeon, and then a Captain of several Ships", Year=1972},

                new Book(5){Author = "Wayne Thomas Batson", Format = BookFormat.EBook, IsRead = true, Title = "Isle of Swords", Year = 2007},

                new Book(5){Author = "Louis A. Meyer", Format = BookFormat.EBook, IsRead = true, Title = "Under the Jolly Roger", Year = 200},
                
            };

        }
    }
}

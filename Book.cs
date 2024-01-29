using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Lab_2
{

    // Interface for objects that can be borrowed
    interface IBorrowable
    {
        void BorrowBook(Book book);
    }

    // Interface for objects that can manage the library
    interface IManageable
    {
        void AddBook(Book book);
        void RemoveBook(Book book);
    }


    /// <summary>
    /// Represents a base class for all books.
    /// </summary>
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Initializes a new instance of the class with the specified title, author, and year.
        /// </summary>
        /// <param name="title">The title of the book.</param>
        /// <param name="author">The author of the book.</param>
        /// <param name="year">The year of publication of the book.</param>
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = true;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Lab_2
{
    /// <summary>
    /// Represents a derived class for fiction books.
    /// </summary>
    class FictionBook : Book
    {
        public string Genre { get; set; }

        // <summary>
        /// Initializes a new instance of the class with the specified title, author, year, and genre.
        /// </summary>
        /// <param name="title">The title of the book.</param>
        /// <param name="author">The author of the book.</param>
        /// <param name="year">The year of publication of the book.</param>
        /// <param name="genre">The genre of the fiction book.</param>
        public FictionBook(string title, string author, int year, string genre) : base(title, author, year)
        {
            Genre = genre;
        }
    }

}

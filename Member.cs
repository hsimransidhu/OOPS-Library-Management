using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Lab_2
{
    /// <summary>
    /// Represents a member user who can borrow books.
    /// </summary>
    class Member : User, IBorrowable
    {
        public Member(string name) : base(name)
        {
        }

        /// <summary>
        /// Allows the member to borrow a book.
        /// </summary>
        /// <param name="book">The book to be borrowed.</param>
        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                Console.WriteLine($"{Name} borrowed '{book.Title}'.");
                book.IsAvailable = false;
            }
            else
            {
                Console.WriteLine($"Sorry, '{book.Title}' is not available for borrowing.");
            }
        }
    }

}

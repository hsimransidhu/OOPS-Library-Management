using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Lab_2
{
    /// <summary>
    /// Represents a derived class for non-fiction books.
    /// </summary>
    class NonFictionBook : Book
    {
        public string Subject { get; set; }

        public NonFictionBook(string title, string author, int year, string subject) : base(title , author , year )
        {
            Subject = subject;
        }
    }

}

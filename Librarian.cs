using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Lab_2
{
    /// <summary>
    /// Represents a librarian user who can manage the library inventory.
    /// </summary>

    class Librarian : User, IManageable
    {
        private List<Book> libraryInventory;

        public Librarian(string name) : base(name)
        {
            libraryInventory = new List<Book>();
        }

        public void AddBook(Book book)
        {
            libraryInventory.Add(book);
            Console.WriteLine($"'{book.Title}' added to the library inventory.");
        }

        public void RemoveBook(Book book)
        {
            libraryInventory.Remove(book);
            Console.WriteLine($"'{book.Title}' removed from the library inventory.");
        }
    }
}

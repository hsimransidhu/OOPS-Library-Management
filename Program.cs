using OOPS_Lab_2;
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Creating instances of books
            FictionBook fictionBook = new FictionBook("Harry Potter and The Deathly Hallows", "J.K Rowling", 2007 , "Fantasy");
            NonFictionBook nonFictionBook = new NonFictionBook("Rich Dad Poor Dad", "Robert", 1997 , "Self-Help");

            // Creating instances of users
            Member member = new Member("Julia");
            Member member2 = new Member("Charlie");  
            Librarian librarian = new Librarian("Chrissy");

            // Adding books to the library inventory
            librarian.AddBook(fictionBook);
            librarian.AddBook(nonFictionBook);

            // Displaying library menu with available books
            Console.WriteLine("Library Menu:");
            Console.WriteLine("Available Books:");
            Console.WriteLine($"1. {fictionBook.Title} by {fictionBook.Author} ({fictionBook.Year}) - Genre: {fictionBook.Genre}");
            Console.WriteLine($"2. {nonFictionBook.Title} by {nonFictionBook.Author} ({nonFictionBook.Year}) - Subject: {nonFictionBook.Subject}");
            Console.WriteLine();

            // Member borrowing books
            Console.WriteLine($"{member.Name} is borrowing books:");
            member.BorrowBook(fictionBook);
            member.BorrowBook(nonFictionBook);
            Console.WriteLine();

            Console.WriteLine($"{member2.Name} is borrowing books:");
            member2.BorrowBook(nonFictionBook);
            Console.WriteLine();

            // Librarian removing a book from the inventory
            Console.WriteLine($"{librarian.Name} is managing the library inventory:");
            librarian.RemoveBook(fictionBook);
            Console.WriteLine();

            librarian.RemoveBook(nonFictionBook);
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            // Handling format exception when parsing integer
            Console.WriteLine($"Error: {ex.Message}. Please enter a valid  number for the year.");
        }
        catch (Exception ex)
        {
            // Catching any unexpected exceptions and displaying an error message
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}


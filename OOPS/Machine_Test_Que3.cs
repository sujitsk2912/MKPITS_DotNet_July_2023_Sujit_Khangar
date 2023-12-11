using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test___3
{
    internal class Program
    {
        class Author
        {
            public string AuthorName { get; set; }

            public Author(string AuthorName)
            {
                this.AuthorName = AuthorName;
            }
        }

        class Book
        {
            public string Title { get; set; }
            public int ISBN { get; set; }
            public Author BookAuthorName { get; set; }

            public Book(string Title, int ISBN, Author BookAuthorName)
            {
                this.Title = Title;
                this.ISBN = ISBN;
                this.BookAuthorName = BookAuthorName;
            }

            public override string ToString()
            {
                return "Title: " + Title + "; ISBN: " + ISBN + "; Author: " + BookAuthorName.AuthorName;
            }
        }

        class Library
        {
            List<Book> books = new List<Book>();

            public void AddBook(Book book)
            {
                books.Add(book);
                Console.WriteLine("Book {0} are added to library ", book.ToString());
            }

            public void RemoveBook(int isbn)
            {
                Book BookRemove = null;

                foreach (Book book in books)
                {
                    if ( book.ISBN == isbn)
                    {
                        BookRemove = book;
                        break;
                    }
                }

                if( BookRemove != null)
                {
                    books.Remove(BookRemove);
                    Console.WriteLine("Book {0} Removed from library ", BookRemove.Title);
                }
                else
                {
                    Console.WriteLine("Book No. {0} is not found in library ", isbn);
                }
            }
            public void DisplayBookData()
            {
                Console.WriteLine("\nBooks are Available in library\n");

                foreach(Book book in books)
                {
                    Console.WriteLine(book.ToString());  
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Author author1 = new Author("Tony Stark");
            Author author2 = new Author("Thor");

            Book book1 = new Book("Gardians of Galaxy vol.1", 1001, author1);
            Book book2 = new Book("Gardians of Galaxy vol.2", 1002, author2);
            Book book3 = new Book("Gardians of Galaxy vol.3", 1003, author1);

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            library.DisplayBookData();

            library.RemoveBook(1002);

            library.DisplayBookData();

            Console.ReadKey();

        }
    }
}

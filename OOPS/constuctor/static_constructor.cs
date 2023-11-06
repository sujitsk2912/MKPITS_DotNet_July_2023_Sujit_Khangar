using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor
{
    class Book
    {
        static string Title;
        static string Author;

        static Book() // static class name are used in static constructor..........
        {
            Console.WriteLine("This is static constructor\n");
            Title = "Book of knowledge";
            Author = "S. B. Khangar";
        }

        public static void display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " +  Author);
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.display(); // class_name.method_name is used to call the method in static constructor.........
            Console.ReadKey();
        }
    }
}

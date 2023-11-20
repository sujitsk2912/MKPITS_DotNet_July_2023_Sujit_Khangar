using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_overloading_example
{
    class Book
    {
        public string title;
        public string author;
        public int publicationyear;

        public void getdata(string title , string author , int publicationyear)
        {
            this.title = title;
            this.author = author;
            this.publicationyear = publicationyear;
        }

        public void display()
        {
            Console.WriteLine("Title: " +  title);
            Console.WriteLine("Author: " +  author);
            Console.WriteLine("Publication Year: " +  publicationyear);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata("Book of success", "john wick", 2019);
            b.display();

            Console.ReadKey();
        }
    }
}

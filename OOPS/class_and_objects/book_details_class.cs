using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_class
{
    internal class Program
    {
        class Book
        {
            string title, author;
            int publish;
            
            public void getdata(string title, string author, int publish)
            {
                this.title = title;
                this.author = author;  
                this.publish = publish;
            }

            public void display()
            {
                Console.WriteLine("\n----------------------------\n");
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " +  author);
                Console.WriteLine("PublicationYear: " +  publish);
            }
        }
        static void Main(string[] args)
        {
            
            Book[] bookied = new Book[3];
            bookied[0] = new Book();
            bookied[1] = new Book();
            bookied[2] = new Book();

            int i = 0;

            for( i = 0; i < 3; i++)
                {
                Console.WriteLine("\n-------- Book {0} --------", i );
                    Console.WriteLine("\nEnter Title: ");
                    string T1 = Console.ReadLine();

                    Console.WriteLine("Enter Author: ");
                    string A1 = Console.ReadLine();

                    Console.WriteLine("Enter PublicationYear: ");
                    int p_year = Convert.ToInt32(Console.ReadLine());

                    bookied[i].getdata(T1,A1, p_year);
                }

            Console.WriteLine("\n---------- Book Details ----------\n");

            for (i = 0;i < 3;i++)
            {
                bookied[i].display();
            }
            Console.ReadKey();
        }    
    }
}

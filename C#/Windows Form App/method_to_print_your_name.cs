using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_to_print_name
{
    internal class Program
    {
        static void display(string text)
        {
            Console.WriteLine("\nWelcome Friend " + text + " !");
            Console.WriteLine("Have a nice day!");
        }
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter Your Name: ");
            name = Console.ReadLine();
            display(name);
            Console.ReadKey();
        }
    }
}

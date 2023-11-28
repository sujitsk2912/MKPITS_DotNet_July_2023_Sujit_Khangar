using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_form_generic_form
{
    internal class Program
    {
        static Stack<string> s = new Stack<string> ();
        static void Main(string[] args)
        {
            // Last-in first out (LIFO)

            s.Push("Amit");
            s.Push("Rahul");
            s.Push("Suraj");

            Console.WriteLine("Before popping...(Last in)");

            foreach (string str in s)
            {
                Console.WriteLine("Name: " + str);
            }

            Console.WriteLine();

            Console.WriteLine("After popping...(first out)");
            s.Pop();

            foreach (string str in s)
            {
                Console.WriteLine("Name: " + str);
            }

            Console.ReadKey();
        }
        static void display()
        {
           
        }
    }
}

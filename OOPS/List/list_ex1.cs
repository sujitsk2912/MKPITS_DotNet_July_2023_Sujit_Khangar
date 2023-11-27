using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
       static List<string> li = new List<string>();
        static void Main(string[] args)
        {
        
            li.Add("a");
            li.Add("b");
            li.Add("c");
            li.Add("d");

            Console.WriteLine("List contains: a : " + li.Contains("a")); // list contains
            display();
            Console.WriteLine();

            li.Remove("a");     // list remove

            Console.WriteLine("list remove: a");

            display();
            Console.WriteLine();

            li.Insert(0, "e"); // inserting list by index
            Console.WriteLine("list insert: e at index of 0");
            display();
            Console.WriteLine();

            li.Sort(); // sorting list
            Console.WriteLine("Sorting: ");
            display();

            Console.ReadKey();
        }

        public static void display()
        {
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_in_first_out_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue("sujit");
            q.Enqueue("sahil");
            q.Enqueue("samir");

            Console.WriteLine("\ncurrent Quequ...\n");

            foreach (string i in q)
            {
                Console.WriteLine(i);
            }

            q.Enqueue("trish");
            q.Enqueue("mona");

            Console.WriteLine("\nQuequ Added...");
            Console.WriteLine("current Quequ...\n");

            foreach (string i in q)
            {
                Console.WriteLine(i);
            }

            q.Dequeue();

            Console.WriteLine("\nFirst Quequ Removed...");
            Console.WriteLine("current Quequ...\n");

            foreach (string i in q)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}



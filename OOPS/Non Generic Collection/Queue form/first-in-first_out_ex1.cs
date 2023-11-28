using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_in_first_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            Console.WriteLine("\ncurrent Quequ...\n");

            foreach(int i in q)
            {
                Console.WriteLine(i);
            }

            q.Enqueue(6);
            q.Enqueue(7);

            Console.WriteLine("\nQuequ Added...");
            Console.WriteLine("current Quequ...\n");

            foreach (int i in q)
            {
                Console.WriteLine(i);
            }

            q.Dequeue();

            Console.WriteLine("\nFirst Quequ Removed...");
            Console.WriteLine("current Quequ...\n");

            foreach (int i in q)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}

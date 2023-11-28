using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_form_generic_collection
{
    internal class Program
    {
        static Queue<int> Q = new Queue<int>();
        static void Main(string[] args)
        {
            // first in first out (FIFO)

            Q.Enqueue(1);
            Q.Enqueue(2);
            Q.Enqueue(3);

            Console.WriteLine("Before Dequee...(First in)");

            foreach(int i in Q)
            {
                Console.WriteLine("No: " + i);
            }

            Console.WriteLine();

            Q.Dequeue();

            Console.WriteLine("After Dequee...(First out)");

            foreach (int i in Q)
            {
                Console.WriteLine("No: " + i);
            }

            
            Console.ReadKey();
        }
    }
}

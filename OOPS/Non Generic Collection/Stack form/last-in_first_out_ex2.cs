using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace last_in_first_out__LIFO_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            // first-in first out (FIFO)

            st.Push("samir");
            st.Push("sahil");
            st.Push("sujit");

            Console.WriteLine("Current stack: \n" );

            foreach (string i in st)
            {
                Console.WriteLine(i);
            }

            st.Push("trish");

            Console.WriteLine("\nlast stack added: " + st.Peek());
            Console.WriteLine("Current stack: \n");

            foreach (string i in st)
            {
                Console.WriteLine(i);
            }

            st.Pop();

            Console.WriteLine("\nremoving stacks...");
            Console.WriteLine("current stack: \n");

            foreach (string i in st)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace last_in_first_out__LIFO_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            // first-in first out (FIFO)

            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);

            Console.WriteLine("Current stack: \n" );

            foreach (int i in st)
            {
                Console.WriteLine(i);
            }

            st.Push(6);
            st.Push(7);

            Console.WriteLine("\nadding stacks...", st.Peek());
            Console.WriteLine("Current stack: \n");

            foreach (int i in st)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nremoving values...");

            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("current stack: \n");

            foreach (int i in st)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}

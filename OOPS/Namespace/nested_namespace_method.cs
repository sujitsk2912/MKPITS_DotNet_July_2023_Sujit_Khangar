using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first;
using first.second;

namespace first
{
    class class1
    {
        public void display()
        {
            Console.WriteLine("Hello from namespace first");
        }
    }

    namespace second
    {
        class class2
        {
            public void display()
            {
                Console.WriteLine("Hello from namespace second");
            }
        }
    }
}


    internal class Program
    {
        static void Main(string[] args)
        {
            class1 c1 = new class1();
            c1.display();

            class2 c2 = new class2();
            c2.display();

            Console.ReadKey();
        }
    }


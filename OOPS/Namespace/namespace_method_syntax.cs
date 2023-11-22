using first;
using second;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace first
{
    class get
    {
        public void display()
        {
            Console.WriteLine("Hello from namespace first");
        }
    }
}

namespace second
{
    class get
    {
        public void display()
        {
            Console.WriteLine("Hello from namespace second");
        }
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            first.get g1 = new first.get();
            g1.display();

            second.get g2 = new second.get();
            g2.display();

            Console.ReadKey();
        }
    }

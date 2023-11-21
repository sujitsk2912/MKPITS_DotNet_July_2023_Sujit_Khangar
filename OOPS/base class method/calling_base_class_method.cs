using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_base_class_method
{
    class Company
    {
        public string Name = "MKCl";

        public void display()
        {
            Console.WriteLine("Company name: " +  Name);
        }
    }

    class Frencize : Company 
    {
        public string Name = "MKPITS";

        public void display()
        {
            base.display();
            Console.WriteLine("Frencize name: " + Name );
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Frencize F = new Frencize();
            F.display();

            Console.ReadKey();
        }
    }
}

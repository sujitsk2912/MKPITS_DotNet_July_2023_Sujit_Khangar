using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_base_class_constructor
{
    class Company
    {
        public string Name = "MKCl";

        public Company()
        {
            Console.WriteLine("base class constructor");
            Console.WriteLine("Company Name: " + Name);
        }
    }

    class Frencize : Company 
    {
        public string Name = "MKPITS";

        public Frencize()
        {
            Console.WriteLine("derive class constructor");
            Console.WriteLine("Frencize name: " + Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Frencize F = new Frencize();
            Console.ReadKey();
        }
    }
}

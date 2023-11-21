using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass_Inheritance
{
    class Animal
    {
        public string color = "White";
    }

    class dog: Animal
    {
        public string color = "red";

        public void displaycolor()
        {
            Console.WriteLine("Dog color : " +  color);
            Console.WriteLine("Animal Color : " + base.color);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dog d = new dog();
            d.displaycolor();

            Console.ReadKey();
        }
    }
}

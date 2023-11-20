using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_and_method
{
    abstract class shape
    {
        public abstract void draw();
    }

    class Rectangle : shape
    { 
        public override void draw()
        {
            Console.WriteLine("code to draw rectangle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s = new Rectangle();
            s.draw();
            Console.ReadLine();
        }
    }
}

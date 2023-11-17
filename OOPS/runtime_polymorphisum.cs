using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphisum
{
    public class Shape // base class
    {
        public virtual void draw()  
        {
            Console.WriteLine("Draw...");
        }
    }

    public class Rectangle: Shape // calling base class
    {
        public override void draw() // overriding
        {
            Console.WriteLine("Draw Rectangle...");
        }
    }

    public class Circle: Shape // calling base class
    {
        public override void draw()  // overriding
        {
            Console.WriteLine("Draw Circle...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s; // base class Shape

            s = new Shape();
            s.draw();

            s = new Rectangle();
            s.draw();

            s = new Circle();
            s.draw();

            Console.ReadKey();
        }
    }
}

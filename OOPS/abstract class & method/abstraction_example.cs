using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_example
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Circle...");
        }
    }
    class Square : Shape 
    {
        public override void Draw()
        {
           Console.WriteLine("Draw Square...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();

            Shape s = new Square();
            s.Draw();

            Console.ReadKey();

        }
    }
}

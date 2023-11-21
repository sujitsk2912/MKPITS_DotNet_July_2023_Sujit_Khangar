using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_method
{
    interface Shape
    {
        void draw();
    }


    /* public interface Drawable  // if you use public or abstract keyword for interface you get Compile Time Error  
     {
         public abstract void draw();
     }*/

    class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("draw circle...");
        }
    }

    class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Draw Rectangle...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Circle();
            s.draw();

            s = new Rectangle();
            s.draw();

            Console.ReadKey();
        }
    }
}

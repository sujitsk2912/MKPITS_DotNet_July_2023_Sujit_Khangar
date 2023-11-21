using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_inheritance
{
    interface IDrawable
    {
        void Draw();
    }

    class Circle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Draw circle...");
        }
    }

    class Rectangle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Draw Rectangle...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawable ID = new Circle();
            ID.Draw();

            IDrawable ID2 = new Rectangle();
            ID2.Draw();

            Console.ReadKey();
        }
    }
}

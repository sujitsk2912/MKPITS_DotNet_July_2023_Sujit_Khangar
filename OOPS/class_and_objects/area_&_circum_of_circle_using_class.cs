using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_class
{
    internal class Program
    {
        class Circle
        {
            int radius;

            public void getdata(int radius)
            {
                this.radius = radius;
            }

            public void display()
            {
                float area = 3.14f * radius * radius;
                float circumference = 2 * 3.14f * radius;

                Console.WriteLine("\n-----------------------------------\n");
                Console.WriteLine("Area of circle: " + area);
                Console.WriteLine("Circumference of circle: " + circumference);

            }

        }
        static void Main(string[] args)
        {
          Circle circ = new Circle();

            Console.Write("Enter Radius of circle: ");
            int rad = Convert.ToInt32(Console.ReadLine());

            circ.getdata(rad);

            circ.display();

            Console.ReadKey();
        }
    }
}

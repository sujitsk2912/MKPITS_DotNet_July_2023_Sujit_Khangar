using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_and_shared_variable
{
    internal class Program
    {
        static void Display(int radius, out float area, out float circ)
        {
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius = 5;
            float area, circ;

            Display(radius, out area, out circ);
            Console.WriteLine("Area of circle : " + area);
            Console.WriteLine("Circumference of circle : " + circ);
            Console.ReadKey();
        }
    }
}

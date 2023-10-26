using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_array_of_float_and_double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] radius = new int[3];
            
            for ( int i = 0; i < 3; i++ )
            {
                Console.Write("Enter radius[{0}]: ",i);
                radius[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                float area = 3.14f * radius[i] * radius[i];
                double circ = 2 * 3.14f * radius[i];
                Console.WriteLine("\nArea of circle [{0}]: {1}", i, area); // output in float
                Console.WriteLine("Circumference of circle [{0}]: {1}", i, circ); // output in double
            }
            Console.ReadKey();
        }
    }
}

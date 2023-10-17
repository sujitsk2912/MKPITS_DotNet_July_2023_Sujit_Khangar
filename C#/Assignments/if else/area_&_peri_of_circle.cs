using System;
namespace PERIMETER
{
    class Perimeter
    {
        public static void Main()
        {
            int rad;
            float area, peri;
            Console.Write("Enter Radius:");
            rad = Convert.ToInt32(Console.ReadLine());
            area = 3.14f * rad * rad;
            Console.WriteLine("Area of Circle: " +  area);
            peri = 2 * 3.14f * rad;
            Console.WriteLine("Perimetere of circle: " +  peri);
            Console.ReadKey();

        }
    }
}
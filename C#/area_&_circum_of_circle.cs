using System;
namespace areacircum
{
    class areacircum
    {
        static void Main()
        {
            int radius;
            float area, circum;
            Console.WriteLine("Enter Radius: ");
            radius=Convert.ToInt32 (Console.ReadLine());
            area = 3.14f * radius * radius;
            Console.WriteLine("Area of circle: " + area);
            circum = 2 * 3.14f * radius;
            Console.WriteLine("Circumference of circle: " +  circum);
            Console.ReadKey();
        }
    }
}

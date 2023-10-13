using System;
namespace COORDINATE
{
    class coordinate
    {
        public static void Main(string[] args)
        {
            int x, y ;
            Console.Write("Enter value for X coordinate: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for Y coordinate: ");
            y = Convert.ToInt32(Console.ReadLine());

            if(x > 0 && y > 0)
            {
                Console.WriteLine("The coordinate point " + (x, y) + " lies in the First quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The coordinate point " + (x, y) + " lies in the Second quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinate point " + (x, y) + " lies in the Third quadrant");
            }
            else
            {
                    Console.WriteLine("The coordinate point " + (x, y) + " lies in the Fourth quadrant");
            }
  
            Console.ReadKey();
        }
    }
}
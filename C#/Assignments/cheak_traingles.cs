using System;
namespace TRIANGLE
{
    class Triangle
    {
        public static void Main(string[] args)
        {
            int a, b, c, total;
            Console.Write("Enter angle a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter angle b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter angle c: ");
            c = Convert.ToInt32(Console.ReadLine());

            total = a + b + c;

            if(total == 180) 
            {
                if (a == 60 && b == 60 && c == 60)
                {
                    Console.WriteLine("This is an Equilateral triangle");
                }

                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("This is an Isosceles triangle");
                }

                else
                {
                    Console.WriteLine("This is an Scalene triangle");
                }
            }

            else
            {
                Console.WriteLine("The triangle is not valid");
            }

            Console.ReadKey();
        }
    }
}
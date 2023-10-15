using System;
namespace quadratic_equation
{
    class quadratic
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            float result = 0;
            Console.Write("value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("value of b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("value of c: ");
            c = Convert.ToInt32(Console.ReadLine());

            result = b * b - 4*(a*c);

            if(result != 0)
            {
                Console.WriteLine("Root are imaginary: ");
            }
            else
            {
                Console.WriteLine("Root are Real: ");
            }
            Console.ReadKey();
        }
    }
}
using System;
namespace Function
{
    class program
    {
        public static void Main(string[] args)
        {
            int y, x=0;
            Console.Write("Enter y (ranging from -5 to 5): ");
            y = Convert.ToInt32(Console.ReadLine());

            x = (y * y) + (2 * y) + 1;

            Console.WriteLine(x);
            Console.ReadKey();
        }
    }

}
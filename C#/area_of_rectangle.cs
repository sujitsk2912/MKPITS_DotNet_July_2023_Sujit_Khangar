using System;
namespace areaofrectangle
{
    class area
    {
        static void Main()
        {
            int l, b, area;
            Console.WriteLine("Enter Length: ");
            l=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Bredth: ");
            b=Convert.ToInt32(Console.ReadLine());
            area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
            Console.ReadKey();
        }
    }
}
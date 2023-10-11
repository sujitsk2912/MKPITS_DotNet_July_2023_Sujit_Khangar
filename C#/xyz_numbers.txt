using System;
namespace xyz_numbers
{
    class xyz
    {
        static void Main()
        {
            int x, y, z, res1 = 0, res2 = 0;
            Console.Write("Enter value of X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of Z: ");
            z = Convert.ToInt32(Console.ReadLine());
            res1 = (x + y) * z;
            res2 = x * y + y * z;
            Console.WriteLine("---------------------");
            Console.Write("(x+y).z " + " is " +  res1);
            Console.Write(" And ");
            Console.Write("x.y + y.z " + " is " + res2);
            Console.ReadKey();
        }
    }
}
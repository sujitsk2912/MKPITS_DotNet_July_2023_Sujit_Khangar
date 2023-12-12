using System;
namespace BOOLEAN
{
    class Booleantype
    {
        public static void Main()
        {
            Boolean b; // True or False
            Console.Write("Enter boolean value in True/False: ");
            b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Boolean value: " + b);
            Console.ReadKey();
        }
    }
}
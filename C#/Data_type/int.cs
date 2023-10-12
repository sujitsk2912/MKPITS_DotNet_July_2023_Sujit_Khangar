using System;
namespace INT
{
    class Int
    {
        public static void Main()
        {
            int i; // (4 byte) Range -2,147,483,648 to 2,147,483,647 ( it contains negative as well as positive values)
            Console.Write("Enter Int value: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Int value: " + i);
            Console.ReadKey();
        }
    }
}
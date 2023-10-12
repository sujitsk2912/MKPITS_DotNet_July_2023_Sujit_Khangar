using System;
namespace FLOAT
{
    class Float
    {
        public static void Main()
        {
            float f; // (4 byte decibles ) Range -3.402823e38 to 3.402823e38 
            Console.Write("Enter Float value: ");
            f = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Float value: " + f);
            Console.ReadKey();
        }
    }

}
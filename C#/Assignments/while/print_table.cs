using System;
namespace TABLE
{
    class program
    {
        public static void Main(string[] args)
        {
            int num, counter=1, result=0;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            while( counter <= 10)
            {
                result = num * counter;
                Console.WriteLine( num + " * " + counter + " = " + result);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
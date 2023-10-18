using System;
namespace NATURAL_NO
{
    class program
    {
        public static void Main(string[] args)
        {
            int i=1,result=0;
            Console.WriteLine("sum of first 10 natural numbers are:\n");
            while (i<=10)
            {
                Console.WriteLine(i);
                result += i;
                i++;
            }
            Console.WriteLine("\nsum=" + result);
            Console.ReadKey();
        }
    }
}
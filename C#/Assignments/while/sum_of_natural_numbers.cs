using System;
namespace NATURAL_NO
{
    class program
    {
        public static void Main(string[] args)
        {
            int i=1,result=0, num;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());  

            while (i<=num)
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
using System;
namespace Positive
{
    class negative
    {
        public static void Main(String[] args) 
        {
            int num;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());  

            if(num > 0)
            {
                Console.WriteLine(num + " is Positive");
            }
            else if ( num < 0)
            {
                Console.WriteLine(num + " is Negative");
            }

            Console.ReadKey();  
        }
    }
}
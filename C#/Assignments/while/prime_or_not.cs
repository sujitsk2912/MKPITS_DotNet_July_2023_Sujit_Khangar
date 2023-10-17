using System;
namespace PRIME
{
    class program
    {
        public static void Main(string[] args) 
        {
            int num, counter = 2, flag = 0 ;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine()); 
            
            while ( counter > num )
            {
                if (num % counter == 0 )
                {
                    flag = 1 ;
                }
            }

            if( flag == 0 )
            {
                Console.WriteLine("it is prime number");
            }
            else
            {
                Console.WriteLine("it is not prime number");
            }
            Console.ReadKey();
        }
    }
}
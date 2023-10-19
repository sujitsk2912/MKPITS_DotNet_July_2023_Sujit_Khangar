using System;
namespace ConsoleApp
{
    class program
    {
        public static void Main(string[] args)
        {
            int num, sum = 1, cnt = 1;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nOdd numbers is: ");
            while (true)
             { 
                if(sum <= num)
                {
                    if(cnt % 2 != 0)
                    {
                        Console.Write("{0} ",cnt);
                        sum = sum + 1;
                    }
                }
                else
                {
                    break;
                }
                cnt++;
            }
            Console.ReadKey();
        }
    }
}
using System;

namespace READNO
{
    class Read
    {
        public static void Main(string[] args)
        {
            int digit;
            string word=null;

            Console.Write("Enter Digit from (1 - 10): ");
            digit = Convert.ToInt32(Console.ReadLine());

            if (digit == 1)
            {
                word = "one";
            }
            else if (digit == 2)
            {
                word = "two";
            }
            else if (digit == 3)
            {
                word = "three";
            }
            else if (digit == 4)
            {
                word = "four";
            }
            else if (digit == 5)
            {
                word = "five";
            }
            else if (digit == 6)
            {
                word = "six";
            }
            else if (digit == 7)
            {
                word = "seven";
            }
            else if (digit == 8)
            {
                word = "eight";
            }
            else if (digit == 9)
            {
                word = "nine";
            }
            else if (digit == 10)
            {
                word = "ten";
            }
            else
            {
                Console.WriteLine("Invalid Digit");
            }

            Console.WriteLine("\nWord : {0}",word);
            Console.ReadKey();
        }
    }
}

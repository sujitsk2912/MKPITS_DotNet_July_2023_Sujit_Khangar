using System;
namespace AGE
{
    class vote
    {
        public static void Main(string[] args)
        {
            int age;
            Console.Write("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if(age >= 18 ) 
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible for casting your vote.");
            }
            Console.ReadKey();  
        }
    }
}
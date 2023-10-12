using System;
namespace yourage
{
    class age
    {
        static void Main()
        {
            int age;
            Console.Write("Enter your age: ");
            age= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than " + age);
            Console.ReadKey();
        }
    }
}
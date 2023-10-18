using System;


namespace consoleApp
{
    class program
    {
        public static void Main(string[] args)
        {
            int num = 11;

            do
            {
                Console.WriteLine(num);
                num++;

            }
            while (num <= 5);
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}
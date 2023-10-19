using System;
namespace AVERAGE
{
    class program
    {
        public static void Main(string[] args)
        {
            float num = 10, sum = 0, number, average, counter = 1;

            Console.WriteLine("\nEnter 10 numbers\n");

            do
            {
                Console.Write("Number " + counter + ": ");
                number = Convert.ToSingle(Console.ReadLine());
                sum += number;
                counter++;
            }
            while (counter <= num);
            average = sum / num;

            Console.WriteLine("\nThe sum of {0} numbers is : {1}", num, sum);
            Console.WriteLine("\nThe Average is : {0}", average);
            Console.ReadKey();
        }
    }
}
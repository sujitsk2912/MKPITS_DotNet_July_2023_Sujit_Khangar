using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_members_example
{
    public static class MathOperations
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of two numbers is: " + MathOperations.Add(10, 5));
            Console.WriteLine("Multiplication of two numbers is: " + MathOperations.Multiply(10,5));

            Console.ReadKey();
        }
    }
}

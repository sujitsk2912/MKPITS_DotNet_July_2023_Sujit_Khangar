using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    internal class Program
    {
        class Calculate
        {
            public void addition(int n1, int n2)
            {
                int res = n1 + n2;
                Console.WriteLine("Addition of 2 int parameters: " + res);
            }

            public void addition(float n1, float n2) 
            {
                float res = n1 + n2;
                Console.WriteLine("Addition of 2 float parameters: " + res);
            }
        }
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();

            calc.addition(1, 2); // calling 2 int parameters

            calc.addition(2.2f, 3.4f); //  calling 2 float parameters

            Console.ReadKey();
        }
    }
}

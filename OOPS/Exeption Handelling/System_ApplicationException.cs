using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_ApplicationException
{
    class TestTempreture : ApplicationException
    {
        public TestTempreture(string message) : base(message) 
        {

        }
    }
    class Tempreture
    {
        int temp = 0;
        public void showtempreture()
        {
            if(temp == 0)
            {
                throw new TestTempreture("Zero Tempreture Found");
            }
            else
            {
                Console.WriteLine("Tempreture is : " + temp);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tempreture T = new Tempreture();

            try
            {
                T.showtempreture();
            }
            catch (TestTempreture tt)
            {
                Console.WriteLine("TestTempreture: {0} ", tt.Message);
            }
            Console.ReadKey();
        }
    }
}

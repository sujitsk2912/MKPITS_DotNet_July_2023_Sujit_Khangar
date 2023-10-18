using System;
namespace PRIME
{
    class program
    {
        public static void Main(string[] args)
        {
            int num = 3;
            int counter = 2;
            int flag = 0;

            Console.Write("Prime No. is: 2 ");
            while( num <= 20)
            {
                flag = 0;
                counter = 2;
                while( counter < num)
                {
                    if (num % counter == 0)
                    {
                        flag = 1;
                        break;
                    }
                    counter++;
                }

                if(flag == 0) 
                {
                    Console.Write("{0} ", num);
                }
                num++;
            }
            Console.ReadKey();
        }
    }
}
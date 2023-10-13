using System;
namespace ADMISSION
{
    class Admission
    {
        public static void Main(string[] args)
        {
            int maths, phy, che, total, total2;
            Console.Write("Enter Mathematics marks: ");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Physics marks: ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Chemistry marks: ");
            che = Convert.ToInt32(Console.ReadLine());

            total = maths + phy + che; // total marks of three subjects = 180
            total2 = maths + total; // total marks of maths ans all three subjects = 160

            if (maths >= 65 && phy >= 55 && che >= 50)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if( total2 >= 160 )
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is Not eligible for admission.");
            }
            Console.ReadKey();
        }
    }
}
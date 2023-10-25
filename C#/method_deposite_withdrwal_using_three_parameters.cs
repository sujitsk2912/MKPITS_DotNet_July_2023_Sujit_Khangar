using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_deposite_or_withdrawal_using_3_parameters
{
    internal class Program
    {
        static int cheak(int a, int ano, char OP)
        {
            int bal = 1000, res = 0;

            if (OP == 'D' || OP == 'd')
            {
                res = a + bal;
                Console.WriteLine("\nAmount Deposited Successfully.......");
                Console.WriteLine("Total Balance: " + res);
            }
            else if (OP == 'W' || OP == 'w')
            {
                res = bal - a;
                Console.WriteLine("\nAmount Withdrawled Successfully.......");
                Console.WriteLine("Total Balance: " + res);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            return res;
        }
        static void Main(string[] args)
        {
            int amt, acntno;
            char op;

            Console.Write("Enter Account No.: ");
            acntno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount: ");
            amt = Convert.ToInt32(Console.ReadLine());
            Console.Write("For Deposite Money press 'D' or press 'W' for withdrawal: ");
            op = Convert.ToChar(Console.ReadLine());

            int result = cheak(amt, acntno, op);

            Console.ReadKey();

        }
    }
}

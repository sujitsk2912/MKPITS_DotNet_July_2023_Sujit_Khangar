using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_class_using_return_values
{
    interface Bank
    {
        string deposite(int actno, int amount);
    }

    class Saving : Bank
    {
        public string deposite(int actno, int amount)
        {
            int balance = 5000;
            int intrest = 200;
            balance = balance + amount + intrest;

            return "Available Balance for the Account " + actno + " is " +  balance;

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Saving();

            string res = b.deposite(123, 500);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}


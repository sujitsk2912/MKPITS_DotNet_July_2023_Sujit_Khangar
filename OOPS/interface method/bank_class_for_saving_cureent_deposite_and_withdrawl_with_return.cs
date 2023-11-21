using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_class_for_depo_and_withdrwl_with_return
{
    interface Bank
    {
        string deposite(int actno, int amount);
        string withdrawl(int actno, int amount);
    }

    class Account
    {
        public int balance = 5000;
        public int intrest = 200;
    }

    class Saving : Account, Bank
    {

        public string deposite(int actno, int amount)
        {
            balance = balance + amount + intrest;
            return "Amount Deposited succesfully, Available balance for Account " + actno + " is " + balance;
        }

        public string withdrawl(int actno, int amount)
        {
            balance = balance - amount;
            return "Amount Withdrawl succesfully, Available balance for Account " + actno + " is " + balance;
        }
    }

    class Current : Account, Bank
    {
        public string deposite(int actno, int amount)
        {
            balance = balance + amount;
            return "Amount Deposited succesfully, Available balance for Account " + actno + " is " + balance;
        }

        public string withdrawl(int actno, int amount)
        {
            balance = balance - amount;
            return "Amount Withdrawl succesfully, Available balance for Account " + actno + " is " + balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank B = null;
            Console.WriteLine("Choose your account type (saving / current) : ");
            string acttype = Console.ReadLine();

            switch (acttype)
            {
                case "saving":
                    B = new Saving();
                    break;

                case "current":
                    B = new Current();
                    break;
            }

            Console.WriteLine("Do you want to Deposite or Withdrawl Money: ");
            string trasactiontype = Console.ReadLine();

            if (trasactiontype == "deposite")
            {
               string res = B.deposite(123, 500);
                Console.WriteLine(res);
            }
            else if (trasactiontype == "withdrawl")
            {
               string res = B.withdrawl(123, 500);
                Console.WriteLine(res);
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saving_and_current_for_deposite_and_withdrawl
{
    abstract class Account
    {
        public int balance = 5000;
        public int actno;
        public abstract void deposite(int amount);

        public abstract void withdrawl(int amount);

        public void showbalance()
        {
            Console.WriteLine("Available balance for account {0} is {1} ", actno, balance);
        }
    }

    class saving : Account
    {
        public override void deposite(int amount)
        {
            int intrest = 500;
            balance  =  balance + amount + intrest;
            Console.WriteLine("Amount deposited succesfully with intrest...");
        }

        public override void withdrawl(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("Amount withdrawled succesfully...");
        }
    }

    class current : Account
    {
        public override void deposite(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Amount deposited succesfully...");
        }

        public override void withdrawl(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("Amount withdrawled succesfully...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account number: ");
            int accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose account type (current / saving) : ");
            string acctype = Console.ReadLine();
            Console.WriteLine("Do you want to deposite press 'D' or withdrawl press 'W' : ");
            string transactiontype = Console.ReadLine();
            Console.WriteLine("Enter amount: ");
            int amt = Convert.ToInt32(Console.ReadLine());

            Account ac = null;

            if (acctype == "saving" || acctype == "Saving")
            {
                ac = new saving();
            }
            else if (acctype == "current" || acctype == "Current")
            {
                ac = new current();
            }

            if (transactiontype == "d" || transactiontype == "D")
            {
                ac.deposite(amt);
            }
            else if(transactiontype == "w" || transactiontype == "W")
            {
                ac.withdrawl(amt);
            }

            ac.actno = accno;
            ac.showbalance();

            Console.ReadKey();
        }
    }
}

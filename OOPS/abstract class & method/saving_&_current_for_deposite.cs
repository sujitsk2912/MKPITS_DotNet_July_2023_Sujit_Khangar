using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saving_and_current_for_deposite
{
    abstract class Account
    {
        public int balance = 5000;
        public int actno;

        public abstract void deposite(int amount);

        public void showbalance()
        {
            Console.WriteLine("Available balance for Account {0} is {1} ", actno, balance);
        }
    }

    class saving: Account
    {
        public override void deposite(int amount)
        {
            int intrest = 500;
            balance = balance + amount + intrest;
            Console.WriteLine("Amount deposite succesfully with intrest");
        }
    }

    class current: Account
    {
        public override void deposite(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Amount deposite succesfully");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount to be deposited: ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Number: ");
            int accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose your account type (current / saving): ");
            string acttype = Console.ReadLine();

            Account ac = null;

            if (acttype == "current" || acttype == "Current")
            {
                ac = new current();
            }
            else if (acttype == "saving" || acttype == "Saving")
            {
                ac = new saving();
            }
           
            ac.deposite(amt);
            ac.actno = accno;
            ac.showbalance();

            Console.ReadKey();
        }
    }
}

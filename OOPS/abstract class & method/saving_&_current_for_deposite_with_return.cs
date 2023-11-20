using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saving_and_current_for_deposite_with_return
{
    abstract class Account
    {
        public int balance = 5000;
        public int actno;

        public abstract string deposite(int amount);

        public string showbalance()
        {
            return"Available balance for Account " + actno + " is: " + balance;
        }
    }

    class saving : Account
    {
        public override string deposite(int amount)
        {
            int intrest = 500;
            balance = balance + amount + intrest;
            return"Amount deposite succesfully with intrest";
        }
    }

    class current : Account
    {
        public override string deposite(int amount)
        {
            balance = balance + amount;
            return"Amount deposite succesfully";
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

            string res =  ac.deposite(amt);
            ac.actno = accno;
            Console.WriteLine(res);
            res = ac.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

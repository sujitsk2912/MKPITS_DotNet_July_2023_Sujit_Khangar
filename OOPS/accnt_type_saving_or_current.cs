using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accnt_type_saving_or_current
{
    class Account
    {
        public int acntno;
        public int balance = 5000;
        public virtual string Deposite(int acntno, int amount)
        {
            return "deposit method of account class";
        }

        public string Showbalance()
        {
            return "Balance Amount: " + balance;
        }
    }

    class Current : Account
    {
        public override string Deposite(int acntno, int amount)
        {
            this.acntno = acntno;
            balance = balance + amount;

            return "Amount deposited succesfully in current class";
        }
    }

    class Saving : Account
    {
        public override string Deposite(int acntno, int amount)
        {
            this.acntno = acntno;
            int intrest = 500;

            balance = balance + intrest + amount;

            return "Amount deposited with Intrest";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account No.: ");
            int acc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount to be deposited: ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose Account type Saving or Current: ");
            string accnttype = Console.ReadLine();

            Account ac = null;

            if(accnttype == "saving")
            {
                ac = new Saving();
            }
            else if(accnttype == "current")
            {
                ac = new Current();
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            string res = ac.Deposite(acc, amt);
            Console.WriteLine();
            Console.WriteLine("Account No.: " + acc);
            Console.WriteLine(res);
            res = ac.Showbalance();
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}

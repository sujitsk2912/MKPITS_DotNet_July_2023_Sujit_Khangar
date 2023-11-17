using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_three_derive_class_from_account
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
            int acc1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount to be deposited: ");
            int amt1 = Convert.ToInt32(Console.ReadLine());

            Account ac1 = new Current();
            string res = ac1.Deposite(acc1, amt1);
            Console.WriteLine("Account No.: " + acc1);
            Console.WriteLine(res);
            res = ac1.Showbalance();
            Console.WriteLine(res);

            Console.WriteLine("Enter Account No.: ");
            int acc2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount to be deposited: ");
            int amt2 = Convert.ToInt32(Console.ReadLine());

            Account ac2 = new Saving();
            string res2 = ac2.Deposite(acc2, amt2);
            Console.WriteLine("Account No.: " + acc2);
            Console.WriteLine(res2);
            res2 = ac2.Showbalance();
            Console.WriteLine(res2);

            Console.ReadKey();
        }
    }
}

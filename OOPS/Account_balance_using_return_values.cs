using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace show_balance
{
    public class Account
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

    public class Current: Account
    {
        public override string Deposite(int acntno, int amount)
        {
            this.acntno = acntno;
            balance = balance + amount;
            return "Amount Deposited Succesfully...";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Current();
            string res = ac.Deposite(123,3000); 
            Console.WriteLine("Account No. is: " + ac.acntno);
            Console.WriteLine(res);
            res = ac.Showbalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

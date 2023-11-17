using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account_bal_usng_accept_values_from_user
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

            return "Amount Deposited succesfully in current class";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Current();

            Console.WriteLine("Enter Account No.: ");
            int acn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount to be deposited: ");
            int amt = Convert.ToInt32(Console.ReadLine());

            string res = ac.Deposite(acn, amt);
            Console.WriteLine("Account No. is : " + ac.acntno);
            Console.WriteLine(res);
            res = ac.Showbalance();
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}

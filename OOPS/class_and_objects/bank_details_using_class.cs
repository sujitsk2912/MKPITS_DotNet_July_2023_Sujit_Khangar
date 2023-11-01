using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_details_using_class
{
    internal class Program
    {
        class Bank_Account
        {
            long account_no;
            string account_holder;
            int balance;


            public void getdata1(long account_no, string account_holder, int balance1)
            {
                this.account_no = account_no;
                this.account_holder = account_holder;
                balance = balance1;
            }

            public void display1()
            {
                Console.WriteLine("\n---------- USER'S ACCOUNT DETAILS ------------\n");
                Console.WriteLine("Account Number: " + account_no);
                Console.WriteLine("Account Holders Name: " + account_holder);
                Console.WriteLine("Remaining Balance: " + balance);
            }

            public void getdata2(long account_no2, int balance2)
            {
                this.account_no = account_no2;
                balance = balance2;
            }

            public void display2()
            {
                Console.WriteLine("\n---------- RECIEVERS'S ACCOUNT DETAILS ------------\n");
                Console.WriteLine("Account Number: " + account_no);
                Console.WriteLine("Recieved Balance: " + balance);
            }
        }
        static void Main(string[] args)
        {
            int amount = 5000;

            Bank_Account account = new Bank_Account();

            Console.Write("\nEnter Account Number: ");
            long acnt1 = Convert.ToInt64(Console.ReadLine());

            Console.Write("\nAccount Holders Name: ");
            string acnt_name1 = Console.ReadLine();

            Console.Write("\nEnter Amount To be Transfered: ");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Reciver's Account Number: ");
            long acnt2 = Convert.ToInt64(Console.ReadLine());

            if (amt > 0 && amt <= 5000)
            {

                int remaining1 = amount - amt;
                int remaining2 = amount - remaining1;

                account.getdata1(acnt1, acnt_name1, remaining1);
                account.display1();

                account.getdata2(acnt2, remaining2);
                account.display2();
            }

            else
            {
                Console.WriteLine("\nInsufficiant Amount for transfer....... ");
            }

            Console.ReadKey();
        }
    }
}

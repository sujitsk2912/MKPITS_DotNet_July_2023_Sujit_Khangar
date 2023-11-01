using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_customer_class
{
    internal class Program
    {
        class BankCustomer
        {
            string CustomerName;
            long AccountNumber;
            int Balance;

            public void getdata(string CustomerName,  long AccountNumber, int Balance)
            {
                this.CustomerName = CustomerName;
                this.AccountNumber = AccountNumber;
                this.Balance = Balance;
            }

            public void display()
            {
                Console.WriteLine("Customer Name: " + CustomerName);
                Console.WriteLine("\nAccount Number: " +  AccountNumber); 
                Console.WriteLine("\nTotal Balance: " +  Balance);
            }
        }
        static void Main(string[] args)
        {
            int InitialBal = 5000;
            int total = 0;

            BankCustomer customer = new BankCustomer();

            Console.WriteLine("\n----------- CUSTOMER DETAILS --------------\n");
            Console.Write("Enter Customer Name: ");
            string cust_name = Console.ReadLine();

            Console.Write("Enter Account Number: ");
            long acnt_no = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("\nInitial Balance: {0}", InitialBal );

            Console.Write("\nDo you want to Deposite then Press 'D' or 'W' for Withdrwal : ");
            char ch = Convert.ToChar(Console.ReadLine());

            
                if (ch == 'D' || ch == 'd')
                {
                    Console.Write("\nEnter Depositing Amount: ");
                    int Deposite = Convert.ToInt32(Console.ReadLine());
                    total = Deposite + InitialBal;
                    customer.getdata(cust_name, acnt_no, total);
                Console.WriteLine("\n---------- DEPOSITE AMOUNT -------------\n");
                }

                else if (ch == 'W' || ch == 'w')
                {
                    Console.Write("\nEnter Withdrawled Amount: ");
                    int Withdrwal = Convert.ToInt32(Console.ReadLine());
                    total = InitialBal - Withdrwal;
                    customer.getdata(cust_name, acnt_no, total);
                Console.WriteLine("\n---------- WITHDRAWAL AMOUNT -------------\n");
            }
            
                else
                {
                    Console.WriteLine("Invalid Operator");
                }

                 customer.display();
                 Console.ReadKey();
        }
    }
}

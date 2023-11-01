using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_class
{
    internal class Program
    {
        class Product
        {
            string Name;
            int Price;
            int StockQuantity;

            public void getdata(string Name, int StockQuantity, int Price)
            {
                this.Name = Name;
                this.Price = Price;
                this.StockQuantity = StockQuantity;
            }
            public void display()
            {
                Console.WriteLine("\n--------- PRODUCT DETAILS ----------\n");
                Console.WriteLine("Product Name : " + Name);
                Console.WriteLine("Quantity : " + StockQuantity);
                Console.WriteLine("Price: " + Price);
            }
        }
        static void Main(string[] args)
        {
            int stock = 20;

            Product pro = new Product();

            Console.WriteLine("Enter Product Name : ");
            string pro_name = Console.ReadLine();

            Console.WriteLine("Enter Quantity : ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount (price: 10.Rs / item) : ");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (quantity > 0 && quantity <= stock)
            {
                int RemainingStock = stock - quantity;

                pro.getdata(pro_name, quantity, amount);
                pro.display();

                Console.WriteLine("Remaining Stock : " + RemainingStock + " Units");
            }
            else
            {
                Console.WriteLine("\nInsufficent Quantity.......");
            }

            Console.ReadKey();

        }
    }
}
100
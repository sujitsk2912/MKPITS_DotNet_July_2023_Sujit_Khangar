using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass4_product_class_with_parameters
{
    internal class Program
    {
        class Product
        {
            int ProductId;
            string ProductName;
            int Price;
            int Quantity;

            public Product() 
            {
                ProductId = 123;
                ProductName = "Maggie";
                Price = 14;
                Quantity = 5;
            }

            public Product (int productId, string productName, int price, int quantity)
            {
                Console.WriteLine("\n--------------------------------\n");
                ProductId = productId;
                ProductName = productName;
                Price = price;
                Quantity = quantity;
            }

            public void display()
            {
                Console.WriteLine("Product ID: " +  ProductId);
                Console.WriteLine("Product Name: " + ProductName);
                Console.WriteLine("Price: " + Price);
                Console.WriteLine("Quantity: " +  Quantity);
            }
        }
        static void Main(string[] args)
        {
            Product product = new Product();
            product.display();

            Console.WriteLine("\n-------- ENTER PRODUCT DETAILS ----------\n");

            Console.WriteLine("Enter Product ID: ");
            int pid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name: ");
            string pname = Console.ReadLine();

            Console.WriteLine("Enter Price: ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Quantity: ");
            int Q = Convert.ToInt32(Console.ReadLine());

            Product product1 = new Product(pid, pname, p, Q);
            product1.display();

            Console.ReadKey();
        }
    }
}

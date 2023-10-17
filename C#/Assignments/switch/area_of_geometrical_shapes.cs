using System;
namespace GEOMETRYCAL_SHAPE
{
    class program
    {
        public static void Main(string[] args)
        {
            int choice;
            float result = 0;

            Console.Write("Enter Choice (1.circle, 2.rectangle, 3.triangle): ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {

                case 1:
                    int radius;
                    Console.Write("Enter radius: ");
                    radius = Convert.ToInt32(Console.ReadLine());
                    result = 3.14f * radius * radius;
                    Console.WriteLine("\nThe Area of Circle is : " + result);
                    break;

                case 2:
                    int length, width;
                    Console.Write("Enter Length: ");
                    length = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Widht: ");
                    width = Convert.ToInt32(Console.ReadLine());
                    result = length * width;
                    Console.WriteLine("\nThe Area of Rectangle is : " + result);
                    break; 
                
                case 3:
                    int bs, ht;
                    Console.Write("Enter Base: ");
                    bs = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Height: ");
                    ht = Convert.ToInt32(Console.ReadLine());
                    result = (1 / 2f) * bs * ht;
                    Console.WriteLine("\nThe Area of Triangle is : " + result);
                    break;

                default: 
                    Console.WriteLine("\nInvalid Choice: ");
                        break;
             }
                Console.ReadKey();
         }
     }
 }
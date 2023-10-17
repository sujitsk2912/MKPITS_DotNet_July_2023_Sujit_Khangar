using System;
namespace Program
{
    class coicecalculation
    {
        public static void Main(string[] args)
        {
            int choice;
            float result, num1, num2;

            Console.Write("Enter Num1: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Num2: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("\nEnter Choice (1.add, 2.sub, 3.mul, 4.div, 5.exit): ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                result = num1 + num2;
                Console.WriteLine("\nThe Addition of " + num1 + " and " + num2 + " is: " + result);
                    break;

                case 2:
                    result = num1 - num2;
                Console.WriteLine("\nThe Substraction of " + num1 + " and " + num2 + " is: " + result);
                    break;

                    case 3:
                result = num1 * num2;
                Console.WriteLine("\nThe Multiplication of " + num1 + " and " + num2 + " is: " + result);
                    break;

                    case 4:
                result = num1 / num2;
                Console.WriteLine("\nThe Division of " + num1 + " and " + num2 + " is: " + result);
                    break;

                default:
                Console.WriteLine("\n----- Exit -----");
                    break;
            
            }
            Console.ReadKey();
        }
    }
}
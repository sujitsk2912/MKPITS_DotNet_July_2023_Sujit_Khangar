using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method
{
    class Person
    {
        public virtual void display()
        {
            Console.WriteLine("Hello from person class");
        }
    }
        class Student : Person // error occures
        {
            public sealed override void display()
            {
                Console.WriteLine("Hello from student class (sealed)");
            }

        }

    class Person2 : Person
    {
        public override void display()
        {
            Console.WriteLine("hello from person 2 class");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person2 p = new Person2();
            p.display();

            Console.ReadKey();
        }
    }
}




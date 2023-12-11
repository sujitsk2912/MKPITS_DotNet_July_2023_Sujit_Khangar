using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Simulation
{
    internal class Program
    {
        class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Animal(string Name, int Age) 
            { 
                this.Name = Name;
                this.Age = Age;
            }

            public virtual void MakeSound()
            {
                Console.WriteLine("Sounds of Animals");
            }
        }

        class Mammals: Animal
        {
            public Mammals(string Name, int Age): base(Name,Age) 
            {

            }
        }

        class Reptiles:Animal
        {
            public Reptiles(string Name, int Age) : base(Name, Age)
            {

            }

        }

        class Birds:Animal
        {
            public Birds(string Name, int Age) : base(Name, Age)
            {

            }

        }

        class Lion : Mammals
        {
            public Lion(string Name, int Age): base(Name, Age)
            {

            }

            public override void MakeSound()
            {
                Console.WriteLine( "Roars");
            }
        }


        class Snake : Reptiles
        {
            public Snake(string Name, int Age) : base(Name, Age)
            {

            }

            public override void MakeSound()
            {
                Console.WriteLine("Hisssssss");
            }
        }

        class Eagle : Birds
        {
            public Eagle(string Name, int Age) : base(Name, Age)
            {

            }

            public override void MakeSound()
            {
                Console.WriteLine("squidel");
            }
        }

        static void Main(string[] args)
        {
            Lion lion = new Lion("Lion", 56);
            Snake snake = new Snake("Snake", 25);
            Eagle eagle = new Eagle("Eagle", 65);

            Animal[] animal = { lion, snake, eagle};

            foreach (Animal an in animal)
            {
                Console.WriteLine("Name: {0} , Age: {1} ", an.Name, an.Age);
                an.MakeSound();
            }

            Console.ReadKey();
        }
    }
}

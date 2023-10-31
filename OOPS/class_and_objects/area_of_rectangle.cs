using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Reactangle_to_find_area_of_reactangle
{
    internal class Program
    {
        class Rectangle
        {
            float height, width, area;

            public void getdata(float height,  float width)
            {
                this.height = height;
                this.width = width;
            }

            public void display()
            {
                area = height * width;
                Console.WriteLine("\nArea of Rectangle: " + area);
            }
            
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            Console.WriteLine("Enter Widhth: ");
            int wth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height: ");
            int ht = Convert.ToInt32(Console.ReadLine());

            rect.getdata(wth, ht);
            rect.display();

            Console.ReadKey();  

        }
    }
}

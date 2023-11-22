using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntax_of_sealed_class
{
    sealed class Animal // sealed class
    {

    }

    class Dog : Animal // error occure : because Animal class declare sealed
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

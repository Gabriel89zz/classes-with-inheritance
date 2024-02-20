using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace classes_with_inheritance
{
    internal class Dog:Animal
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating croquetes");
        }
    }
}

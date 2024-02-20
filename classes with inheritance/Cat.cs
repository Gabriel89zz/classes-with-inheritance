using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_with_inheritance
{
    internal class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating tuna.");
        }
    }
}

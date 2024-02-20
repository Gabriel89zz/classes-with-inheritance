using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace classes_with_inheritance
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal()
        {
            Name = "";
        }
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
}

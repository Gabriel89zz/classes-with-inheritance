using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_with_inheritance
{
    internal class Cat : Animal
    {
        public Cat() : base()
        {

        }
        public override string Eat()
        {
            return " is eating tuna";
        }
    }
}

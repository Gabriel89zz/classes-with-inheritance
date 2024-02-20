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
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal()
        {
            Name = "";
        }

        public virtual string Eat()
        {
            return " is eating";
        }
    }
}

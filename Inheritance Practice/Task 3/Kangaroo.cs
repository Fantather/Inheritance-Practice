using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice.Task_3
{
    internal class Kangaroo : Animal
    {
        public Kangaroo(string name) : base(name)
        {
            Species = "Kangaroo";
            Habitat = "Australian plains";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} grudge");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} jumps");
        }
    }
}

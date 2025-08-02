using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice.Task_3
{
    internal class Crocodile : Animal
    {
        public Crocodile(string name)
            : base(name)
        {
            Species = "Crocodile";
            Habitat = "Rivers, Lakes";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} wheezes");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} swimming");
        }
    }
}

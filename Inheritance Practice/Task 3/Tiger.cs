using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice.Task_3
{
    internal class Tiger : Animal
    {
        public Tiger(string name) 
            : base(name)
        {
            Species = "Tiger";
            Habitat = "Jungle, Forest";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} make sound Roar");   
        }

        public void Hunt()
        {
            Console.WriteLine($"{Name} hunting");
        }
    }
}

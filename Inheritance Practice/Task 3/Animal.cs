using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice.Task_3
{
    internal class Animal
    {
        public string Name { get; private set; }
        public string Species { get; protected set; } = string.Empty;
        public string Habitat { get; protected set; } = string.Empty;

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Spesies: {Species}");
            Console.WriteLine($"Habitat: {Habitat}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} make sound");
        }
    }
}

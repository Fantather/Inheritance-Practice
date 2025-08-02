using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice.Task_4
{
    internal class Circle : Figure
    {
        public double Radius { get; set; }
        public double Pi = 3.14;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }
    }
}

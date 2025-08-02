using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice.Task_4
{
    internal class RightTriangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public RightTriangle(double bottom, double height)
        {
            Base = bottom;
            Height = height;
        }

        public override double GetArea()
        {
            return Base * (Height / 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice.Task_4
{
    internal class Trapezoid : Figure
    {
        public double TopBase { get; set; }
        public double BottomBase { get; set; }
        public double Height { get; set; }

        public Trapezoid(double topBase, double bottomBase, double height)
        {
            TopBase = topBase;
            BottomBase = bottomBase;
            Height = height;
        }

        public override double GetArea()
        {
            Console.Write("Trapezoid");
            return ((TopBase + BottomBase) * Height) / 2;
        }
    }
}

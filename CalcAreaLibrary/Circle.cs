using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaLibrary
{
    internal class Circle : Figure
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaLibrary
{
    internal class Triangle : Figure
    {
        double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetArea()
        {
            if (isStraightAngle(a, b, c))
            {
                double[] values = [a, b, c];
                double hyp = values.Max();
                values = values.Where(x => x != hyp).ToArray();
                return values[0] * values[1] / 2;
            }
            else
            {
                var p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        bool isStraightAngle(double a, double b, double c)
        {
            return ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a));
        }
    }
}

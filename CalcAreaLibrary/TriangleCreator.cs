using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaLibrary
{
    public class TriangleCreator : FigureCreator
    {
        double a, b, c;
        public TriangleCreator(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override Figure Create()
        {
            if (isValid())
                return new Triangle(a, b, c);
            else
                throw new InvalidDataException("Треугольник с такими сторонами не существует");
        }

        protected override bool isValid()
        {
            return a + b > c && b + c > a && c + a > b && a > 0 && b > 0 && c > 0;
        }
    }
}

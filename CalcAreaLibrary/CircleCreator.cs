using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaLibrary
{
    public class CircleCreator : FigureCreator
    {
        double radius;
        public CircleCreator(double radius)
        {
            this.radius = radius;
        }
        public override Figure Create()
        {
            if (isValid())
                return new Circle(radius);
            else
                throw new InvalidDataException("Радиус должен быть положительным");
        }

        protected override bool isValid()
        {
            return radius > 0;
        }
    }
}

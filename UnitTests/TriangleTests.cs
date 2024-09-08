using CalcAreaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-1, 3, 4)]
        [InlineData(1, 3, 4)]
        public void TriangleValidation(double a, double b, double c)
        {
            Assert.Throws<InvalidDataException>(() => new TriangleCreator(a, b, c).Create().GetArea());
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 12, 13, 30)]
        public void TriangleArea(double a, double b, double c, double expected)
        {
            var result = new TriangleCreator(a, b, c).Create().GetArea();
            Assert.Equal(expected, result);
        }
    }
}

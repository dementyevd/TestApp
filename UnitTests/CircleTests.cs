using CalcAreaLibrary;

namespace UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void CircleValidation()
        {
            Assert.Throws<InvalidDataException>(() => new CircleCreator(-1).Create().GetArea());
        }

        [Fact]
        public void CircleAreaWithRadius5()
        {
            var expected = Math.PI * 25;
            var result = new CircleCreator(5).Create().GetArea();
            Assert.Equal(expected, result);
        }
    }
}
using AreaShapes;

namespace TestAreaShapesProj
{
    public class TriangleTest
    {
        [Fact]
        public void TestAreaTriangle()
        {
            Shape triangle = new Triangle("Треугольник", 5,5,5);

            var areaTriangle = triangle.Area();

            Assert.Equal(10.83, Math.Round(areaTriangle, 2));
        }

        [Fact]
        public void TestRightTriangle()
        {
            Shape triangle = new Triangle("Треугольник", 5, 4, 3);

            var areaTriangle = (triangle as Triangle)!.IsRight();

            Assert.True(areaTriangle);
        }

        [Fact]
        public void TestValidateTriangle()
        {
            Assert.Throws<Exception>(() => { new Triangle("Треугольник", -5, -4, -3); });
        }
    }
}
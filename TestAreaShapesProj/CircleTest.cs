using AreaShapes;

namespace TestAreaShapesProj
{
    public class CircleTest
    {
        [Fact]
        public void TestAreaCircle()
        {
            Shape circle = new Circle("Круг", 5);

            var areaCircle = circle.Area();

            Assert.Equal(78.54, Math.Round(areaCircle,2));
        }
    }
}
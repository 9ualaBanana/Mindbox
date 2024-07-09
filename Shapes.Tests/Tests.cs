namespace Shapes.Tests
{
    /// <summary>
    /// Юнит-тесты.
    /// </summary>
    public class Tests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, Math.PI)]
        [InlineData(2, 4 * Math.PI)]
        [InlineData(3, 9 * Math.PI)]
        public void TestCircle(double radius, double expectedArea) =>
            Assert.Equal(expectedArea, new Circle(radius).CalculateArea(), 6);

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 12, 13, 30)]
        [InlineData(8, 15, 17, 60)]
        public void TestTriangle(double sideA, double sideB, double sideC, double expectedArea) =>
            Assert.Equal(expectedArea, new Triangle(sideA, sideB, sideC).CalculateArea(), 6);

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(5, 12, 13, true)]
        [InlineData(4, 5, 6, false)]
        [InlineData(4, 4, 6, false)]
        public void TestIsRightTriangle(double sideA, double sideB, double sideC, bool expectedResult) =>
            Assert.Equal(expectedResult, new Triangle(sideA, sideB, sideC).IsRight());

        [Theory]
        [InlineData(4, 5, 20)]
        [InlineData(3, 4, 12)]
        [InlineData(2, 3, 6)]
        public void TestRectangle(double width, double height, double expectedArea) =>
            Assert.Equal(expectedArea, new Rectangle(width, height).CalculateArea());

        [Theory]
        [InlineData(4, 4, true)]
        [InlineData(5, 3, false)]
        [InlineData(2, 2, true)]
        [InlineData(6, 6, true)]
        [InlineData(7, 8, false)]
        public void TestIsSquare(double width, double height, bool expectedResult) =>
            Assert.Equal(expectedResult, new Rectangle(width, height).IsSquare());

        [Theory]
        [InlineData(6, 4, 24)]
        [InlineData(5, 3, 15)]
        [InlineData(4, 2, 8)]
        public void TestParallelogram(double @base, double height, double expectedArea) =>
            Assert.Equal(expectedArea, new Parallelogram(@base, height).CalculateArea());

        [Theory]
        [InlineData(4, 6, 5, 25)]
        [InlineData(3, 5, 4, 16)]
        [InlineData(2, 4, 3, 9)]
        public void TestTrapezoid(double baseA, double baseB, double height, double expectedArea) =>
            Assert.Equal(expectedArea, new Trapezoid(baseA, baseB, height).CalculateArea());
    }
}
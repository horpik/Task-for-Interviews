using GeometryCalculator.Shape;

namespace GeometryCalculator.Tests;

[TestFixture]
public class GeometryCalculatorTests
{
    [Test]
    public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
    {
        double radius = 5;
        double expectedArea = 78.53981633974483;

        IShape circle = new Circle(radius);
        double actualArea = GeometryCalculator.CalculateArea(circle);

        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));
    }

    [Test]
    public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        double expectedArea = 6;

        IShape triangle = new Triangle(sideA, sideB, sideC);
        double actualArea = GeometryCalculator.CalculateArea(triangle);

        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001));
    }

    [Test]
    public void IsRightAngled_RightAngledTriangle_ReturnsTrue()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        Triangle triangle = new Triangle(sideA, sideB, sideC);
        bool isRightAngled = triangle.IsRightAngled();

        Assert.IsTrue(isRightAngled);
    }
}
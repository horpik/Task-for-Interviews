namespace GeometryCalculator.Shape;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть положительным числом.");
        }

        _radius = radius;
    }

    public double CalculateArea() => Math.PI * Math.Pow(_radius, 2);
}
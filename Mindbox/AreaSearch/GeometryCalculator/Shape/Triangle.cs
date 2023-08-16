namespace GeometryCalculator.Shape;

public class Triangle : IShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Длина сторон должна быть положительным числом.");
        }

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double CalculateArea()
    {
        double semiperimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(semiperimeter * (semiperimeter - _sideA) * (semiperimeter - _sideB) * (semiperimeter - _sideC));
    }

    public bool IsRightAngled()
    {
        double[] sides = { _sideA, _sideB, _sideC };
        Array.Sort(sides);

        double a2 = Math.Pow(sides[0], 2);
        double b2 = Math.Pow(sides[1], 2);
        double c2 = Math.Pow(sides[2], 2);

        return Math.Abs(a2 + b2 - c2) < 0.0001; // Проверка на прямоугольность с допустимой погрешностью
    }
}
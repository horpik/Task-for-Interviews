using GeometryCalculator.Shape;

namespace GeometryCalculator;

public static class GeometryCalculator
{
    /// <summary>
    /// Метод возвращает посчитанную площадь фигуры
    /// </summary>
    /// <param name="shape"></param>
    /// <returns>double</returns>
    public static double CalculateArea(IShape shape)
    {
        ArgumentNullException.ThrowIfNull(shape);

        return shape.CalculateArea();
    }
}
namespace Shapes;

/// <summary>
/// Позволяет легкость добавления других фигур.
/// </summary>
public interface IShape
{ double CalculateArea(); }

public static class Shape
/// <summary>
/// Вычисление площади фигуры без знания типа фигуры в compile-time.
/// </summary>
{ public static double CalculateArea(IShape shape) => shape.CalculateArea(); }

public record Triangle(double SideA, double SideB, double SideC) : IShape
{
    public double CalculateArea()
    {
        double p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    /// <summary>
    /// Проверка на то, является ли треугольник прямоугольным.
    /// </summary>
    public bool IsRight()
        => Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
            Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2) ||
            Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2);
}

public record Circle(double Radius) : IShape
{ public double CalculateArea() => Math.PI * Radius * Radius; }

public record Rectangle(double Width, double Height) : IShape
{
    public double CalculateArea() => Width * Height;
    public bool IsSquare() => Width == Height;
}

public record Parallelogram(double Base, double Height) : IShape
{ public double CalculateArea() => Base * Height; }

public class Trapezoid(double BaseA, double BaseB, double Height) : IShape
{ public double CalculateArea() => 0.5 * (BaseA + BaseB) * Height; }

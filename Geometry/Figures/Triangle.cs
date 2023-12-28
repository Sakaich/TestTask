using Geometry.Interfaces;

namespace Geometry.Figures;

/// <summary>
/// Треугольник
/// </summary>
public class Triangle : IHaveArea
{
    /// <summary>
    /// Первая сторона треугольника
    /// </summary>
    private double _a;

    /// <summary>
    /// Вторая сторона треугольника
    /// </summary>
    private double _b;

    /// <summary>
    /// Третья сторона треугольника
    /// </summary>
    private double _c;

    /// <summary>
    /// Первая сторона треугольника
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
    public required double A {
        get => _a;

        init
        {
            if (value < double.Epsilon)
            {
                throw new ArgumentException("Triangle's edge cannot be less than or equal to zero");
            }

            _a = value;
        }
    }

    /// <summary>
    /// Вторая сторона треугольника
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
    public required double B {
        get => _b;

        init
        {
            if (value < double.Epsilon)
            {
                throw new ArgumentException("Triangle's edge cannot be less than or equal to zero");
            }

            _b = value;
        }
    }

    /// <summary>
    /// Третья сторона треугольника
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
    public required double C {
        get => _c;

        init
        {
            if (value < double.Epsilon)
            {
                throw new ArgumentException("Triangle's edge cannot be less than or equal to zero");
            }

            _c = value;
        }
    }

    /// <summary>
    /// Возвращает вычисленную площадь треугольника
    /// </summary>
    /// <returns>Численное значение площади треугольника</returns>
    public double GetArea()
    {
        var p = (_a + _b + _c) / 2;

        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    /// <summary>
    /// Проверка на прямоугольность
    /// </summary>
    /// <returns>Результат проверки в булевом формате</returns>
    public bool IsRight()
    {
        var edges = new[] { _a, _b, _c };
        Array.Sort(edges);

        return Math.Abs(Math.Pow(edges[0], 2) + Math.Pow(edges[1], 2) - Math.Pow(edges[2], 2)) < 0.01;
    }
}
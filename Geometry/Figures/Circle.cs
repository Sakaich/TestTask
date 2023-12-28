using Geometry.Interfaces;

namespace Geometry.Figures;

/// <summary>
/// Круг
/// </summary>
public class Circle : IHaveArea
{
    /// <summary>
    /// Радиус
    /// </summary>
    private double _radius;

    /// <summary>
    /// Радиус
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
    public required double Radius
    {
        get => _radius;

        init
        {
            if (value < double.Epsilon)
            {
                throw new ArgumentException("Radius cannot be less than or equal to zero");
            }

            _radius = value;
        }
    }

    /// <summary>
    /// Возвращает вычисленную площадь круга
    /// </summary>
    /// <returns>Численное значение площади круга</returns>
    public double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}
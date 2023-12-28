namespace Geometry.Interfaces;

/// <summary>
/// Фигуры, обладающие свойством площади
/// </summary>
public interface IHaveArea
{
    /// <summary>
    /// Возвращает вычисленную площадь фигуры
    /// </summary>
    /// <returns>Численное значение площади фигуры</returns>
    public double GetArea();
}
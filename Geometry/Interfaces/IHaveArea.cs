namespace Geometry.Interfaces;

/// <summary>
/// Интерфейс для фигур, имеющих площадь
/// </summary>
public interface IHaveArea
{
    /// <summary>
    /// Возвращает вычисленную площадь фигуры
    /// </summary>
    /// <returns>Численное значение площади фигуры</returns>
    public double GetArea();
}
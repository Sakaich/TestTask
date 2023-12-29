using Geometry.Figures;
using Geometry.Interfaces;

namespace Geometry;

/// <summary>
/// Фабрика фигур со свойством площади, для легкости добавления
/// </summary>
public static class FigureFactory
{
    public static IHaveArea GetFigure(FigureTypes type, params double[] values)
    {
        switch (type)
        {
            case FigureTypes.Circle:
                if (values.Length != 1)
                {
                    throw new ArgumentException("To create a \"Circle\" object, you need a parameter with a radius value");
                }

                return new Circle
                {
                    Radius = values[0]
                };
            
            case FigureTypes.Triangle:
                if (values.Length != 3)
                {
                    throw new ArgumentException("To create a \"Triangle\" object, you need 3 parameters with the value of the lengths of the sides");
                }

                return new Triangle
                {
                    A = values[0],
                    B = values[1],
                    C = values[2]
                };
            default:
                throw new ArgumentException("You must select the shape type Circle or Triangle");
        }
    }
}
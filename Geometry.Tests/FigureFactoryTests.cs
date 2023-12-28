using Geometry.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Geometry.Tests;

[TestClass]
public class FigureFactoryTests
{
    /// <summary>
    /// Тест на неуспешное создание экземпляра класса Circle через фабрику
    /// </summary>
    /// <param name="values">Параметры создания фигуры</param>
    [TestMethod]
    [DataRow(new double[] {})]
    [DataRow(new double[] { 1, 2, 3 })]
    [ExpectedException(typeof(ArgumentException))]
    public void FigureFactory_CanGetFigure_Circle_NegativeTest(double[] values)
    {
        _ = FigureFactory.GetFigure(FigureTypes.Circle, values);
    }

    /// <summary>
    /// Тест на успешное создание экземпляра класса Circle через фабрику
    /// </summary>
    /// <param name="values">Параметры создания фигуры</param>
    [TestMethod]
    [DataRow(new double[] { 3 })]
    [DataRow(new double[] { 7 })]
    public void FigureFactory_CanGetFigure_Circle_PositiveTest(double[] values)
    {
        var figure = FigureFactory.GetFigure(FigureTypes.Circle, values);

        Assert.IsInstanceOfType(figure, typeof(Circle));
    }
    
    /// <summary>
    /// Тест на неуспешное создание экземпляра класса Triangle через фабрику
    /// </summary>
    /// <param name="values">Параметры создания фигуры</param>
    [TestMethod]
    [DataRow(new double[] {})]
    [DataRow(new double[] { 1 })]
    [DataRow(new double[] { 1, 2 })]
    [DataRow(new double[] { 1, 2, 3, 4 })]
    [ExpectedException(typeof(ArgumentException))]
    public void FigureFactory_CanGetFigure_Triangle_NegativeTest(double[] values)
    {
        _ = FigureFactory.GetFigure(FigureTypes.Triangle, values);
    }

    /// <summary>
    /// Тест на успешное создание экземпляра класса Triangle через фабрику
    /// </summary>
    /// <param name="values">Параметры создания фигуры</param>
    [TestMethod]
    [DataRow(new double[] { 1, 2, 2 })]
    [DataRow(new double[] { 3, 4, 5 })]
    public void FigureFactory_CanGetFigure_Triangle_PositiveTest(double[] values)
    {
        var figure = FigureFactory.GetFigure(FigureTypes.Triangle, values);

        Assert.IsInstanceOfType(figure, typeof(Triangle));
    }
}
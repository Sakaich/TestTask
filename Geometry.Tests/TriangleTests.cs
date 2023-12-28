using Geometry.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Geometry.Tests;

[TestClass]
public class TriangleTests
{
    /// <summary>
    /// Тест на неуспешное создание экземпляра класса
    /// </summary>
    /// <param name="testA">Первая сторона треугольника</param>
    /// <param name="testB">Вторая сторона треугольника</param>
    /// <param name="testC">Третья сторона треугольника</param>
    [TestMethod]
    [DataRow(-3, 4, 5)]
    [DataRow(7, -7, 7)]
    [DataRow(11, 12, -13)]
    [DataRow(0, 4, 5)]
    [DataRow(7, 0, 7)]
    [DataRow(11, 12, 0)]
    [ExpectedException(typeof(ArgumentException))]
    public void Triangle_CanCreate_NegativeTest(double testA, double testB, double testC)
    {
        _ = new Triangle
        {
            A = testA,
            B = testB,
            C = testC
        };
    }

    /// <summary>
    /// Тест на успешное создание экземпляра класса
    /// </summary>
    /// <param name="testA">Первая сторона треугольника</param>
    /// <param name="testB">Вторая сторона треугольника</param>
    /// <param name="testC">Третья сторона треугольника</param>
    [TestMethod]
    [DataRow(3, 4, 5)]
    [DataRow(7, 7, 7)]
    [DataRow(11, 12, 13)]
    public void Triangle_CanCreate_PositiveTest(double testA, double testB, double testC)
    {
        _ = new Triangle
        {
            A = testA,
            B = testB,
            C = testC
        };
    }

    /// <summary>
    /// Тест метода вычисления площади
    /// </summary>
    /// <param name="testA">Первая сторона треугольника</param>
    /// <param name="testB">Вторая сторона треугольника</param>
    /// <param name="testC">Третья сторона треугольника</param>
    /// <param name="testArea">Ожидаемая величина площади</param>
    [TestMethod]
    [DataRow(3, 4, 5, 6)]
    [DataRow(7, 7, 7, 21.22)]
    [DataRow(11, 12, 13, 61.48)]
    public void Triangle_CanGetArea_Test(double testA, double testB, double testC, double testArea)
    {
        var triangle = new Triangle
        {
            A = testA,
            B = testB,
            C = testC
        };

        Assert.IsTrue(Math.Abs(triangle.GetArea() - testArea) < 0.01);
    }

    /// <summary>
    /// Тест метода проверки треугольника на прямоугольность
    /// </summary>
    /// <param name="testA">Первая сторона треугольника</param>
    /// <param name="testB">Вторая сторона треугольника</param>
    /// <param name="testC">Третья сторона треугольника</param>
    /// <param name="testRightTriangle">Ожидаемый результат проверки</param>
    [TestMethod]
    [DataRow(3, 4, 5, true)]
    [DataRow(7, 7, 7, false)]
    [DataRow(11, 12, 13, false)]
    public void Triangle_CanIsRight_Test(double testA, double testB, double testC, bool testRightTriangle)
    {
        var triangle = new Triangle
        {
            A = testA,
            B = testB,
            C = testC
        };

        Assert.IsTrue(triangle.IsRight() == testRightTriangle);
    }
}
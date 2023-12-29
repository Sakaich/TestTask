using Geometry.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Geometry.Tests;

[TestClass]
public class CircleTests
{
    /// <summary>
    /// Тест на неуспешное создание экземпляра класса
    /// </summary>
    /// <param name="testRadius">Радиус</param>
    [TestMethod]
    [DataRow(-3)]
    [DataRow(-1)]
    [DataRow(0)]
    [ExpectedException(typeof(ArgumentException))]
    public void Circle_CanCreate_NegativeTest(double testRadius)
    {
        _ = new Circle
        {
            Radius = testRadius
        };
    }

    /// <summary>
    /// Тест на успешное создание экземпляра класса
    /// </summary>
    /// <param name="testRadius">Радиус</param>
    [TestMethod]
    [DataRow(1)]
    [DataRow(7)]
    public void Circle_CanCreate_PositiveTest(double testRadius)
    {
        var circle = new Circle
        {
            Radius = testRadius
        };
        
        Assert.AreEqual(circle.Radius, testRadius);
    }

    /// <summary>
    /// Тест метода вычисления площади
    /// </summary>
    /// <param name="testRadius">Радиус</param>
    /// <param name="testArea">Ожидаемая величина площади</param>
    [TestMethod]
    [DataRow(3, 28.27)]
    [DataRow(7, 153.94)]
    [DataRow(10, 314.16)]
    public void Circle_CanGetArea_Test(double testRadius, double testArea)
    {
        var circle = new Circle
        {
            Radius = testRadius
        };

        Assert.IsTrue(Math.Abs(circle.GetArea() - testArea) < 0.01);
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskMindBox;

namespace TaskMindBox.Tests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void CalculateArea_ValidParametrs_CorrectReturns()
    {
        var radius = 5.2;
        var circle = new Circle(radius);

        var result = circle.CalculateArea();

        var expected = Math.PI * radius * radius;
        Assert.AreEqual(expected, result);
    }
}

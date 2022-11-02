using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskMindBox;

namespace TaskMindBox.Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void CalculateArea_ValidParametrs_CorrectReturns()
    {
        var triangle = new Triangle(firstSide: 3, secondSide: 4, thirdSide: 5);

        var result = triangle.CalculateArea();

        Assert.AreEqual(expected: 6, result);
       }

    [TestMethod]
    public void IsRectangular_TriangleIsRectangular_ReturnsTrue()
    {
        var triangle = new Triangle(firstSide: 3, secondSide: 4, thirdSide: 5);

        var result = triangle.IsRectangular();

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsRectangular_TriangleIsNotRectangular_ReturnsFalse()
    {
        var triangle = new Triangle(firstSide: 3, secondSide: 4, thirdSide: 6);

        var result = triangle.IsRectangular();

        Assert.IsFalse(result);
    }

    [TestMethod]
    [DataRow(4, 1, 2)]
    [DataRow(1, 4, 2)]
    [DataRow(1, 2, 4)]
    public void Validate_InvalidSides_ThrowsExeption(double firstSide, double secondSide, double thirdSide)
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(firstSide, secondSide, thirdSide));
    }
}

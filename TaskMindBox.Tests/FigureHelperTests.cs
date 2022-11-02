using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskMindBox;

namespace TaskMindBox.Tests;

[TestClass]
public class FigureHelperTests
{
    [TestMethod]
    public void Validate_ValueIsNaN_ThrowsExeption()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => FigureHelper.Validate(value: double.NaN));
    }

    [TestMethod]
    public void Validate_ValueIsNegative_ThrowsExeption()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => FigureHelper.Validate(value: -1));
    }

    [TestMethod]
    public void Validate_ValueIsZero_ThrowsExeption()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => FigureHelper.Validate(value: 0));
    }

    [TestMethod]
    public void Validate_ValueIsInfinity_ThrowsExeption()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => FigureHelper.Validate(value: double.PositiveInfinity));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => FigureHelper.Validate(value: double.NegativeInfinity));
    }
}

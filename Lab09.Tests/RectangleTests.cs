using NUnit.Framework;

namespace Lab09.Tests;

public class RectangleTests
{
    Rectangle rectangle;
    AbstractGraphic2D shape;

    [SetUp]
    public void Setup()
    {
        rectangle = new Rectangle(3, 4, 5, 6);
        shape = rectangle;
    }

    [Test]
    public void EnsurePropertiesAreCorrect()
    {
        Assert.AreEqual(3, rectangle.Left);
        Assert.AreEqual(4, rectangle.Top);
        Assert.AreEqual(5, rectangle.Width);
        Assert.AreEqual(6, rectangle.Height);
    }

    [Test]
    public void CheckLowerBounds()
    {
        // lower bound is the smallest x that needs to be checked when drawing the shape
        Assert.AreEqual(3, shape.LowerBoundX);
        Assert.AreEqual(4, shape.LowerBoundY);
    }

    [Test]
    public void CheckUpperBounds()
    {
        // upper bound is the largest x that needs to be checked when drawing the shape
        Assert.AreEqual(3 + 5, shape.UpperBoundX);
        Assert.AreEqual(4 + 6, shape.UpperBoundY);
    }

    [Test]
    public void MiddleOfShapeIsIncluded()
    {
        Assert.IsTrue(shape.ContainsPoint(5.5m, 7));
    }

    [Test]
    public void CornersIncluded()
    {
        Assert.IsTrue(shape.ContainsPoint(3, 4));
        Assert.IsTrue(shape.ContainsPoint(8, 4));
        Assert.IsTrue(shape.ContainsPoint(3, 10));
        Assert.IsTrue(shape.ContainsPoint(8, 10));
    }

    [Test]
    public void OutsideOfCornersNotIncludedInShape()
    {
        Assert.IsFalse(shape.ContainsPoint(3 - 0.1m, 4));
        Assert.IsFalse(shape.ContainsPoint(8, 4 - 0.1m));
        Assert.IsFalse(shape.ContainsPoint(3, 10 + 0.1m));
        Assert.IsFalse(shape.ContainsPoint(8 + 0.1m, 10));
    }
}
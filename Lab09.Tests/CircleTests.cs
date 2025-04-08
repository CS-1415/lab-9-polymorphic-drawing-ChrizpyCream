
using NUnit.Framework;

namespace Lab09.Tests;

public class CircleTests
{
    Circle circle;
    AbstractGraphic2D shape;

    [SetUp]
    public void Setup()
    {
        // should be x, y, and radius
        circle = new Circle(8, 10, 2);

        // should extend the abstract class
        shape = circle;
    }

    [Test]
    public void CircleHasCorrectDimensions()
    {
        Assert.AreEqual(8, circle.CenterX);
        Assert.AreEqual(10, circle.CenterY);
        Assert.AreEqual(2, circle.Radius);
    }

    [Test]
    public void HasCorrectBoundingBox()
    {
        Assert.AreEqual(8 - 2, shape.LowerBoundX);
        Assert.AreEqual(10 - 2, shape.LowerBoundY);
        Assert.AreEqual(8 + 2, shape.UpperBoundX);
        Assert.AreEqual(10 + 2, shape.UpperBoundY);
    }

    [Test]
    public void CenterIsIncluded()
    {
        Assert.IsTrue(shape.ContainsPoint(8, 10));
    }

    [Test]
    public void ContainsAllFourPointsOfTheCompass()
    {
        Assert.IsTrue(shape.ContainsPoint(8 - 2, 10));
        Assert.IsTrue(shape.ContainsPoint(8 + 2, 10));
        Assert.IsTrue(shape.ContainsPoint(8, 10 - 2));
        Assert.IsTrue(shape.ContainsPoint(8, 10 + 2));
    }

    [Test]
    public void ShouldNotContainFourCorners()
    {
        Assert.IsFalse(shape.ContainsPoint(8 - 2, 10 - 2));
        Assert.IsFalse(shape.ContainsPoint(8 + 2, 10 - 2));
        Assert.IsFalse(shape.ContainsPoint(8 - 2, 10 + 2));
        Assert.IsFalse(shape.ContainsPoint(8 + 2, 10 + 2));
    }
}
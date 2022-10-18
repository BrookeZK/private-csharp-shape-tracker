using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {
      Triangle newTriangle = new Triangle(2,3,4);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSides_ReturnsSides_Int()
    {
      int length1 = 2;
      int length2 = 3;
      int length3 = 4;
      Triangle newTriangle = new Triangle(length1,length2,length3);
      Assert.AreEqual(2, newTriangle.Side1);
      Assert.AreEqual(3, newTriangle.Side2);
      Assert.AreEqual(4, newTriangle.Side3);
    }

    [TestMethod]
    public void CheckType_ReturnsNotATriangle_String()
    {
      Triangle newTriangle = new Triangle(22,3,4);
      Assert.AreEqual("not a triangle", newTriangle.CheckType());
    }

    [TestMethod]
    public void CheckType_ReturnsIsosceles_String()
    {
      Triangle newTriangle = new Triangle(5,5,7);
      Assert.AreEqual("isosceles triangle", newTriangle.CheckType());
    }

    [TestMethod]
    public void CheckType_ReturnsScalene_String()
    {
      Triangle newTriangle = new Triangle(2,3,4);
      Assert.AreEqual("scalene triangle", newTriangle.CheckType());
    }

    [TestMethod]
    public void CheckType_ReturnsEquilateral_String()
    {
      Triangle newTriangle = new Triangle(3,3,3);
      Assert.AreEqual("equilateral triangle", newTriangle.CheckType());
    }
  }
}
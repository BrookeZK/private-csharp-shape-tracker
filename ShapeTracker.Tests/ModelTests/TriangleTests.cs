using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests : IDisposable
  {
    public void Dispose()
    {
      Triangle.ClearAll();
    }

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
    public void SetSides_UpdatesValueOfSides_Void()
    {
      int length1 = 2;
      int length2 = 3;
      int length3 = 4;
      Triangle newTriangle = new Triangle(60,70,35);
      newTriangle.Side1 = length1;
      newTriangle.Side2 = length2;
      newTriangle.Side3 = length3;
      Assert.AreEqual(2, newTriangle.Side1);
      Assert.AreEqual(3, newTriangle.Side2);
      Assert.AreEqual(4, newTriangle.Side3);
    }

    [TestMethod]
    public void GetAllTriangles_ReturnsTriangleInstances_GetAll()
    {
      Triangle tri1 = new Triangle(32,32,22);
      Triangle tri2 = new Triangle(32,3,9);
      Triangle tri3 = new Triangle(10,10,10);
      List<Triangle> comparisonList = new List<Triangle> ()
      {
        tri1,
        tri2,
        tri3
      };
      CollectionAssert.AreEqual(comparisonList, Triangle.GetAll());
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
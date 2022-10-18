using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests
  {

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(6,6);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]
    public void GetSides_ReturnsSides_Int()
    {
      int length1 = 2;
      int length2 = 3;
      Rectangle newRectangle = new Rectangle(length1,length2);
      Assert.AreEqual(2, newRectangle.Side1);
      Assert.AreEqual(3, newRectangle.Side2);
    }

    [TestMethod]
    public void GetArea_ReturnsAreaOfRectangle_Int()
    {
      Rectangle newRectangle = new Rectangle(6,6);
      Assert.AreEqual(36, newRectangle.GetArea());
    }
    // test('should correctly create a rectangle object using two sides', () => {
    //   expect(rectangle.side1).toEqual(3);
    //   expect(rectangle.side2).toEqual(5);
    // });

    // test('should correctly get the area of a rectangle object', () => {
    //   expect(rectangle.getArea()).toEqual(15);
    // });
  }
}
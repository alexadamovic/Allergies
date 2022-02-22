using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void Triangle_MakeATriangle_SideASideBSideC()
    {
      int sideA = 2;
      int sideB = 4;
      int sideC = 3;
      Triangle testTriangle = new Triangle(sideA, sideB, sideC);
      Assert.AreEqual(2, testTriangle.SideA);
      Assert.AreEqual(4, testTriangle.SideB);
      Assert.AreEqual(3, testTriangle.SideC);
    }
  }
}


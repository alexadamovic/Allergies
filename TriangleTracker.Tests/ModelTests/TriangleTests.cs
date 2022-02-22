using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    private Triangle testTriangle;
    [TestInitialize]
    public void Initialize()
    {
      int sideA = 2;
      int sideB = 4;
      int sideC = 3;
      this.testTriangle = new Triangle(sideA, sideB, sideC);
    }

    [TestMethod]
    public void Triangle_MakeATriangle_SideASideBSideC()
    {
      Assert.AreEqual(2, testTriangle.SideA);
      Assert.AreEqual(4, testTriangle.SideB);
      Assert.AreEqual(3, testTriangle.SideC);
    }

    [TestMethod]
    public void IsTriangle_NoSideIsGreaterThanSumOfOtherTwo_True()
    {
      Assert.AreEqual(true, testTriangle.IsTriangle());
    }
  }
}


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

    [TestMethod]
    public void IsTriangle_NoSideIsGreaterThanSumOfOtherTwo_True()
    {
      int sideA = 2;
      int sideB = 4;
      int sideC = 3;
      Triangle testTriangle = new Triangle(sideA, sideB, sideC);
      Assert.AreEqual(true, testTriangle.IsTriangle());
    }

    [TestMethod]
    public void IsTriangle_NoSideIsGreaterThanSumOfOtherTwo_False()
    {
      int sideA = 2;
      int sideB = 4;
      int sideC = 7;
      Triangle testTriangle = new Triangle(sideA, sideB, sideC);
      Assert.AreEqual(false, testTriangle.IsTriangle());
    }

    [TestMethod]
    public void TriangleType_TriangleIsEquilateral_Equilateral()
    {
      int sideA = 4;
      int sideB = 4;
      int sideC = 4;
      Triangle testTriangle = new Triangle(sideA, sideB, sideC);
      Assert.AreEqual("equilateral", testTriangle.TriangleType());
    }

        [TestMethod]
    public void TriangleType_TriangleIsIsoceles_Isoceles()
    {
      int sideA = 4;
      int sideB = 4;
      int sideC = 2;
      Triangle testTriangle = new Triangle(sideA, sideB, sideC);
      Assert.AreEqual("isoceles", testTriangle.TriangleType());
    }
  }
}


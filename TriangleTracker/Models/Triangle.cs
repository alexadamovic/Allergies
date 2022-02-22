namespace TriangleTracker
{
  public class Triangle
  {
    public int SideA { get; set; }
    public int SideB { get; set; }
    public int SideC { get; set; }
    public Triangle(int sideA, int sideB, int sideC)
    {
      SideA = sideA;
      SideB = sideB;
      SideC = sideC;
    }
  }
}
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

    public bool IsTriangle() 
    {
      if (SideA + SideB < SideC || SideA + SideC < SideB || SideB + SideC < SideA) 
      {
        return false;
      } else 
      {
        return true;
      }
    }

    public string TriangleType()
    {
      if (SideA == SideB && SideB == SideC) 
      {
        return "equilateral";
      }
      else if (SideA == SideB || SideB == SideC || SideA == SideC)
      {
        return "isoceles";
      }
      else
      {
        return "scalene";
      }
    }
  }
}
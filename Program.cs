using System;
using TriangleTracker.Models;

namespace TriangleTracker {

  public class Program {
    public static void Main() {

      Console.WriteLine("Enter a number for side A: ");
      int sideA = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a number for side B: ");
      int sideB = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a number for side C: ");
      int sideC = int.Parse(Console.ReadLine());

      Triangle userTriangle = new Triangle(sideA, sideB, sideC);
      if (userTriangle.IsTriangle()) {
        Console.WriteLine("This triangle is a " + userTriangle.TriangleType());
      } else {
        Console.WriteLine("Oops, this is not a triangle...Try again");
      }
    }
  }
}


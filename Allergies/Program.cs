using System;
using System.Collections.Generic;
using Allergies.Models;

namespace Allergies {

  public class Program {
    public static void Main() {
      Console.WriteLine("Enter allergy score:");
      int userScore = int.Parse(Console.ReadLine());
      Allergy allergy = new Allergy(); 
      List<string> allergens = allergy.GetAllergens(userScore);
      Console.WriteLine("Your allergens are:");
      foreach(string element in allergens) {
        Console.WriteLine(element);
      }

      Console.WriteLine("Press 1 to try again or enter anything else to exit");
      string again = Console.ReadLine();
      if (again == "1")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Okay, bye");
      }
    }
  }
}


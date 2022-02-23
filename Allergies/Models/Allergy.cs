using System;
using System.Collections.Generic;
using System.Reflection;

namespace Allergies.Models
{
  public class Allergy
  {
    public int Cats { get; set; }
    public int Pollen { get; set; }
    public int Chocolate { get; set; }
    public int Tomatoes { get; set; }
    public int Strawberries { get; set; } 
    public int Shellfish { get; set; }
    public int Peanuts { get; set; }
    public int Eggs { get; set; }
    public Allergy()
    {
      Cats = 128;
      Pollen = 64;
      Chocolate = 32;
      Tomatoes = 16;
      Strawberries = 8;
      Shellfish = 4;
      Peanuts = 2;
      Eggs = 1;
    }

    public List<string> GetAllergens(int score)
    {
      List<string> allergens = new List<string>();

      while (score > 0)
      {
        foreach (PropertyInfo property in this.GetType().GetProperties())
        {
          string Key = property.Name;
          int Value = (int)property.GetValue(this, null);
          if (score >= Value) 
          {
            allergens.Add(Key);
            score = score - Value;
          }
        }
      }
      return allergens;
    }
  }
}
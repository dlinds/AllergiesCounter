using System;
using System.Collections.Generic;

namespace Allergies
{
  public class AllergyChecker
  {
    public string AllergyCheck(int score)
    {
      Dictionary<int, string> listOfAllergens = new Dictionary<int, string>() {
        {128, "Cats"},
        {64, "Pollen"},
        {32, "Chocolate"},
        {16, "Tomatoes"},
        {8, "Strawberries"},
        {4, "Shellfish"},
        {2, "Peanuts"},
        {1, "Egg"}
      };

      List<string> outputList = new List<string> { };
      foreach (var allergen in listOfAllergens)
      {
        // Console.WriteLine(allergen.Key);
        // Console.WriteLine(allergen.Value);
        if (score >= allergen.Key)
        {
          outputList.Add(allergen.Value);
          score -= allergen.Key;
        }
      }
      return String.Join(", ", outputList.ToArray());
    }
  }
}

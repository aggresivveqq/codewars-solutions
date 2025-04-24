using System;
using System.Collections.Generic;

public class Kata
{
  public static string GetDrinkByProfession(string p)
  {
   Dictionary<string,string> dict = new Dictionary<string,string>(StringComparer.OrdinalIgnoreCase)
   {
            { "Jabroni", "Patron Tequila" },
            { "School Counselor", "Anything with Alcohol" },
            { "Programmer", "Hipster Craft Beer" },
            { "Bike Gang Member", "Moonshine" },
            { "Politician", "Your tax dollars" },
            { "Rapper", "Cristal" }
  };
    string key = p.Trim();

      return dict.TryGetValue(key,out string result) ? result : "Beer";
  }
}

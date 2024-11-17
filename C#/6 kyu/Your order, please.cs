using System;
using System.Linq;
public static class Kata
{
  public static string Order(string words)
  {
    if (string.IsNullOrEmpty(words))
        {
            return string.Empty;
        }

        return string.Join(" ", words.Split(' ')
                                     .OrderBy(word => word.First(char.IsDigit)));
    }
  }

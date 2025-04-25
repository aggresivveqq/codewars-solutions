using System;
using System.Linq;
public static class Kata
{
  public static int[] TwoHighest(int[] arr)
  {
      var uniqueSorted = arr.Distinct().OrderByDescending(n => n).ToArray();
        return uniqueSorted.Take(2).ToArray();
  }
}

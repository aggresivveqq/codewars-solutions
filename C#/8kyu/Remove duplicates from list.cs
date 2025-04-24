using System;
using System.Collections.Generic;
using System.Linq;
namespace Solution
{
  public static class Program
  {
    public static int[] distinct(int[] a)
    {
     var result = a.Distinct();
      return result.ToArray();
    }
  }
}

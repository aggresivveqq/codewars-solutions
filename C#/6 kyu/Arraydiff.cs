using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
     HashSet <int> bSet = new HashSet<int>(b);
    return a.Where(x => !bSet.Contains(x)).ToArray();
  }
}

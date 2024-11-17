using System;
using System.Linq;
public class Kata
{
    public static int CountBits(int n)
    {
      string binary = Convert.ToString(n,2);
      int count = binary.Count(x => x == '1');
      return count;
    }
}

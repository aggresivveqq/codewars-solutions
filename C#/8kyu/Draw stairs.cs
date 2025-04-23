using System;
using System.Text;
public class Kata
{
  public static string DrawStairs(int n)
  {
     StringBuilder sb = new StringBuilder();
    for (int i = 0; i < n; i++)
    {
      sb.Append(new string(' ', i));
      sb.Append('I');
      if (i != n - 1)
      {
        sb.Append('\n');
      }
    }
    return sb.ToString();
  }
}

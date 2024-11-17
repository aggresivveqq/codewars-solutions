using System.Text.RegularExpressions;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
   return Regex.Replace(str,"([A-Z])"," $1");
  }
}

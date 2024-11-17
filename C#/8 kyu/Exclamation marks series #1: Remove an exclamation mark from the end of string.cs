public class Kata
{
  public static string Remove(string s)
  { 
      if (s.Length > 0 && s[s.Length - 1] == '!')
            {
                return s.Substring(0, s.Length - 1);
            }
            return s;
  }
}

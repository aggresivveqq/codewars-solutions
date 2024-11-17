public class Kata
{
  public static string GetMiddle(string s)
  {
   int length = s.Length;
        int middleIndex = length / 2;

        return length % 2 == 0 
            ? s.Substring(middleIndex - 1, 2) : s[middleIndex].ToString();      
    }
  }

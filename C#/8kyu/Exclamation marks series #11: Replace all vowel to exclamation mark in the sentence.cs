using System;

public static class Kata
{
  public static string Replace(string s)
  {
       string vowels = "aeiouAEIOU";
        char[] result = new char[s.Length];
        
        for (int i = 0; i < s.Length; i++)
        {
            result[i] = vowels.Contains(s[i]) ? '!' : s[i];
        }

        return new string(result);
  }
}

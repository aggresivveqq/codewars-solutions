using System;

public static class Kata
{
  public static string Replace(string s)
  {
        string vowels = "aeiouAEIOU"; 
        foreach (char c in vowels)
        {
            s=  s.Replace(c,'!');
        }
        return s;
    
    }
}

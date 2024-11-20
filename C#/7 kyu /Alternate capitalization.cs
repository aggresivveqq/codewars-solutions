using System;

public static class Kata
{
  public static string[] Capitalize(string s)
  {
       char[] evenIndexed = s.ToCharArray();
        char[] oddIndexed = s.ToCharArray();

        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenIndexed[i] = char.ToUpper(evenIndexed[i]);
            }
            else
            {
                oddIndexed[i] = char.ToUpper(oddIndexed[i]);
            }
        }

        return new string[] { new string(evenIndexed), new string(oddIndexed) };

  }
}

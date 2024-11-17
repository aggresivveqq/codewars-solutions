using System;
public class Kata
{
    public static int Solve(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        int maxValue = 0;
        int current = 0;
        foreach (char ch in s)
        {
            if (ch >= 'a' && ch <= 'z' && "aeiou".IndexOf(ch) == -1)
            {
                current += ch - 'a' + 1;
            }
            else
            {
                if (current > maxValue)
                {
                    maxValue = current;
                }
                current = 0;
            }

        }
        if (current > maxValue)
        {
            maxValue = current;
        }
        return maxValue;
    }
}
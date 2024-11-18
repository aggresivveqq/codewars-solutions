using System;
using System.Collections.Generic;
public class RomanDecode
{
	public static int Solution(string roman)
	{
    var romanToInt = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    int result = 0;

    for (int i = 0; i < roman.Length; i++)
    {    int current = romanToInt[roman[i]];
        if (i + 1 < roman.Length && romanToInt[roman[i + 1]] > current)
        {
            result -= current;
        }
        else
        {
            result += current;
        }
    }

    return result;
	}
}

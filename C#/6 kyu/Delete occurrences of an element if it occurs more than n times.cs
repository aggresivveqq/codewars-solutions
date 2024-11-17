using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        var result = new List<int>();
        var frequency = new Dictionary<int, int>();
        foreach (var number in arr)
        {
            if (!frequency.ContainsKey(number))
            {
                frequency[number] = 0;
            }
            if (frequency[number] < x)
            {
                result.Add(number);
                frequency[number]++;
            }
        }
        return result.ToArray();
    }
}
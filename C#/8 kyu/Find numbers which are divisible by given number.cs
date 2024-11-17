using System;
using System.Collections.Generic;
public class Kata
{
    public static int[] DivisibleBy(int[] numbers, int divisor)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % divisor == 0)
            {
                list.Add(numbers[i]);
            }
        }
        return list.ToArray();

    }
}
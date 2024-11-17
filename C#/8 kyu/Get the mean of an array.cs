using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
    public static int GetAverage(int[] marks)
    {
        List<int> qwe = new List<int>();
        for (int i = 0; i < marks.Length; i++)
        {
            qwe.Add(marks[i]);
        }
        return (int)qwe.Average();
    }
}
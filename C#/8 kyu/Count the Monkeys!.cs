using System;
using System.Collections.Generic;
public static class MonkeyCounter
{
    public static int[] MonkeyCount(int n)
    {
        List<int> qwe = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            qwe.Add(i);
        }
        return qwe.ToArray();
    }
}
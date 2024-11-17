using System;
using System.Collections.Generic;

public static class Kata
{
    public static string CannonsReady(Dictionary<string, string> gunners)
    {
        foreach (var answer in gunners.Values)
        {
            if (answer == "nay")
            {
                return "Shiver me timbers!";
            }
        }
        return "Fire!";
    }
}
using System;

public class Kata
{
    public static bool All(int[] arr, Func<int, bool> fun)
    {
        if (arr.Length == 0)
        {
            return true;
        }
        foreach (int element in arr)
        {
            if (!fun(element))
            {
                return false;
            }
        }
        return true;
    }
}
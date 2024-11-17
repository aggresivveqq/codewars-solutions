using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        HashSet<int> combinedSet = new HashSet<int>(arr1);
        combinedSet.UnionWith(arr2);
        int[] resultArray = combinedSet.ToArray();
        Array.Sort(resultArray);
        return resultArray;
    }
}
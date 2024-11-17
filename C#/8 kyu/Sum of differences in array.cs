using System;
public static class Kata
{
    public static int SumOfDifferences(int[] arr)
    {
        int sum = 0;
        Array.Sort(arr);
        Array.Reverse(arr);
        for (int i = 0; i < arr.Length - 1; i++)
        {
            sum += arr[i] - arr[i + 1];
        }
        return sum;
    }
}
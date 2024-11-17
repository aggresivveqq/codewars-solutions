using System;

public static class Kata
{
    public static int NearestSq(int n)
    {
        int root = (int)Math.Sqrt(n);
        int lowerSquare = root * root;
        int upperSquare = (root + 1) * (root + 1);
        if (lowerSquare == n)
        {
            return n;
        }
        else if (Math.Abs(n - lowerSquare) < Math.Abs(n - upperSquare))
        {
            return lowerSquare;
        }
        else
        {
            return upperSquare;
        }
    }
}
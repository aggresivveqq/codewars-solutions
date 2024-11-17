using System;

public class Kata
{
    public static int Remainder(int a, int b)
    {
        int larger = Math.Max(a, b);
        int smaller = Math.Min(a, b);

        if (smaller == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }

        return larger % smaller;
    }
}
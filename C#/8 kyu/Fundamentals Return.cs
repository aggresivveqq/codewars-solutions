using System;
public static class Kata
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subt(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }

    public static int Mod(int a, int b)
    {
        return a % b;
    }

    public static int Exponent(int a, int b)
    {
        return (int)Math.Pow(a, b);
    }

}
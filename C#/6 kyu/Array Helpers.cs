using System;
using System.Linq;

static class Extensions
{
    public static int[] Square(this int[] numbers)
    {
        return numbers.Select(x => x * x).ToArray();
    }

    public static int[] Cube(this int[] numbers)
    {
        return numbers.Select(x => x * x * x).ToArray();
    }

    public static double Average(this int[] numbers)
    {
        return numbers.Length == 0 ? double.NaN : System.Linq.Enumerable.Average(numbers);
    }

    public static int Sum(this int[] numbers)
    {
        return System.Linq.Enumerable.Sum(numbers);
    }

    public static int[] Even(this int[] numbers)
    {
        return numbers.Where(x => x % 2 == 0).ToArray();
    }

    public static int[] Odd(this int[] numbers)
    {
        return numbers.Where(x => x % 2 != 0).ToArray();
    }
}

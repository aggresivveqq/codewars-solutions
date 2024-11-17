using System.Numerics;
using System;
public class Kata
{
    public static bool AmIWilson(int p)
    {

        if (p < 2 || !IsPrime(p))
            return false;

        BigInteger factorialPart = Factorial(p - 1) + 1;
        BigInteger divisor = p * p;

        return factorialPart % divisor == 0;
    }

    private static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    private static BigInteger Factorial(int n)
    {
        BigInteger result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

}
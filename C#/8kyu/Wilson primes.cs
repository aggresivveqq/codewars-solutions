using System.Numerics;
public class Kata
{
  public static bool AmIWilson(int p)
    {
        BigInteger bottom = p * p;
        BigInteger upper = Factorial(p - 1) + 1;

        return upper % bottom == 0; 
    }

    public static BigInteger Factorial(int n)
    {
        BigInteger result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }
  }

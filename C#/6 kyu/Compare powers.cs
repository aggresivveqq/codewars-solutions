using System;

class Kata
{
    public static int ComparePowers(int[] a, int[] b)
    {
        int base1 = a[0];
        int exponent1 = a[1];
        int base2 = b[0];
        int exponent2 = b[1];

        double logValue1 = exponent1 * Math.Log(base1);
        double logValue2 = exponent2 * Math.Log(base2);

  
        if (logValue1 > logValue2) return -1;
        if (logValue1 < logValue2) return 1;
        return 0;
    }
}

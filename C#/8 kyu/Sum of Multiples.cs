using System;
public class Kata
{
	public static int SumMul(int n, int m)
	{
		if (n <= 0 || n >= m)
		{
			throw new ArgumentException("");
		}


		int sum = 0;
		for (int i = n; i < m; i += n)
		{
			sum += i;
		}

		return sum;
	}
}

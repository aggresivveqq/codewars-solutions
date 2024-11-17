namespace myjinxin
{
	using System;
	using System.Linq;

	public class Kata
	{
		public int[] LuxuriousHouse(int[] arr)
		{
			int length = arr.Length;
			int[] result = new int[length];
			for (int i = 0; i < length; i++)
			{
				int maxRight = arr.Skip(i + 1).DefaultIfEmpty(0).Max();

				if (arr[i] > maxRight)
				{
					result[i] = 0;
				}
				else
				{
					result[i] = maxRight - arr[i] + 1;
				}
			}
			return result;
		}
	}
}
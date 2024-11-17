public class Kata
{
	public static int[] DifferenceInAges(int[] ages)
	{
		int min = 100;
		int max = 0;
		for (int i = 0; i < ages.Length; i++)
		{
			if (max < ages[i])
			{
				max = ages[i];
			}
		}
		for (int i = 0; i < ages.Length; i++)
		{
			if (ages[i] < min)
			{
				min = ages[i];
			}
		}
		if (min < 1)
		{
			min = 0;
		}

		return new int[] { min, max, max - min };
	}
}
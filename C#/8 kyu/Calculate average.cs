using System;
using System.Linq;
class AverageSolution
{
	public static double FindAverage(double[] array)
	{
		if (array.Length == 0)
		{
			return 0;
		}
		return array.Average();
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
public class DropWorst
{
	public static bool CalculateScores(int numberToDrop, string[] examResults)
	{
		List<int> scores = examResults.Select(int.Parse).ToList();
		double originalAverage = scores.Average();
		for (int i = 0; i < numberToDrop; i++)
		{
			if (scores.Count <= 2) break;
			scores.Remove(scores.Min());
			scores.Remove(scores.Max());
		}
		double newAverage = scores.Average();
		return newAverage > originalAverage;
	}
}
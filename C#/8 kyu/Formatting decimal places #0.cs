using System;

public class Numbers
{
	public static double TwoDecimalPlaces(double number)
	{
		double res = Math.Round(number, 2);
		return res;
	}
}
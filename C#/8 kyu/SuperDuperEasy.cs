using System;

public class Kata
{
	public static string Problem(String a)
	{
		double b = 0;
		bool serjezno = Double.TryParse(a, out b);
		if (serjezno)
		{
			b = Double.Parse(a);
			return ((b * 50) + 6).ToString();
		}
		else
		{
			return "Error";
		}


	}
}
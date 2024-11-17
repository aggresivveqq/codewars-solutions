using System;
using System.Collections.Generic;
public class Kata
{
	public static object[] IsVow(object[] a)
	{
		var vowels = new Dictionary<int, string>
		{
			{ 97, "a" },
			{ 101, "e" },
			{ 105, "i" },
			{ 111, "o" },
			{ 117, "u" }
		};


		for (int i = 0; i < a.Length; i++)
		{
			if (a[i] is int num && vowels.ContainsKey(num))
			{
				a[i] = vowels[num];
			}
		}

		return a;
	}
}
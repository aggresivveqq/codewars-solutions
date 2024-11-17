using System;
using System.Collections.Generic;
public class Kata
{
	public static string[] FixTheMeerkat(string[] arr)
	{
		return new List<string> { arr[2], arr[1], arr[0] }.ToArray();
	}
}
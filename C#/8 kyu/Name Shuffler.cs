using System;

public class Kata
{
	public static string NameShuffler(string str)
	{
		var name = str.Split(' ');
		string first = name[0];
		string second = name[1];
		return second + " " + first;
	}
}
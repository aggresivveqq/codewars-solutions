using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
	public static bool IsPangram(string str)
	{
		string newString = new string(str.Where(c => char.IsLetter(c)).ToArray()).ToLower();
		var letterSet = new HashSet<char>(newString);
		return letterSet.Count == 26;

	}
}
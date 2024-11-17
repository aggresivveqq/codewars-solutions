using System;
using System.Text.RegularExpressions;

public class Kata
{
	public static bool ValidateCode(string code)
	{
		string codeString = code.ToString();
		return Regex.IsMatch(codeString, @"^[1-3]");
	}
}
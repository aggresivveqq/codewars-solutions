using System;
using System.Collections.Generic;

public class Kata
{
	public static string Rot13(string message)
	{
		Dictionary<char, char> mapper = new Dictionary<char, char>();
		for (char c = 'a'; c <= 'z'; c++)
		{
			char shifted = (char)((c - 'a' + 13) % 26 + 'a');
			mapper[c] = shifted;
		}
		for (char c = 'A'; c <= 'Z'; c++)
		{
			char shifted = (char)((c - 'A' + 13) % 26 + 'A');
			mapper[c] = shifted;
		}
		List<char> result = new List<char>();

		foreach (var ch in message)
		{
			if (mapper.ContainsKey(ch))
			{
				result.Add(mapper[ch]);
			}
			else
			{
				result.Add(ch);
			}
		}
		return new string(result.ToArray());
	}
}

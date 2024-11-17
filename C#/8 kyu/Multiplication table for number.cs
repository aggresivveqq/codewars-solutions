using System;

public static class Kata
{
	public static string MultiTable(int number)
	{
		var result = "";
		for (int i = 1; i <= 10; i++)
		{
			result += $"{i} * {number} = {i * number}";
			if (i < 10)
			{
				result += "\n";
			}

		}
		return result;

	}

}
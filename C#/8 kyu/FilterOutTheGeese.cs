using System.Collections.Generic;

public static class Filter
{
	public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
	{

		string[] geese = { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

		foreach (string bird in birds)
		{
			bool isGoose = false;
			foreach (string goose in geese)
			{
				if (bird == goose)
				{
					isGoose = true;
					break;
				}
			}

			if (!isGoose)
			{
				yield return bird;
			}
		}
	}
}
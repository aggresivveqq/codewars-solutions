public class Kata
{
	public static string DuckDuckGoose(Player[] players, int goose)
	{
		int effectiveIndex = (goose - 1) % players.Length;
		return players[effectiveIndex].Name;
	}
}
public class Player
{
	public string Name { get; set; }

	public Player(string name)
	{
		this.Name = name;
	}
}
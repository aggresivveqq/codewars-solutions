using System.Linq;

public static class Kata
{
    public static int TotalPoints(string[] games)
    {
        int score = 0;
        for (int i = 0; i < games.Length; i++)
        {
            string target = string.Concat(games[i]);
            string firstTeam = target.Substring(0, 1);
            int result = int.Parse(firstTeam);
            string secondTeam = target.Last().ToString();

            int result2 = int.Parse(secondTeam);
            if (result > result2)
            {
                score += 3;
            }
            else if (result == result2)
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
        }
        return score;
    }
}
public static class Kata
{
    public static bool IsLockNessMonster(string sentence)
    {

        string[] monsterPhrases = { "tree fiddy", "3.50", "three fifty" };

        foreach (var check in monsterPhrases)
        {
            if (sentence.ToLower().Contains(check))
            {
                return true;
            }
        }

        return false;
    }
}
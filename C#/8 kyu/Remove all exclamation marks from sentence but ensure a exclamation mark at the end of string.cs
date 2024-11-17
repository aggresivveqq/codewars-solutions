public class Kata
{
    public static string Remove(string s)
    {
        string result = s.Replace("!", "");
        return result + "!";
    }
}
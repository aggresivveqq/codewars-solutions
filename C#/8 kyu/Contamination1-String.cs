public class Kata
{
    public static string Contamination(string text, string character)
    {
        if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(character))
        {
            return string.Empty;
        }
        return new string(character[0], text.Length);


    }
}
public class Kata
{
    public static string Remove(string s, int n)
    {
        char[] chars = s.ToCharArray();
        int count = 0;

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == '!' && count < n)
            {
                chars[i] = '\0';
                count++;
            }
        }

        return new string(chars).Replace("\0", "");
    }
}
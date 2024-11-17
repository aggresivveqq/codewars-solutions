public class ShortLongShort
{
    public static string Solution(string a, string b)
    {
        int Acheck = a.Length;
        int Bcheck = b.Length;
        if (Acheck < Bcheck)
        {
            return a + b + a;
        }
        else
        {
            return b + a + b;
        }
    }
}
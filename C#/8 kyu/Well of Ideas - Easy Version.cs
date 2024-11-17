public class Kata
{
    public static string Well(string[] x)
    {
        int qwe = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == "good")
            {
                qwe++;
            }
        }
        if (qwe == 1 || qwe == 2)
        {
            return "Publish!";
        }
        else if (qwe > 2)
        {
            return "I smell a series!";
        }
        else
        {
            return "Fail!";
        }
    }
}
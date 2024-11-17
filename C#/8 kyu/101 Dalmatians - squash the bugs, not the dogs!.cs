using System.Collections.Generic;
public static class Kata
{
    public static string HowManyDalmatians(int n)
    {
        List<string> dogs = new List<string>()
            {
                "Hardly any",
                "More than a handful!",
                "Woah that's a lot of dogs!",
                "101 DALMATIONS!!!"
            };

        string respond;

        if (n <= 10)
        {
            respond = dogs[0];
        }
        else if (n <= 50)
        {
            respond = dogs[1];
        }
        else if (n == 101)
        {
            respond = dogs[3];
        }
        else
        {
            respond = dogs[2];
        }

        return respond;
    }
}